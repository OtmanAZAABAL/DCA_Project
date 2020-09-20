using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Add_Details_Reservation : Form
    {
        string id_user; string action;
        string idClick;


        BindingSource bsDetails_Emplacment;
        BindingSource bsUser;

        BindingSource bsVoiture;
        BindingSource bsDetail_Remise;
        BindingSource bsAssurence_Voiture;
        BindingSource bsClient;


        BindingSource bsEmplacement;

        BindingSource bsEmployer;

        BindingSource bsC;
        BindingSource bsCH;
        

        BindingSource bs_Assurences;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Add_Details_Reservation(string action, string idClick, string id_user)
        {
            this.action = action;
            this.idClick = idClick;
            this.id_user = id_user;
            InitializeComponent();
        }

        public void bsDataBindings()
        {


            bsVoiture = Db.remplirListe(cb_v, "Voiture", "Nom_Model", "Numero_Enrg");
            bsUser = Db.remplirListe(cb_user, "utilisateur", "id_User", "id_User");

            bsEmplacement = Db.remplirListe(cb_Emplacement, "Details_Emplacment", "ville", "Emplacement_Id");

            bsDetail_Remise = Db.remplirListe(cb_Rmise, "Detail_Remise", "Code_Remise", "Code_Remise");
            bs_Assurences = Db.remplirListe(cb_Assurences, "Assurence_Voiture", "Cod_Assurences", "Cod_Assurences");
            bsClient = Db.remplirText("Select * from Client", "Client");
            bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");



            text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
            cb_v.DataBindings.Add("selectedvalue", bsC, "Numero_Enrg");
            textBox3.DataBindings.Add("text", bsVoiture, "Numero_Enrg");

            text_img.DataBindings.Add("text", bsVoiture, "Photo_Voiture");

            v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
            lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

            text_Mon_R.DataBindings.Add("text", bsC, "Montante");
            text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
            text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
            cb_user.DataBindings.Add("selectedvalue", bsC, "id_User");
            cb_Assurences.DataBindings.Add("selectedvalue", bsC, "Cod_Assurences");

            cb_Rmise.DataBindings.Add("selectedvalue", bsC, "Code_Remise");

            cb_Emplacement.DataBindings.Add("selectedvalue", bsC, "Emplacement_Id");


            text_C.DataBindings.Add("text", bsC, "Id_Client");
            text_note.DataBindings.Add("text", bsC, "Note");


     //       bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");

            //text_Re_idH.DataBindings.Add("text", bsCH, "Reservation_id");
            //cb_vH.DataBindings.Add("selectedvalue", bsCH, "Numero_Enrg");


            //vH.DataBindings.Add(new Binding("text", bsCH, "Date_Location"));
            //lb_dt_RetH.DataBindings.Add(new Binding("text", bsCH, "Date_Retour"));

            //text_Mon_RH.DataBindings.Add("text", bsCH, "Montante");
            //text_Klm_SorH.DataBindings.Add("text", bsCH, "Kilometre_Sortie");
            //text_Klm_RetH.DataBindings.Add("text", bsCH, "kilometre_Retour");
            //cb_userH.DataBindings.Add("selectedvalue", bsCH, "id_User");
            //cb_AssurencesH.DataBindings.Add("selectedvalue", bsCH, "Cod_Assurences");
            //cb_AssurencesH.DataBindings.Add("selectedvalue", bsCH, "Code_Remise");
            //text_CH.DataBindings.Add("text", bsCH, "Id_Client");
            //text_noteH.DataBindings.Add("text", bsCH, "Note");
            //dt_Action.DataBindings.Add("text", bsCH, "DateAction");
            //lb_id_user.DataBindings.Add("text", bsCH, "user");





            lst_C.DataSource = bsClient;
            lst_C.ValueMember = "Id_Client";
            lst_C.DisplayMember = "Id_Client";







        }
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
        private void Add_Details_Reservation_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                ActionF.Text = "AJOUTER";

                text_Re_id.Focus();
                textBox2.Enabled = false;

                bsDataBindings();

                bsC.AddNew();

                cb_Assurences.Text = "0";
                cb_Rmise.Text = "0";

                bsDataBindingsHistory();
                bsCH.AddNew();
                lblAction.Text = "Added";
                // lb_id_user.Text = id_user.ToString() + " ";
                DateTime dt = DateTime.Now;
                cb_user.SelectedValue = id_user;
                dt_Action.Text = dt.ToString();



                cb_user.Text = id_user.ToString();




                text_Re_id.Focus();





                cb_user.Enabled = false;
               

              






            }
            else if (action == "modifi")
            {
                ActionF.Text = "MODIFIER";

                textBox1.Enabled = false;
                textBox2.Enabled = false;


                bsVoiture = Db.remplirListe(cb_v, "Voiture", "Numero_Enrg", "Numero_Enrg");
                bsUser = Db.remplirListe(cb_user, "utilisateur", "id_User", "id_User");
                bsEmplacement = Db.remplirListe(cb_Emplacement, "Details_Emplacment", "ville", "Emplacement_Id");

                bsDetail_Remise = Db.remplirListe(cb_Rmise, "Detail_Remise", "Code_Remise", "Code_Remise");
                bs_Assurences = Db.remplirListe(cb_Assurences, "Assurence_Voiture", "Cod_Assurences", "Cod_Assurences");

                bsClient = Db.remplirText("Select * from Client", "Client");
                bsC = Db.remplirText("Select * from Details_Reservation", "Details_Reservation");


                listBox1.DataSource = bsC;
                listBox1.ValueMember = "Reservation_id";
                listBox1.DisplayMember = "Reservation_id";



                listBox1.SelectedValue = idClick.ToString();





                text_Re_id.DataBindings.Add("text", bsC, "Reservation_id");
                cb_v.DataBindings.Add("selectedvalue", bsC, "Numero_Enrg");

                text_img.DataBindings.Add("text", bsVoiture, "Photo_Voiture");

                v.DataBindings.Add(new Binding("text", bsC, "Date_Location"));
                lb_dt_Ret.DataBindings.Add(new Binding("text", bsC, "Date_Retour"));

                text_Mon_R.DataBindings.Add("text", bsC, "Montante");
                text_Klm_Sor.DataBindings.Add("text", bsC, "Kilometre_Sortie");
                text_Klm_Ret.DataBindings.Add("text", bsC, "kilometre_Retour");
                cb_user.DataBindings.Add("selectedvalue", bsC, "id_User");
                cb_Assurences.DataBindings.Add("selectedvalue", bsC, "Cod_Assurences");
                cb_Emplacement.DataBindings.Add("selectedvalue", bsC, "Emplacement_Id");

                cb_Rmise.DataBindings.Add("selectedvalue", bsC, "Code_Remise");
                text_C.DataBindings.Add("text", bsC, "Id_Client");
                text_note.DataBindings.Add("text", bsC, "Note");




                text_Re_id.Enabled = false;
                text_Mon_R.Focus();



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


                bsCH.AddNew();


                text_Re_idH.Text = idClick.ToString();

                //lb_id_user.Text = id_user.ToString() + " ";
                DateTime dt = DateTime.Now;
                dt_Action.Text = dt.ToString();
                lblAction.Text = "Updated";



            }
        }

        private void btn_AnnulerE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {


                this.Close();




            }
            else if (action == "modifi")
            {



                this.Close();
                Db.syncroniser("Details_Reservation");



            }
        }

        private void btn_ValiderE_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                SqlConnection cn = new SqlConnection(@"data source=DESKTOP-J2RFDBR\SQLEXPRESS;initial catalog=Car_Rental_Pro_V1; Integrated Security = True; User Id=sa;Password=442662;");

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VDetails_Reservation";
                cmd.Parameters.Add("@M", SqlDbType.Int).Value = textBox3.Text;
                cmd.Parameters.Add("@dateL", SqlDbType.DateTime).Value = dt_Loc.Value;
                cmd.Parameters.Add("@dateR", SqlDbType.DateTime).Value = dt_R.Value;
                cmd.Parameters.Add("@dis", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                bool bitValue = Convert.ToBoolean(cmd.Parameters["@dis"].Value);

                if (bitValue == false)
                {


                    Msg_Erreur f = new Msg_Erreur("Cette voiture n'est pas disponible");
                    f.ShowDialog();

                }
                else
                {

                    if (text_Re_id.Text == "")
                    {
                        string t1 = "Reservation id    non renseigné";
                        Msg_Verifier v = new Msg_Verifier(t1);
                        v.ShowDialog();

                        text_Re_id.Focus();
                        return;
                    }




                    if (text_Mon_R.Text == "")
                    {
                        string t2 = "Montante non renseigné";
                        Msg_Verifier v = new Msg_Verifier(t2);
                        v.ShowDialog();

                        text_Mon_R.Focus();
                        return;
                    }










                    if (text_C.Text == "")
                    {
                        string t4 = "Id Client   non renseigné";
                        Msg_Verifier v = new Msg_Verifier(t4);
                        v.ShowDialog();

                        text_C.Focus();
                        return;
                    }

                    //if (cb_Emp.Text == "")
                    //{
                    //    string t6 = "Emplacement Id   non renseigné";
                    //    Msg_Verifier v = new Msg_Verifier(t6);
                    //    v.ShowDialog();

                    //    cb_Emp.Focus();
                    //    return;
                    //}

                    if (cb_v.Text == "")
                    {
                        string t9 = " Voiture   non renseigné";

                        Msg_Verifier v = new Msg_Verifier(t9);
                        v.ShowDialog();

                        cb_v.Focus();
                        return;
                    }
                    if (cb_user.Text == "")
                    {
                        string t10 = " User non renseigné";

                        Msg_Verifier v = new Msg_Verifier(t10);
                        v.ShowDialog();

                        cb_user.Focus();
                        return;
                    }

                    ///date
                    ///

                    if (dt_Loc.Text == "")
                    {
                        string t9 = " date Location   non renseigné";

                        Msg_Verifier v = new Msg_Verifier(t9);
                        v.ShowDialog();

                        dt_Loc.Focus();
                        return;
                    }
                    if (dt_R.Text == "")
                    {
                        string t10 = " Date_Retour non renseigné";

                        Msg_Verifier v = new Msg_Verifier(t10);
                        v.ShowDialog();

                        dt_R.Focus();
                        return;
                    }


                          if (cb_Rmise.Text == "")
                    {
                        string t10 = " cb Rmise non renseigné";

                        Msg_Verifier v = new Msg_Verifier(t10);
                        v.ShowDialog();

                        cb_Rmise.Focus();
                        return;
                    }

                    try
                    {

                        bsC.EndEdit();
                        bsCH.EndEdit();

                        Db.syncroniser("Details_Reservation");
                        Db.syncroniser("HistoryReservation");

                        btn_ValiderE.Enabled = false;
                        groupBox1.Enabled = false;


                        string actions = "Processus Ajouté";
                        string smss = "Il a ajouté avec succès";

                        Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                        f.Show();

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Numero Enrg est duplicate");
                            m.ShowDialog();
                            text_Re_id.Clear();
                            text_Re_id.Focus();
                        }
                        else if (ex.Message.Contains("'Numero_Enrg'"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Choisissez id Voiture");
                            m.ShowDialog();

                            cb_v.Focus();


                        }



                        //else if (ex.Message.Contains("'Emplacement_Id'"))
                        //{
                        //    Msg_Erreur m = new Msg_Erreur("Choisissez  Emplacement_Id");
                        //    m.ShowDialog();

                        //    cb_Emp.Focus();



                        //}

                        else if (ex.Message.Contains("'Id_Client'"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Choisissez  Id Client");
                            m.ShowDialog();

                            text_C.Focus();



                        }

                        else if (ex.Message.Contains("'Date_Retour'"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Date_Retour non renseigné");
                            m.ShowDialog();

                            dt_R.Focus();



                        }
                        else if (ex.Message.Contains("'Date_Location'"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Date Loction non renseigné");
                            m.ShowDialog();

                            dt_Loc.Focus();



                        }

                        else if (ex.Message.Contains("ck_Date_Location"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Date Location Plus petit de la date d'aujourd'hui");
                            m.ShowDialog();
                            //dateDeDhR.Focus();
                        }
                        else if (ex.Message.Contains("ck_Date_Location_Date_Retour"))
                        {
                            Msg_Erreur m = new Msg_Erreur("Date Location Plus petit de la date Retour");
                            m.ShowDialog();
                            //dateDeDhR.Focus();
                        }
                        else
                            MessageBox.Show(ex.Message);
                    }

                }



            }

            else if (action == "modifi")
            {


                try
                {




                    lblAction.Text = "Updated";



                    DateTime dt = DateTime.Now;
                    //  lb_id_user.Text = id_user.ToString() + " ";


                    text_Re_idH.Text = text_Re_id.Text;
                    cb_vH.Text = cb_v.Text;
                    vH.Text = v.Text;
                    lb_dt_RetH.Text = lb_dt_Ret.Text;
                    text_Mon_RH.Text = text_Mon_R.Text;
                    text_CH.Text = text_C.Text;
                    text_Klm_SorH.Text = text_Klm_Sor.Text;
                    text_Klm_RetH.Text = text_Klm_Ret.Text;
                    cb_userH.Text = cb_user.Text;
                    cb_AssurencesH.Text = cb_Assurences.Text;
                    cb_RmiseH.Text = cb_Rmise.Text;
                    text_noteH.Text = text_note.Text;

                    dt_Action.Text = dt.ToString();









                    bsC.EndEdit();
                    bsC.CancelEdit();

                    bsCH.EndEdit();
                    bsCH.CancelEdit();

                    Db.syncroniser("Details_Reservation");


                    Db.syncroniser("HistoryReservation");


                   
                    groupBox1.Enabled = false;
                    btn_ValiderE.Enabled = false;


                    string actions = "Processus modifier";
                    string smss = "Il a modifier avec succès";

                    Msg_Ajouter f = new Msg_Ajouter(actions, smss);
                    f.Show();

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("'Numero_Enrg'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez id Voiture");
                        m.ShowDialog();

                        cb_v.Focus();


                    }

                    //else if (ex.Message.Contains("'Emplacement_Id'"))
                    //{
                    //    Msg_Erreur m = new Msg_Erreur("Choisissez  Emplacement_Id");
                    //    m.ShowDialog();

                    //    cb_Emp.Focus();



                    //}

                    else if (ex.Message.Contains("'Id_Client'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Choisissez  Id Client");
                        m.ShowDialog();

                        text_C.Focus();



                    }

                    else if (ex.Message.Contains("'Date_Retour'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date_Retour non renseigné");
                        m.ShowDialog();

                        dt_R.Focus();



                    }
                    else if (ex.Message.Contains("'Date_Location'"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Loction non renseigné");
                        m.ShowDialog();

                        dt_Loc.Focus();



                    }

                    else if (ex.Message.Contains("ck_Date_Location"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Location Plus petit de la date d'aujourd'hui");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else if (ex.Message.Contains("ck_Date_Location_Date_Retour"))
                    {
                        Msg_Erreur m = new Msg_Erreur("Date Location Plus petit de la date Retour");
                        m.ShowDialog();
                        //dateDeDhR.Focus();
                    }
                    else
                        MessageBox.Show(ex.Message);

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_Loc_ValueChanged(object sender, EventArgs e)
        {
            v.Text = dt_Loc.Value.ToString();

            DateTime FirstDate = dt_Loc.Value;
            DateTime SecondDate = dt_R.Value;

            TimeSpan tspan = SecondDate - FirstDate;

            if (tspan.Days < 0)
            {
                Msg_Erreur2 f = new Msg_Erreur2("La somme des jours doit être supérieure à zéro");
                f.ShowDialog();
                text_D.Value = 0;
            }
            else
                text_D.Value = tspan.Days;

        }

        private void dt_R_ValueChanged(object sender, EventArgs e)
        {
            lb_dt_Ret.Text = dt_R.Value.ToString();


            DateTime FirstDate = dt_Loc.Value;
            DateTime SecondDate = dt_R.Value;

            TimeSpan tspan = SecondDate - FirstDate;

            if (tspan.Days < 0)
            {
                Msg_Erreur2 f = new Msg_Erreur2("La somme des jours doit être supérieure à zéro");
                f.ShowDialog();
                text_D.Value = 0;
            }
            else
                text_D.Value = tspan.Days;
        }

        private void text_Sh_Client_MouseEnter(object sender, EventArgs e)
        {
            if (text_Sh_Client.Text == "Id Client")
            {
                text_Sh_Client.Text = "";
                text_Sh_Client.ForeColor = Color.Black;
            }
        }

        private void text_Sh_Client_MouseLeave(object sender, EventArgs e)
        {
            if (text_Sh_Client.Text == "")
            {
                text_Sh_Client.Text = "Id Client";
                text_Sh_Client.ForeColor = Color.DimGray;
            }
        }

        private void btn_Sh_C_Click(object sender, EventArgs e)
        {

            string c = " Id_Client like  '%" + text_Sh_Client.Text.Replace("'", "''") + "%' ";
            bsClient.Filter = c;
            if (lst_C.SelectedItems.Count > 0)
            {
                text_C.Text = lst_C.SelectedValue.ToString();


            }
            else
            {
                Msg_Erreur2 m = new Msg_Erreur2("il n'y a pas");
                m.ShowDialog();
            }
        }

        private void text_Sh_Client_TextChanged(object sender, EventArgs e)
        {
          //  text_C.Text = lst_C.SelectedValue.ToString();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (text_M.Text != "")

            {
                double total;
                double days = Convert.ToDouble(text_D.Value.ToString());
                double montant = Convert.ToDouble(text_M.Text);

                total = days * montant;
                text_Mon_R.Text = total.ToString();


            }
            else {

                Msg_Erreur2 m = new Msg_Erreur2(" Montante  non renseigné");
                m.ShowDialog();

            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_Mon_R.Clear();
            text_M.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string nomFichier = openFileDialog1.FileName;
            string ext = Path.GetExtension(nomFichier);

            Random n = new Random();
            long i = n.Next();

            string d = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "");
            File.Copy(nomFichier, "imagesV/" + d + i + ext);
            text_img.Text = d + i + ext;
        }

        private void text_img_TextChanged(object sender, EventArgs e)
        {

            string photo = text_img.Text == "" ? "vide.png" : text_img.Text;

            pictureBox1.Load("imagesV/" + photo);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void text_Re_id_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_M.Text.IndexOf(',') > 0)
                e.Handled = true;
        }

        private void text_Mon_R_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && text_Mon_R.Text.IndexOf(',') > 0)
                e.Handled = true;
        }

        private void text_Klm_Sor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;
        }

        private void text_Klm_Ret_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) != true && e.KeyChar != 8)
                e.Handled = true;
        }

        private void text_Re_id_TextChanged(object sender, EventArgs e)
        {
            text_Re_idH.Text = text_Re_id.Text;
        }

        private void cb_v_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_vH.Text = cb_v.Text;


        }
///
        private void v_TextChanged(object sender, EventArgs e)
        {
            vH.Text = v.Text;

        }

        private void lb_dt_Ret_TextChanged(object sender, EventArgs e)
        {
            lb_dt_RetH.Text = lb_dt_Ret.Text;

        }

        private void text_Mon_R_TextChanged(object sender, EventArgs e)
        {
            text_Mon_RH.Text = text_Mon_R.Text;

        }

        private void text_C_TextChanged(object sender, EventArgs e)
        {
            text_CH.Text = text_C.Text;

        }

        private void text_Klm_Sor_TextChanged(object sender, EventArgs e)
        {
            text_Klm_SorH.Text = text_Klm_Sor.Text;

        }

        private void text_Klm_Ret_TextChanged(object sender, EventArgs e)
        {
            text_Klm_RetH.Text = text_Klm_Ret.Text;

        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_userH.Text = cb_user.Text;

        }

        private void cb_Assurences_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_AssurencesH.Text = cb_Assurences.Text;

        }

        private void cb_Rmise_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_RmiseH.Text = cb_Rmise.Text;


        }

        private void text_note_TextChanged(object sender, EventArgs e)
        {
            text_noteH.Text = text_note.Text;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
