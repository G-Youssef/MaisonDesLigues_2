using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDeDonnees;
using ThoughtWorks.QRCode.Codec;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Net;



namespace MaisonDesLigues_2
{
    public partial class FrmPrincipale : Form
    {
        private const int CS_NOCLOSE = 0x0200;
        /// <summary>
        /// Desactive La croix rouge du winform
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private Bdd UneConnexion;
        private String TitreApplication;
        private DataTable unParticipant;
        private String NomParticip;
        private String PrenomParticip;
        private String UrlImageQrCOde;
        String UneCleWifi;

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        public FrmPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// création et ouverture d'une connexion vers la base de données sur le chargement du formulaire
        /// Ainsi que le chargement de la combobox des participants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipale_Load(object sender, EventArgs e)
        {
            UneConnexion = ((FrmLogin)Owner).UneConnexion;
            TitreApplication = ((FrmLogin)Owner).TitreApplication;
            this.Text = TitreApplication;
            
            //Chargement de la combobox contenant tous les participants dont on doit enregistrer leur arrivé.
            unParticipant = UneConnexion.ObtenirInfoParticipant();
            CmbParticipant.DataSource = unParticipant;
            CmbParticipant.ValueMember = "id";
            CmbParticipant.DisplayMember = "nomPrenom";
            CmbParticipant.SelectedIndex = -1;
           
            //Test si le contenu de la combobox est vide
            if (CmbParticipant.Items.Count == 0)
            {
                // Si celle-ci l'est, alors on affiche un message d'alerte et on ferme la connexion ainsi que l'application
                if (MessageBox.Show("Il n'y a pas de participant dont l'arrivé doit être enregistrer, vous aller quitter cette application", ConfigurationManager.AppSettings["TitreApplication"], MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    UneConnexion.FermerConnexion();
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// gestion de l'événement click du bouton quitter.
        /// Demande de confirmation avant de quitetr l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter l'application ?", ConfigurationManager.AppSettings["TitreApplication"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UneConnexion.FermerConnexion();
                Application.Exit();
            }
        }

        /// <summary>
        /// Fonction privée permettant de générer une clé wifi WPA
        /// Une clef (ou "passphrase") WPA peut avoir une taille comprise entre 8 et 63 caractères. 
        /// Le choix des caractères est libre. 
        /// </summary>
        /// <param name="maxLength">Definit la taille de la clé WPA</param>
        /// <returns>Retourne une suite de chiffre et de lettre formant la clé wifi</returns>
        private string GenerateKeyWPA(int maxLength)
        {
            #region initVars
            string tmp = "";
            tmp = string.Empty;

            int iVal = 11;
            char c = (char)iVal;
            int k = 0;
            Random rd = new Random(System.DateTime.Now.Millisecond);
            bool b1;
            bool b2;
            bool b3;
            bool b4;

            #endregion
            while (tmp.Length != maxLength)
            {
                iVal = rd.Next(0, 123);
                c = (char)iVal;

                b1 = char.IsLetterOrDigit(c);
                b2 = char.IsNumber(c);
                b3 = (b1 || b2);

                if (!b1)
                    goto next;

                b4 = (char.IsSeparator(c) || char.IsSymbol(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c));

                if (b4)
                    goto next;

                if (char.IsSurrogate(c))
                    goto next;

                if (tmp.Length > 1 && tmp[tmp.Length - 1] == c)
                    goto next;

                if (b3)
                {
                    if ((char.IsNumber(c) || char.IsDigit(c)))
                    {
                        int num = int.Parse(c.ToString());
                        if (num < 10)
                            tmp += iVal.ToString();
                    }
                    else
                    {
                        if (char.IsLetter(c))
                        {
                            if (tmp.Length == 0)
                                tmp += c;
                            else
                                if (tmp[tmp.Length - 1] != c)
                                    tmp += c;
                        }
                    }
                }
            next:
                k++;
            }
            return tmp;
        }

        /// <summary>
        /// Procédure publique permettant de générer le QrCode contenant l'id du participant et de placer cette image dans le PictureBox présent dans l'interface de l'application 
        /// </summary>
        public void GenereQrCode()
        {
            // création et instanciation de l'objet QrCode
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            // paramètres de cet objet//
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 7;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            System.Drawing.Image image;
            //donnée présente dans le QrCode(ici l'id du participant séléctionné dans le combobox)
            String data = CmbParticipant.SelectedValue.ToString();
            //on crée l'image contenant le QrCode
            image = qrCodeEncoder.Encode(data);
            //On place l'image crée dans le PictureBox situé dans l'interface de l'application
            picEncode.Image = image;

        }

        /// <summary>
        /// procédure privée permettant  de charger les infos du participant dans les TextBox appropriées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbParticipant_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            
            PanArrivéParticipant.Visible = true;
            BtnEnregistreArrivé.Enabled = true;
            RdbWifiOui.Enabled = true;
            RdbWifiNon.Enabled = true;

            TxtAdresse1.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["adresse1"].ToString();
            TxtAdresse2.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["adresse2"].ToString();
            TxtCpParticipant.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["cp"].ToString();
            TxtVilleParticipant.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["ville"].ToString();
            TxtMailParticipant.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["mail"].ToString();
            TxtTélParticipant.Text = unParticipant.Rows[CmbParticipant.SelectedIndex]["tel"].ToString();
        }

        /// <summary>
        /// Cette procédure va appeler la procédure .... qui aura pour but d'enregistrer les éléments de la modification du participants
        /// et va faire appel à la procédure GenereQrCode afin de générer le QrCode d'un participant donné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregistreArrivé_Click(object sender, EventArgs e)
        {
            // Variables permettant de récupérer le nom et le prenom du participant séléctionné
            NomParticip = unParticipant.Rows[CmbParticipant.SelectedIndex]["nom"].ToString();
            PrenomParticip = unParticipant.Rows[CmbParticipant.SelectedIndex]["prenom"].ToString();

            

            //Test si le bouton radio 'clé wifi OUI' est checked
            if (RdbWifiOui.Checked == true)
            {
                //On génére une clé WPA d'une longueur 24
                UneCleWifi = GenerateKeyWPA(24);
                CreeImageWifi();
            }

            picEncode.Visible = true;
            //On appel la fonction GenereQrCode afin d'attribuer au participant un QrCode que l'on va afficher dans le PictureBox
            GenereQrCode();
            EnregistrerImage();
            EnvoiEmailSmtp();

            try
            {
                //on appel la procédure qui va permettre de mettre à jour le participant et ainsi enregistré son arrivé
                UneConnexion.MajParticipant(Convert.ToInt32(CmbParticipant.SelectedValue), UneCleWifi);
                MessageBox.Show("L'arrivé de " + NomParticip + " " + PrenomParticip + " a bien été enregistrer, Veuillez maintenant imprimer le QrCode afin de procéder à la création de la carte du participant ou bien passer à un nouveau enregistrement");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            PanBtnQrCode.Visible = true;
            BtnEnregistreArrivé.Enabled = false;
            CmbParticipant.Enabled = false;
            RdbWifiOui.Enabled = false;
            RdbWifiNon.Enabled = false;

        }

        /// <summary>
        /// procédure publique permettant d'imprimer le Qrcode généré contenat l'Id du participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImprimQrCode_Click(object sender, EventArgs e)
        {
            //Document à imprimer contenant le QrCode
            printDialog1.Document = printQrCode;

            //Page sur laquelle on va séléctionné une imprimante
            DialogResult r = printDialog1.ShowDialog();

            //Test, si l'utilisateur clique sur imprimer
            if (r == DialogResult.OK)
            {
                //On imprime le document
                printQrCode.Print();

                //on recharge le forumailre principale afin de mettre à jour le combobox participant
                FrmPrincipale_Load(null, null);
                PanArrivéParticipant.Visible = false;
                picEncode.Dispose();
                picCléwifi.Dispose();
                PanBtnQrCode.Visible = false;
                CmbParticipant.Enabled = true;
            }
        }

        /// <summary>
        /// procédure privée permettant de dessiner le QRCOde et la clé wifi sur le document à imprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printQrCode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(picEncode.Image,410,150);
            e.Graphics.DrawImage(picCléwifi.Image,395,345);

        }

        /// <summary>
        /// Procédure privée permettant d'enregistrer automatiquement l'image contenant le QrCode dans un dossier spécifié sur le poste
        /// </summary>
        private void EnregistrerImage()
        {   
            UrlImageQrCOde = @"C:\Users\" + NomParticip + "_" + PrenomParticip + ".Jpeg";
            this.picEncode.Image.Save(UrlImageQrCOde,System.Drawing.Imaging.ImageFormat.Jpeg);      
        }

        /// <summary>
        /// Procédure privée permettant d'envoyer un email à travers un serveur smtp au participant dont on a enregistré son arrivé
        /// </summary>
        private void EnvoiEmailSmtp()
        {
            String Wifi=null;
            //Test si le bouton radio 'clé wifi OUI' est checked
            if (RdbWifiOui.Checked == true)
            {
                Wifi = "Voici votre Clé Wifi : " + UneCleWifi + "\n\n" ;
            }

            // Objet mail
            MailMessage msg = new MailMessage();

            // Expéditeur
            msg.From = new MailAddress("projetmaisondesligues@gmail.com","Maison des Ligues");

            // Destinataires
            msg.To.Add(new MailAddress(TxtMailParticipant.Text,NomParticip + " " + PrenomParticip));
            
            // Texte du mail 
            msg.Body = "Bonjour " + PrenomParticip + " " + NomParticip + ".\n\n\n" +
            "Nous vous confirmons que votre arrivé au sein de la Maison des Ligues à été bien enregistré\n" +
            "Une copie du QrCOde présente sur votre carte vous a été envoyé en pièce jointe. Ainsi il vous ai possible de présenter le QrCOde à partir de votre téléphone portable lorsque vous vous présentez à un atelier.\n\n" +
             Wifi +
            "Nous vous souhaitons un agréable séjour parmis nous et n'oubliez pas de présenter votre QRCode à chaque fois que vous vous présenter à un atelier\n\n" +
            "Cordialement,\n\n" +
            "La Maison des Ligues";

            // Fichier joint contenant le QrCode en format Jpeg
            msg.Attachments.Add(new Attachment(UrlImageQrCOde));

            // Envoi du message SMTP
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;

            // Envoi du mail
            try
            {
                client.Send(msg);
            }
            catch (SmtpException e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        /// <summary>
        /// Bouton Enregistrer nouveau participant permettant de passer à l'enregistrement d'un nouveau participant contenu dans la liste déroulante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewEnregistrementPart_Click(object sender, EventArgs e)
        {
            FrmPrincipale_Load(null, null);
            PanArrivéParticipant.Visible = false;
            picEncode.Dispose();
            PanBtnQrCode.Visible = false;
            CmbParticipant.Enabled = true;
            picCléwifi.Dispose();
        }

        /// <summary>
        /// Procédure privée qui permet de créer une image contenant la clé wifi du participant afin de pouvoir lui imprimé avec son QrCode
        /// </summary>
        private  void CreeImageWifi()
        {
            //création d'un objet Graphique(BitMap)
            Image img = new Bitmap(270,20);
            Graphics drawing = Graphics.FromImage(img);

            //Créer un pinceau pour le texte 
            Brush textBrush = new SolidBrush(Color.Black);

            //Définit un format spécifique pour le texte, notamment la police, la taille et les attributs de style.
            Font textFont = new Font(FontFamily.GenericSerif,12,FontStyle.Regular);

            //On dessine le texte cléWifi sur l'image
            drawing.DrawString(UneCleWifi,textFont,textBrush,0,0);

            // On place l'image créée dans un picturebox spécifié dans le WinForm
            picCléwifi.Image = img;

        }
    }
}