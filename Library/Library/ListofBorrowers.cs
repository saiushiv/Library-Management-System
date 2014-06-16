using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class ListofBorrowers : Form
    {
        int cdno = 9041;

        public ListofBorrowers()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void baseTableCacheBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mySqlGeometryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Cardno_txt.Text = row.Cells["card_no"].Value.ToString();
                fnm_txt.Text = row.Cells["fname"].Value.ToString();
                lnm_txt.Text = row.Cells["lname"].Value.ToString();
                Addr_txt.Text = row.Cells["address"].Value.ToString();
                phn_txt.Text = row.Cells["phone"].Value.ToString();
            }
        }

        public void ListofBorrowers_Load(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BORROWER;", condata);
          try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmddata;
                DataTable dbt = new DataTable();
                sda.Fill(dbt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbt;
                dataGridView1.DataSource = bs;
                sda.Update(dbt);
                textBox1.Text = dbt.Rows.Count.ToString(); 
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             condata.Close();
           
        }

        public void button3_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.fnm_txt.Text.Trim().Length == 0) || (this.lnm_txt.Text.Trim().Length == 0) || (this.Addr_txt.Text.Trim().Length == 0))
            {

                MessageBox.Show("Enter correct values in the * marked textboxes");
            }

            else
            {

                try
                {
                    condata1.Open();
                    string Qc = "SELECT fname,lname FROM LIBRARY.BORROWER where card_no = '"+this.Cardno_txt.Text+"' and fname = '" + this.fnm_txt.Text + "' and lname ='" + this.lnm_txt.Text + "' and address ='" + this.Addr_txt.Text + "'";
                    MySqlCommand conchk = new MySqlCommand(Qc, condata1);
                    MySqlDataReader Qcread;
                    Qcread = conchk.ExecuteReader();
                    int count = 0;
                    while (Qcread.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 1)
                    {
                        string constringu = "datasource=localhost;port=3306;username=root;password=sai123";
                        MySqlConnection condata = new MySqlConnection(constringu);
                        string Query = "UPDATE LIBRARY.BORROWER set card_no='" + this.Cardno_txt.Text + "',fname='" + this.fnm_txt.Text + "',lname='" + this.lnm_txt.Text + "',address='" + this.Addr_txt.Text + "',phone='" + this.phn_txt.Text + "' where card_no = '" + this.Cardno_txt.Text + "';";
                        MySqlCommand coninsert = new MySqlCommand(Query, condata);
                        MySqlDataReader myReader;

                        try
                        {
                            condata.Open();
                            myReader = coninsert.ExecuteReader();
                            condata.Close();
                            MessageBox.Show("Borrower Data Updated Successfully");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        condata1.Close();
                    }

                    else
                    {
                        MessageBox.Show("No Matching Record Found to Update");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 
            private void button1_Click(object sender, EventArgs e)
        {
            Cardno_txt.Text = "";
            fnm_txt.Text = "";
            lnm_txt.Text = "";
            Addr_txt.Text = "";
            phn_txt.Text = "";


            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BORROWER;", condata);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmddata;
                DataTable dbt = new DataTable();
                sda.Fill(dbt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbt;
                dataGridView1.DataSource = bs;
                sda.Update(dbt);
                textBox1.Text = dbt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.fnm_txt.Text.Trim().Length == 0) || (this.lnm_txt.Text.Trim().Length == 0) || (this.Addr_txt.Text.Trim().Length ==0))
            {
                
                MessageBox.Show("Enter correct values in the * marked textboxes");
            }

            else
            {
                
              try
                {
                condata1.Open();
                string Qc = "SELECT fname,lname FROM LIBRARY.BORROWER where fname = '"+this.fnm_txt.Text +"' and lname ='"+this.lnm_txt.Text+"' and address ='"+this.Addr_txt.Text+"'";
                MySqlCommand conchk = new MySqlCommand(Qc,condata1);
                MySqlDataReader Qcread;
                Qcread = conchk.ExecuteReader();
                int count = 0;
                while (Qcread.Read())
                {
                    count = count + 1;
                }
              
                     if (count==1)
                   {
                       MessageBox.Show("This Borrower is already enrolled in our system.Duplicate entry not allowed");
                       condata1.Close(); 
                     }
                   else
                   {
                       cdno = cdno + 1;

                       string constring1 = "datasource=localhost;port=3306;username=root;password=sai123";
                       MySqlConnection condata = new MySqlConnection(constring1);
                       string Query = "INSERT INTO LIBRARY.BORROWER values (@cdno,'" + this.fnm_txt.Text + "','" + this.lnm_txt.Text + "','" + this.Addr_txt.Text + "','" + this.phn_txt.Text + "');";
                       MySqlCommand coninsert = new MySqlCommand(Query, condata);
                       coninsert.Parameters.AddWithValue("@cdno", cdno); 

                       condata.Open();
                       MySqlDataReader myReader;

                       try
                       {
                         
                           myReader = coninsert.ExecuteReader();
                           MessageBox.Show("New Borrower Added Successfully");

                           while (myReader.Read())
                           {

                           }

                           condata.Close();
                       }
                         catch (Exception ex)
                         {
                           MessageBox.Show(ex.Message);
                         }
                       }
                      }
                          catch (Exception ex)
                          {
                                 MessageBox.Show(ex.Message);
                           }
              
                }
            }
      

        private void Delete_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.fnm_txt.Text.Trim().Length == 0) || (this.lnm_txt.Text.Trim().Length == 0) || (this.Addr_txt.Text.Trim().Length == 0))
            {

                MessageBox.Show("Enter correct values in the * marked textboxes");
            }

            else
            {

                try
                {
                    condata1.Open();
                    string Qc = "SELECT fname,lname FROM LIBRARY.BORROWER where card_no = '"+this.Cardno_txt.Text+"' and fname = '" + this.fnm_txt.Text + "' and lname ='" + this.lnm_txt.Text + "' and address ='" + this.Addr_txt.Text + "'";
                    MySqlCommand conchk = new MySqlCommand(Qc, condata1);
                    MySqlDataReader Qcread;
                    Qcread = conchk.ExecuteReader();
                    int count = 0;
                    while (Qcread.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 1)
                    {
            
                string constringd = "datasource=localhost;port=3306;username=root;password=sai123";
                MySqlConnection condata = new MySqlConnection(constringd);
                string Query = "DELETE FROM LIBRARY.BORROWER where card_no='" + this.Cardno_txt.Text + "';";
                MySqlCommand condelete = new MySqlCommand(Query, condata);
                MySqlDataReader myReader;

                try
                {
                    condata.Open();
                    myReader = condelete.ExecuteReader();
                    MessageBox.Show("Borrower Data Deleted Successfully");
                    condata.Close();
                    }
                    
                       catch (Exception ex)
                       {
                          MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                      MessageBox.Show("No Record Found to Delete.Please check the entered data again");
                    }
                }
                catch (Exception ex)
                  {
                   MessageBox.Show(ex.Message);
                   } 
            }
         }
       
        private void button2_Click(object sender, EventArgs e)
        {
                
        }        
       
     }
}
