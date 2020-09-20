using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlayerUI
{
    public partial class Msg_Suppression : Form
    {


        BindingSource bsC;
        BindingSource bsC2;
        BindingSource bsCH;
        string msg;
        string action;
        string idClick;
        BindingSource bsH;
        string id_user;

        BindingSource bsDetails_Emplacment;
        BindingSource bsUser;

        BindingSource bsVoiture;
        BindingSource bsDetail_Remise;
        BindingSource bsAssurence_Voiture;
        BindingSource bsClient;

        BindingSource bsEmployer;



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void bsDataBindingsHistory()
        {
            //bsVoiture = Db.remplirListe(cb_v, "Voiture", "Numero_Enrg", "Numero_Enrg");
            //bsUser = Db.remplirListe(cb_user, "utilisateur", "id_User", "id_User");

            //bsDetail_Remise = Db.remplirListe(cb_Rmise, "Detail_Remise", "Code_Remise", "Code_Remise");
            //bs_Assurences = Db.remplirListe(cb_Assurences, "Assurence_Voiture", "Cod_Assurences", "Cod_Assurences");
            //bsClient = Db.remplirText("Select * from Client", "Client");

            bsCH = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");




            text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_idH");

            cb_vH.DataBindings.Add("text", bsCH, "Numero_EnrgH");


            vH.DataBindings.Add(new Binding("text", bsCH, "Date_LocationH"));
            lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_RetourH"));

            text_Mon_RH.DataBindings.Add("text", bsCH, "MontanteH");
            text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_SortieH");
            text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_RetourH");
            cb_userH.DataBindings.Add("text", bsCH, "id_UserH");
            cb_AssurencesH.DataBindings.Add("text", bsCH, "Cod_AssurencesH");
            cb_RmiseH.DataBindings.Add("text", bsCH, "Code_RemiseH");
            text_CH.DataBindings.Add("text", bsCH, "Id_ClientH");
            text_noteH.DataBindings.Add("text", bsCH, "NoteH");


            dt_Action.DataBindings.Add("text", bsCH, "DateActionH");
            lblAction.DataBindings.Add("text", bsCH, "ActionH");



        }


        public Msg_Suppression(string msg,string action,string idClick, string id_user)
        {
            InitializeComponent();
            this.msg = msg;
            this.idClick = idClick;
            this.id_user = id_user;
            this.action = action;
        }

        private void Mesg_Load(object sender, EventArgs e)
        {



            if (action == "Client")
            {



                bsC = Db.remplirText("Select * from Client", "Client");
                bsC2 = Db.remplirText("Select * from Client", "Client");

                bsH = Db.remplirText("Select * from HistoryClient", "HistoryClient");


             


                bsC = Db.remplirText("Select * from Client", "Client");



                bsH.AddNew();



                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Id_Client";
                listBox1.DisplayMember = "Id_Client";



                listBox1.SelectedValue = idClick.ToString();



                text_idC.DataBindings.Add("text", bsC, "Id_Client");
                text_nomC.DataBindings.Add("text", bsC, "Nom_Client");
                text_prnomC.DataBindings.Add("text", bsC, "Prenom_Client");
                text_teleC.DataBindings.Add("text", bsC, "Tel_Client");
                text_emailC.DataBindings.Add("text", bsC, "Email_Client");
                text_villeC.DataBindings.Add("text", bsC, "Ville_Client");
                Zibe_C.DataBindings.Add("text", bsC, "ZipCod_Client");
                text_AdreC.DataBindings.Add("text", bsC, "Adresse_Client");






                text_idCH.DataBindings.Add("text", bsH, "Id_Client");
                text_nomCH.DataBindings.Add("text", bsH, "Nom_Client");
                text_prnomCH.DataBindings.Add("text", bsH, "Prenom_Client");
                text_teleCH.DataBindings.Add("text", bsH, "Tel_Client");
                text_emailCH.DataBindings.Add("text", bsH, "Email_Client");
                text_villeCH.DataBindings.Add("text", bsH, "Ville_Client");
                Zibe_CH.DataBindings.Add("text", bsH, "ZipCod_Client");
                text_AdreCH.DataBindings.Add("text", bsH, "Adresse_Client");
                lblAction.DataBindings.Add("text", bsH, "Action");
                dt_Action.DataBindings.Add("text", bsH, "DateAction");
                lb_id_user.DataBindings.Add("text", bsH, "user");

                text_Re_idH.Text = idClick.ToString();
                lb_id_user.Text = id_user.ToString();

                sms.Text = msg.ToString();

                sms.TextAlign = ContentAlignment.MiddleCenter;

            }

            else if (action == "Assurence_Voiture")
            {



                bsC = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");
                bsC2 = Db.remplirText("Select * from Assurence_Voiture", "Assurence_Voiture");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Cod_Assurences";
                listBox1.DisplayMember = "Cod_Assurences";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();


            }
            else if (action == "Employer")

            {



                bsC = Db.remplirText("Select * from Employer", "Employer");
                bsC2 = Db.remplirText("Select * from Employer", "Employer");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Id_Employer";
                listBox1.DisplayMember = "Id_Employer";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();






            }

            else if (action == "Detail_Remise")
            {
                bsC = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");
                bsC2 = Db.remplirText("Select * from Detail_Remise", "Detail_Remise");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Code_Remise";
                listBox1.DisplayMember = "Code_Remise";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();





            }







            else if (action == "Voiture")
            {

                bsC = Db.remplirText("Select * from Voiture", "Voiture");
                bsC2 = Db.remplirText("Select * from Voiture", "Voiture");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Numero_Enrg";
                listBox1.DisplayMember = "Numero_Enrg";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();

            }



            else if (action == "Details_Emplacment")
            {
                
                bsC = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");
                bsC2 = Db.remplirText("Select * from Details_Emplacment", "Details_Emplacment");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Emplacement_Id";
                listBox1.DisplayMember = "Emplacement_Id";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();


            }





            else if (action == "Categorie_Voiture")
            {

                bsC = Db.remplirText("Select * from Categorie_Voiture", "Categorie_Voiture");
                bsC2 = Db.remplirText("Select * from Categorie_Voiture", "Categorie_Voiture");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Nom_Categorie";
                listBox1.DisplayMember = "Nom_Categorie";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();




            }







            else if (action == "Details_Facture")
            {

                bsC = Db.remplirText("Select * from Details_Facture", "Details_Facture");
                bsC2 = Db.remplirText("Select * from Details_Facture", "Details_Facture");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Id_Factur";
                listBox1.DisplayMember = "Id_Factur";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();




            }


            else if (action == "Details_Reservation")
            {


                //bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");
                //bsC2 = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");

                //bsCH = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");


                //bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");




                //listBox1.DataSource = bsC;
                //listBox1.ValueMember = "Reservation_id";
                //listBox1.DisplayMember = "Reservation_id";


                //listBox1.SelectedValue = idClick.ToString();

                //text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                //cb_v.DataBindings.Add("selectedvalue", bsC, "Numero_Enrg");



                //v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                //lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                //text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                //text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                //text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                //cb_user.DataBindings.Add("text", bsC, "id_User");
                //cb_Assurences.DataBindings.Add("text", bsC, "Cod_Assurences");
                //cb_Rmise.DataBindings.Add("text", bsC, "Code_Remise");
                //text_C.DataBindings.Add("text", bsC, "Id_Client");
                //text_note.DataBindings.Add("text", bsC, "Note");









                //text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_idH");
                //cb_vH.DataBindings.Add("text", bsCH, "Numero_EnrgH");


                //vH.DataBindings.Add(new Binding("text", bsCH, "Date_LocationH"));
                //lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_RetourH"));

                //text_Mon_RH.DataBindings.Add("text", bsCH, "MontanteH");
                //text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_SortieH");
                //text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_RetourH");
                //cb_userH.DataBindings.Add("text", bsCH, "id_UserH");
                //cb_AssurencesH.DataBindings.Add("text", bsCH, "Cod_AssurencesH");
                //cb_RmiseH.DataBindings.Add("text", bsCH, "Code_RemiseH");
                //text_CH.DataBindings.Add("text", bsCH, "Id_ClientH");
                //text_noteH.DataBindings.Add("text", bsCH, "NoteH");


                //dt_Action.DataBindings.Add("text", bsCH, "DateActionH");
                //lblAction.DataBindings.Add("text", bsCH, "ActionH");

                //bsVoiture = Db.remplirListe(cb_v, "Voiture", "Numero_Enrg", "Numero_Enrg");
                //bsUser = Db.remplirListe(cb_user, "utilisateur", "id_User", "id_User");

                //bsDetail_Remise = Db.remplirListe(cb_Rmise, "Detail_Remise", "Code_Remise", "Code_Remise");

                //bsClient = Db.remplirText("Select * from Client", "Client");
                //bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");


                //listBox1.DataSource = bsC;
                //listBox1.ValueMember = "Reservation_id";
                //listBox1.DisplayMember = "Reservation_id";



                //listBox1.SelectedValue = idClick.ToString();





                //text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                //cb_v.DataBindings.Add("selectedvalue", bsC, "Numero_Enrg");


                //v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                //lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                //text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                //text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                //text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                //cb_user.DataBindings.Add("selectedvalue", bsC, "id_User");
                //cb_Assurences.DataBindings.Add("selectedvalue", bsC, "Cod_Assurences");
                //cb_Rmise.DataBindings.Add("selectedvalue", bsC, "Code_Remise");
                //text_C.DataBindings.Add("text", bsC, "Id_Client");
                //text_note.DataBindings.Add("text", bsC, "Note");




                //text_Re_id.Enabled = false;
                //text_Mon_R.Focus();



                //bsCH = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");




                //text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_idH");
                //cb_vH.DataBindings.Add("text", bsCH, "Numero_EnrgH");


                //vH.DataBindings.Add(new Binding("text", bsCH, "Date_LocationH"));
                //lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_RetourH"));

                //text_Mon_RH.DataBindings.Add("text", bsCH, "MontanteH");
                //text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_SortieH");
                //text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_RetourH");
                //cb_userH.DataBindings.Add("text", bsCH, "id_UserH");
                //cb_AssurencesH.DataBindings.Add("text", bsCH, "Cod_AssurencesH");
                //cb_RmiseH.DataBindings.Add("text", bsCH, "Code_RemiseH");
                //text_CH.DataBindings.Add("text", bsCH, "Id_ClientH");
                //text_noteH.DataBindings.Add("text", bsCH, "NoteH");


                //dt_Action.DataBindings.Add("text", bsCH, "DateActionH");
                //lblAction.DataBindings.Add("text", bsCH, "ActionH");
                //bsCH.AddNew();

                //text_Re_idH.Text = idClick.ToString();


                ////tset 2
                //bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");




                //bsCH = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");





                //bsCH.AddNew();


                //listBox1.DataSource = bsC;
                //listBox1.ValueMember = "Reservation_id";
                //listBox1.DisplayMember = "Reservation_id";



                //listBox1.SelectedValue = idClick.ToString();





                //text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                //cb_v.DataBindings.Add("selectedvalue", bsC, "Numero_Enrg");


                //v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                //lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                //text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                //text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                //text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                //cb_user.DataBindings.Add("selectedvalue", bsC, "id_User");
                //cb_Assurences.DataBindings.Add("selectedvalue", bsC, "Cod_Assurences");
                //cb_Rmise.DataBindings.Add("selectedvalue", bsC, "Code_Remise");
                //text_C.DataBindings.Add("text", bsC, "Id_Client");
                //text_note.DataBindings.Add("text", bsC, "Note");







                //text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_idH");
                //cb_vH.DataBindings.Add("text", bsCH, "Numero_EnrgH");


                //vH.DataBindings.Add(new Binding("text", bsCH, "Date_LocationH"));
                //lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_RetourH"));

                //text_Mon_RH.DataBindings.Add("text", bsCH, "MontanteH");
                //text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_SortieH");
                //text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_RetourH");
                //cb_userH.DataBindings.Add("text", bsCH, "id_UserH");
                //cb_AssurencesH.DataBindings.Add("text", bsCH, "Cod_AssurencesH");
                //cb_RmiseH.DataBindings.Add("text", bsCH, "Code_RemiseH");
                //text_CH.DataBindings.Add("text", bsCH, "Id_ClientH");
                //text_noteH.DataBindings.Add("text", bsCH, "NoteH");


                //dt_Action.DataBindings.Add("text", bsCH, "DateActionH");
                //lblAction.DataBindings.Add("text", bsCH, "ActionH");

                //lblAction.Text = "Deleted";


                //text_Re_idH.Text = text_Re_id.Text;
                //cb_vH.Text = cb_v.Text;
                //vH.Text = v.Text;
                //lb_dt_RetH.Text = lb_dt_Ret.Text;
                //text_Mon_RH.Text = text_Mon_R.Text;
                //text_CH.Text = text_C.Text;
                //text_Klm_SorH.Text = text_Klm_Sor.Text;
                //text_Klm_RetH.Text = text_Klm_Ret.Text;
                //cb_userH.Text = cb_user.Text;
                //cb_AssurencesH.Text = cb_Assurences.Text;
                //cb_RmiseH.Text = cb_Rmise.Text;
                //text_noteH.Text = text_note.Text;



                ////   lb_id_user.Text = id_user.ToString() + " ";


                //DateTime dt = DateTime.Now;
                //dt_Action.Text = dt.ToString();
                bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");
                bsC2 = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");


                bsCH = Db.remplirText("Select * from HistoryReservation", "HistoryReservation");

                bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");

                bsCH.AddNew();

                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Reservation_id";
                listBox1.DisplayMember = "Reservation_id";



                listBox1.SelectedValue = idClick.ToString();






                //text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                //cb_v.DataBindings.Add("text", bsC, "Numero_Enrg");


                //v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                //lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                //text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                //text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                //text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                //cb_user.DataBindings.Add("text", bsC, "id_User");
                //cb_Assurences.DataBindings.Add("text", bsC, "Cod_Assurences");
                //cb_Rmise.DataBindings.Add("text", bsC, "Code_Remise");
                //text_C.DataBindings.Add("text", bsC, "Id_Client");
                //text_note.DataBindings.Add("text", bsC, "Note");


                text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                cb_v.DataBindings.Add("text", bsC, "Numero_Enrg");


                v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                cb_user.DataBindings.Add("text", bsC, "id_User");
                cb_Assurences.DataBindings.Add("text", bsC, "Cod_Assurences");
                cb_Rmise.DataBindings.Add("text", bsC, "Code_Remise");
                text_C.DataBindings.Add("text", bsC, "Id_Client");
                text_note.DataBindings.Add("text", bsC, "Note");



                text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_idH");

                vH.DataBindings.Add(new Binding("text", bsCH, "Date_LocationH"));
                lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_RetourH"));

                text_Mon_RH.DataBindings.Add("text", bsCH, "MontanteH");
                text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_SortieH");
                text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_RetourH");
                cb_userH.DataBindings.Add("text", bsCH, "id_UserH");
                cb_AssurencesH.DataBindings.Add("text", bsCH, "Cod_AssurencesH");
                cb_RmiseH.DataBindings.Add("text", bsCH, "Code_RemiseH");
                text_CH.DataBindings.Add("text", bsCH, "Id_ClientH");
                text_noteH.DataBindings.Add("text", bsCH, "NoteH");
                dt_Action.DataBindings.Add("text", bsCH, "DateActionH");
                lblAction.DataBindings.Add("text", bsCH, "ActionH");
                cb_vH.DataBindings.Add("text", bsCH, "Numero_EnrgH");


                cb_userH.Text = id_user.ToString() + " ";
                
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();




            }




            else if (action == "utilisateur")
            {

                bsC = Db.remplirText("Select * from utilisateur", "utilisateur");
                bsC2 = Db.remplirText("Select * from utilisateur", "utilisateur");







                listBox1.DataSource = bsC;
                listBox1.ValueMember = "id_User";
                listBox1.DisplayMember = "id_User";



                listBox1.SelectedValue = idClick.ToString();
                sms.TextAlign = ContentAlignment.MiddleCenter;

                sms.Text = msg.ToString();




            }








        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {

            if (action == "Client")
            {
                try
                {
                    text_idCH.Text = text_idC.Text;
                    text_nomCH.Text = text_nomC.Text;
                    text_prnomCH.Text = text_prnomC.Text;
                    text_teleCH.Text = text_teleC.Text;
                    text_emailCH.Text = text_emailC.Text;
                    text_villeCH.Text = text_villeC.Text;
                    Zibe_CH.Text = Zibe_C.Text;
                    text_AdreCH.Text = text_AdreC.Text;

                    lblAction.Text = "Deleted";


                    lb_id_user.Text = id_user.ToString() + " ";


                    DateTime dt = DateTime.Now;
                    dt_Action.Text = dt.ToString();


                    bsH.EndEdit();



                    Db.syncroniser("HistoryClient");






                    bsC.RemoveCurrent();
                    Db.syncroniser("Client");

                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Details_Reservation_Client"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Reservation  ");
                        m.ShowDialog();

                    }

                    else
                        MessageBox.Show(ex.Message);
                }



            }
            else if (action == "Assurence_Voiture")
            {

                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Assurence_Voiture");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {


                }

            }

            else if (action == "Employer")
            {

                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Employer");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {

                    //  if (ex.Message.Contains("ck_Date_da_dhesion"))
                    //{
                    //    Msg_Erreur m = new Msg_Erreur("Date da dhesion  Plus petit de la date d'aujourd'hui");
                    //    m.ShowDialog();
                     
                    //}
                    //else

                    //    MessageBox.Show(ex.Message);


                }



            }



            else if (action == "Detail_Remise")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Detail_Remise");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Details_Reservation_Detail_Remise"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Reservation  ");
                        m.ShowDialog();

                    }
                  
                    else
                        MessageBox.Show(ex.Message);
                }




            }





            else if (action == "Voiture")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Voiture");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Details_Reservation_Voiture"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Reservation  ");
                        m.ShowDialog();

                    }

                    else
                        MessageBox.Show(ex.Message);
                }






            }



            else if (action == "Details_Emplacment")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Details_Emplacment");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.ShowDialog();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Voiture_Details_Emplacment"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Voiture  ");
                        m.ShowDialog();

                    }
                    else if (ex.Message.Contains("Fk_Details_Reservation_Details_Emplacment"))
                    {

                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Voiture Reservation Details ");
                        m.ShowDialog();
                    }
                    else
                        MessageBox.Show(ex.Message);
                }




            }





            else if (action == "Categorie_Voiture")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Categorie_Voiture");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Voiture_Categorie_Voiture"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Voiture  ");
                        m.ShowDialog();

                    }
                 
                    else
                        MessageBox.Show(ex.Message);
                }




            }





            else if (action == "Details_Facture")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("Details_Facture");
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {


                }




            }


            else if (action == "Details_Reservation")
            {
                try
                {




                    text_Re_idH.Text = text_Re_id.Text;
                         cb_vH.Text = cb_v.Text;
                    vH.Text = v.Text;
                    lb_dt_RetH.Text = lb_dt_Ret.Text;
                    text_Mon_RH.Text = text_Mon_R.Text;
                    text_CH.Text = text_C.Text;
                    text_Klm_SorH.Text = text_Klm_Sor.Text;
                    text_Klm_RetH.Text = text_Klm_Ret.Text;
                 //    cb_userH.Text = id_user.ToString();
                            cb_AssurencesH.Text = cb_Assurences.Text;
                      cb_RmiseH.Text = cb_Rmise.Text;
                    text_noteH.Text = text_note.Text;
                    lblAction.Text = "Deleted";
                    DateTime dt = DateTime.Now;
                    dt_Action.Text = dt.ToString();

                    cb_userH.Text = id_user.ToString() + " ";


                    bsCH.EndEdit();



                    Db.syncroniser("HistoryReservation");





                    bsC.RemoveCurrent();
                    Db.syncroniser("Details_Reservation");

                    string actions = "Supprimer";
                    string smss = "Suppression réussie";
                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {


                }




            }


            else if (action == "utilisateur")
            {
                try
                {


                    bsC.RemoveCurrent();
                    Db.syncroniser("utilisateur");
                 
                    string actions = "Supprimer";
                    string smss = "Suppression réussie";

                    Msg_Ajouter lk = new Msg_Ajouter(actions, smss);
                    lk.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Fk_Details_Reservation_utilisateur"))
                    {
                        Msg_Erreur m = new Msg_Erreur("identifiant Utilisé dans Reservation  ");
                        m.ShowDialog();

                    }

                    else
                        MessageBox.Show(ex.Message);
                }







            }




        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActionF_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sms_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
                   ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void text_Klm_SorH_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Re_idH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_vH_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Klm_RetH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_userH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_AssurencesH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_RmiseH_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Klm_Ret_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Mon_R_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_C_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
