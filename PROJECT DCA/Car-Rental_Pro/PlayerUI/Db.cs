using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace PlayerUI
{
    class Db
    {


        static SqlConnection cn = new SqlConnection();
        static DataSet ds = new DataSet();


        static public void ouvrirConnection()
        {


            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["Location_de_voitures"].ToString();
                cn.Open();
            }
        }


        static public void fermerConnection()
        {
            cn.Close();
        }

        static private void creerRelation(string tpk, string t, string pk, string fk)
        {
            string nomRel = "rel_" + tpk + "_" + t;
            DataColumn c1 = ds.Tables[tpk].Columns[pk];
            DataColumn c2 = ds.Tables[t].Columns[fk];

            DataRelation r = new DataRelation(nomRel, c1, c2);

            if (!ds.Relations.Contains(nomRel))
                ds.Relations.Add(r);

        }
        static private void remplirTable(string t)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;

        }

        static private void dfgdfg(string t, string id, string column)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t + "where" + column + "=" + "'" + id.ToString() + "'", cn);
            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;
        }




        static private void remplirTable(string sql, string t)
        {
            ouvrirConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            if (!ds.Tables.Contains(t))
                da.Fill(ds, t);
            da = null;

        }

        static public BindingSource remplirListe(ListControl l, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;


            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            return bs;

        }
        static public BindingSource remplirListe(ListControl l, string sql, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            bs.DataSource = ds;
            bs.DataMember = t;


            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;
            return bs;

        }
        static public BindingSource remplirGrille(DataGridView v, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;

            v.DataSource = bs;

            return bs;
        }
        static public BindingSource remplirGrille(DataGridView v, string sql, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            bs.DataSource = ds;
            bs.DataMember = t;

            v.DataSource = bs;

            return bs;
        }
        static public BindingSource remplirText(string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;
            return bs;

        }
        static public BindingSource remplirText(string sql, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            bs.DataSource = ds;
            bs.DataMember = t;

            return bs;


        }

        static public BindingSource remplirListeRel(ListControl l, string t, string dm, string vm, string tpk, string pk, string fk, BindingSource bsPk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            creerRelation(tpk, t, pk, fk);

            bs.DataSource = bsPk;
            bs.DataMember = "rel_" + tpk + "_" + t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;



            return bs;

        }
        static public BindingSource remplirListeRel(ListControl l, string sql, string t, string dm, string vm, string tpk, string pk, string fk, BindingSource bsPk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            creerRelation(tpk, t, pk, fk);

            bs.DataSource = bsPk;
            bs.DataMember = "rel_" + tpk + "_" + t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;



            return bs;

        }




        static public void syncroniser(string t)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[t]);
            da = null;
            cb = null;
        }

    }
}
