using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Master
{
    public partial class ProblemList : Form
    {
        int category_val;
        public ProblemList(int val)
        {
            InitializeComponent();
            category_val = val;
        }

        SqlConnection con;

        private void ProblrmList_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
          
            
            switch (category_val)
            {
                case 1:
                    {
                        con = new System.Data.SqlClient.SqlConnection();
                        con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from beginner", con);
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);

                        try
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["Problem No"].ToString());
                                item.SubItems.Add(dr["Ptoblem Name"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(e);
                        }

                        con.Close();

                        break;
                    }
                case 2:
                    {
                        con = new System.Data.SqlClient.SqlConnection();
                        con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from datastructure", con);
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);

                        try
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["Problem No"].ToString());
                                item.SubItems.Add(dr["Problem Name"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(e);
                        }

                        con.Close();
                        break;
                    }
                case 3:
                    {
                        con = new System.Data.SqlClient.SqlConnection();
                        con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from math", con);
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);

                        try
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["Problem No"].ToString());
                                item.SubItems.Add(dr["Problem Name"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(e);
                        }

                        con.Close();
                        break;
                    }
                case 4:
                    {
                        con = new System.Data.SqlClient.SqlConnection();
                        con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from adhoc", con);
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);

                        try
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["Problem No"].ToString());
                                item.SubItems.Add(dr["Problem Name"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(e);
                        }

                        con.Close();
                        break;
                    }

            }

        }

        
    }
}
