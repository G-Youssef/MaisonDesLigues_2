using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;  // bibliothèque pour les expressions régulières
using MaisonDesLigues_2;

namespace BaseDeDonnees
{
    class Bdd
    {
        //
        // propriétés membres
        //
        private OracleConnection CnOracle;
        private OracleCommand UneOracleCommand;
        private OracleDataAdapter UnOracleDataAdapter;
        private DataTable UneDataTable;
        private OracleTransaction UneOracleTransaction;
        //
        // méthodes
        //

        /// <summary>
        /// constructeur de la connexion
        /// </summary>
        /// <param name="UnLogin">login utilisateur</param>
        /// <param name="UnPwd">mot de passe utilisateur</param>
        public Bdd(String UnLogin, String UnPwd)
        {
            try
            {
                /// <remarks>on commence par récupérer dans CnString les informations contenues dans le fichier app.config
                /// pour la connectionString de nom StrConnMdl
                /// </remarks>
                ConnectionStringSettings CnString = ConfigurationManager.ConnectionStrings["StrConnMdl"];
                ///<remarks>
                /// on va remplacer dans la chaine de connexion les paramètres par le login et le pwd saisis
                ///dans les zones de texte. Pour ça on va utiliser la méthode Format de la classe String.                /// 
                /// </remarks>
                CnOracle = new OracleConnection(string.Format(CnString.ConnectionString, UnLogin, UnPwd));
                CnOracle.Open();
            }
            catch (OracleException Oex)
            {
                throw new Exception("Erreur à la connexion" + Oex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de fermer la connexion
        /// </summary>
        public void FermerConnexion()
        {
            this.CnOracle.Close();
        }

        /// <summary>
        /// méthode permettant de renvoyer un message d'erreur provenant de la bd
        /// après l'avoir formatté. On ne renvoie que le message, sans code erreur
        /// </summary>
        /// <param name="unMessage">message à formater</param>
        /// <returns>message formaté à afficher dans l'application</returns>
        private String GetMessageOracle(String unMessage)
        {
            String[] message = Regex.Split(unMessage, "ORA-");
            return (Regex.Split(message[1], ":"))[1];
        }

        /// <summary>
        ///  méthode publique permettant de récuperer les participants ayant le champs dateenregarrive à null
        /// </summary>
        /// <returns>un objet de type datatable contenant les données récupérées</returns>
        public DataTable ObtenirInfoParticipant()
        {
            string Sql = "select id,concat(concat(nom,'    '),prenom) as nomPrenom,nom,prenom,adresse1,adresse2,cp,ville,tel,mail from MDL.VPARTICIPANT01 where dateenregarrive is null order by nom";
            this.UneOracleCommand = new OracleCommand(Sql, CnOracle);
            UnOracleDataAdapter = new OracleDataAdapter();
            UnOracleDataAdapter.SelectCommand = this.UneOracleCommand;
            UneDataTable = new DataTable();
            UnOracleDataAdapter.Fill(UneDataTable);
            return UneDataTable;
        }

        /// <summary>
        /// Procédure publique qui va appeler la procédure stockée permettant de mettre à jour un participant
        /// </summary>
        /// <param name="pIdParticipant">Id du participant à mettre à jour</param>
        /// <param name="pCleWifi">La clé wifi (généré ou null)</param>
        public void MajParticipant(Int32 pIdParticipant,String pCleWifi )
        {
            String MessageErreur = "";
            try
            {
                UneOracleCommand = new OracleCommand("pckparticipant.enregistrearriveparticipant", CnOracle); //Package.procedure
                UneOracleCommand.CommandType = CommandType.StoredProcedure;
                // Paramètres qui stocke l'ID du participant ainsi que la clé wifi de celui-ci
                UneOracleCommand.Parameters.Add("pIdParticipant", OracleDbType.Int32, ParameterDirection.Input).Value = pIdParticipant;
                UneOracleCommand.Parameters.Add("pCleWifi", OracleDbType.Char, ParameterDirection.Input).Value = pCleWifi;
                // début de la transaction Oracle il vaut mieyx gérer les transactions dans l'applicatif que dans la bd dans les procédures stockées.
                UneOracleTransaction = this.CnOracle.BeginTransaction();
                //execution
                UneOracleCommand.ExecuteNonQuery();
                // fin de la transaction. Si on arrive à ce point, c'est qu'aucune exception n'a été levée
                UneOracleTransaction.Commit();
            }
            catch (OracleException Oex)
            {

                MessageErreur = this.GetMessageOracle(Oex.Message);
            }
            catch (Exception)
            {

                MessageErreur = "Erreur de la mise à jour du participant";
            }
            finally
            {
                if (MessageErreur.Length > 0)
                {
                    // annulation de la transaction
                    UneOracleTransaction.Rollback();
                    // Déclenchement de l'exception
                    throw new Exception(MessageErreur);
                }
            }
        }

    }
}
