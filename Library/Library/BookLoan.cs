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
//using Microsoft.Office.Interop.Excel;



namespace Library
{
    public partial class BookLoan : Form
    {
        public BookLoan()
        {
            InitializeComponent();
            FillCombo();
             }

        void FillCombo()
        {
            string constring1 = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring1);
            string Query = "SELECT * FROM LIBRARY.LIBRARY_BRANCH;";
            MySqlCommand condelc = new MySqlCommand(Query, condata);
            MySqlDataReader myReader;

           /*
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = condelc;
            DataTable dbt = new DataTable();
            sda.Fill(dbt);
            BindingSource bsc = new BindingSource();
            bsc.DataSource = dbt;
            comboBox1.DataSource = bsc;
            comboBox1.Items.Add(branch_id);
            */
            try
            {
                condata.Open();
                myReader = condelc.ExecuteReader();
              
                while (myReader.Read())
                {
                    String sname = myReader.GetString("Branch_id");
                    comboBox1.Items.Add(sname);

                }

                condata.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookLoan_Load(object sender, EventArgs e)
        {
            DOUT.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            DUDATE.Text = (DateTime.Now.Date.AddDays(14).ToString("yyyy/MM/dd"));

            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BOOK_LOANS;", condata);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.BID.Text.Trim().Length == 0) || (this.CDNO.Text.Trim().Length == 0))
            {

                MessageBox.Show("Enter correct values in the textboxes");

            }

            else
            {

                try
                {
                    int count = 0;
                    condata1.Open();
                    string Qc = "SELECT card_no FROM LIBRARY.BOOK_LOANS where card_no ='" + this.CDNO.Text + "'";
                    MySqlCommand conchk = new MySqlCommand(Qc, condata1);
                    MySqlDataReader Qcread;
                    Qcread = conchk.ExecuteReader();
                    while (Qcread.Read())
                    {
                        count = count + 1;
                    }

                    if (count > 2)
                    {
                        MessageBox.Show("Reached MAX LIMIT.A Borrower can get only 3 books at a time.");
                        condata1.Close();
                    }
                    else
                    {
                             condata1.Close();
                             int countbl = 0;
                            condata1.Open();
                            string bls = "SELECT book_id FROM LIBRARY.BOOK_LOANS where book_id ='" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "';";
                            MySqlCommand blscmd = new MySqlCommand(bls, condata1);
                            MySqlDataReader blread;
                            blread = blscmd.ExecuteReader();
                            
                            while (blread.Read())
                            {
                                countbl = countbl + 1;
                            }

                           condata1.Close();          
                      
                        string constring1 = "datasource=localhost;port=3306;username=root;password=sai123";
                        MySqlConnection conchkd = new MySqlConnection(constring1);
                        string copchk = "SELECT NO_OF_COPIES FROM LIBRARY.BOOK_COPIES WHERE book_id = '" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "';";
                        MySqlCommand concmd = new MySqlCommand(copchk, conchkd);
                       
                        conchkd.Open();
                        int copies = Convert.ToInt32(concmd.ExecuteScalar());
                        
                        if (copies == countbl)
                        {
                            MessageBox.Show("No More Copies availableat the moment.Cannot issue this book from this branch");
                            conchkd.Close();
                        }

                        else
                        {
                            MySqlConnection condata = new MySqlConnection(constring1);

                            string Query = "INSERT INTO LIBRARY.Book_Loans values ('" + this.BID.Text + "','" + this.comboBox1.Text + "','" + this.CDNO.Text + "','" + this.DOUT.Text + "','" + this.DUDATE.Text + "');";
                            MySqlCommand coninsert = new MySqlCommand(Query, condata);
                            MySqlDataReader myReader;

                            try
                            {
                                condata.Open();
                                myReader = coninsert.ExecuteReader();
                                MessageBox.Show("Check-out Successfull");
                                condata.Close();

                                //string conup = "datasource=localhost;port=3306;username=root;password=sai123";
                                //MySqlConnection conupd = new MySqlConnection(conup);
                                //string Query1 = "UPDATE LIBRARY.BOOK_COPIES set NO_OF_COPIES = @copies where book_id = '" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "';";
                                //MySqlCommand cmdupd = new MySqlCommand(Query1,conupd);

                                //cmdupd.Parameters.AddWithValue("@copies", copies);

                                ////cmdupd.Parameters["@copies"].Value = copies;

                                //MySqlDataReader myupd;

                                //try
                                //{
                                //    conupd.Open();

                                //    myupd = cmdupd.ExecuteReader();
                                //    conupd.Close();
                                //}
                                //catch (Exception ex)
                                //{
                                //    MessageBox.Show(ex.Message);
                                //}

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            BID.Text = "";
            comboBox1.Text = "";
            CDNO.Text = "";
            DOUT.Text = "";
            DUDATE.Text = "";

            DOUT.Text = DateTime.Now.ToString("yyyy/MM/dd");
            DUDATE.Text = (DateTime.Now.AddDays(14).ToString("yyyy/MM/dd"));

            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BOOK_LOANS;", condata);
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

        private void chk_in_Click(object sender, EventArgs e)
        {

            //string constring1 = "datasource=localhost;port=3306;username=root;password=sai123";
            //MySqlConnection conchkd = new MySqlConnection(constring1);
            //string copchk = "SELECT NO_OF_COPIES FROM LIBRARY.BOOK_COPIES WHERE book_id = '" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "';";
            //MySqlCommand concmd = new MySqlCommand(copchk, conchkd);

            //conchkd.Open();
            //int copies = Convert.ToInt32(concmd.ExecuteScalar());
            //int nc = 1;
            //copies = copies + nc;
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.BID.Text.Trim().Length == 0) || (this.CDNO.Text.Trim().Length == 0))
            {

                MessageBox.Show("Enter correct values in the textboxes");

            }

            else
            {

                try
                {
                    int count = 0;
                    condata1.Open();
                    string Qc = "SELECT card_no FROM LIBRARY.BOOK_LOANS where card_no ='" + this.CDNO.Text + "' and branch_id = '"+Int32.Parse(comboBox1.SelectedItem.ToString())+"' and book_id = '"+this.BID.Text+"'";
                    MySqlCommand conchk = new MySqlCommand(Qc, condata1);
                    MySqlDataReader Qcread;
                    Qcread = conchk.ExecuteReader();
                    while (Qcread.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 0)
                    {
                        MessageBox.Show(" No Record Found.Please check the data");
                    }
                    else
                    {
                        string constringd = "datasource=localhost;port=3306;username=root;password=sai123";
                        MySqlConnection condata = new MySqlConnection(constringd);

                        string Query = "DELETE FROM LIBRARY.BOOK_LOANS where book_id ='" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "' and card_no='" + this.CDNO.Text + "';";
                        MySqlCommand condelete = new MySqlCommand(Query, condata);
                        MySqlDataReader myReader;

                        try
                        {
                            condata.Open();
                            myReader = condelete.ExecuteReader();

                            MessageBox.Show(" Check-in is Successfull");

                            condata.Close();

                            //string conup = "datasource=localhost;port=3306;username=root;password=sai123";
                            //MySqlConnection conupd = new MySqlConnection(conup);
                            //string Query1 = "UPDATE LIBRARY.BOOK_COPIES set NO_OF_COPIES = @copies where book_id = '" + this.BID.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "';";
                            //MySqlCommand cmdupd = new MySqlCommand(Query1, conupd);

                            //cmdupd.Parameters.AddWithValue("@copies", copies);

                            //MySqlDataReader myupd;

                            //try
                            //{
                            //    conupd.Open();

                            //    myupd = cmdupd.ExecuteReader();
                            //    conupd.Close();


                            //    BID.Text = "";
                            //    comboBox1.Text = "";
                            //    CDNO.Text = "";
                            //    DOUT.Text = "";
                            //    DUDATE.Text = "";

                            //}

                            //catch (Exception ex)
                            //{
                            //    MessageBox.Show(ex.Message);
                            //}

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                BID.Text = row.Cells["book_id"].Value.ToString();
                comboBox1.Text =  row.Cells["branch_id"].Value.ToString();
                CDNO.Text = row.Cells["card_no"].Value.ToString();
                DOUT.Text = row.Cells["date_out"].Value.ToString();
                DUDATE.Text = row.Cells["due_date"].Value.ToString();
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            var childform = new Mail();
            this.SendToBack();
            childform.ShowDialog();
            this.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((this.textBox2.Text.Trim().Length == 0) && (this.textBox3.Text.Trim().Length == 0) && (this.textBox4.Text.Trim().Length == 0))
            {
                MessageBox.Show("Please enter data");

            }

            else
            {

                if (textBox2.Text != "")
                {
                    string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                    MySqlConnection condata = new MySqlConnection(constring);
                    MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BOOK_LOANS where card_no = '" + this.textBox2.Text + "';", condata);

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

                        condata.Close();

                        textBox1.Text = dbt.Rows.Count.ToString();
                        if (textBox1.Text == "0")
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox3.Text != "")
                {
                    string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                    MySqlConnection condata = new MySqlConnection(constring);
                    MySqlCommand cmddata = new MySqlCommand("SELECT * from LIBRARY.BOOK_LOANS where book_id = '" + this.textBox3.Text + "';", condata);

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

                        condata.Close();

                        textBox1.Text = dbt.Rows.Count.ToString();
                        if (textBox1.Text == "0")
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox4.Text != "")
                {

                    string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                    MySqlConnection condata = new MySqlConnection(constring);
                    MySqlCommand cmddata = new MySqlCommand("SELECT l.book_id,l.branch_id,l.card_no,l.date_out,l.due_date,b.fname,b.lname FROM LIBRARY.BORROWER as b,LIBRARY.BOOK_LOANS as l where (b.fname LIKE '%" + this.textBox4.Text + "%' or b.lname LIKE '%" + this.textBox4.Text + "%' ) and (b.card_no = l.card_no);", condata);
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

                        condata.Close();

                        textBox1.Text = dbt.Rows.Count.ToString();
                        if (textBox1.Text == "0")
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found");

                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DUDATE.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata1 = new MySqlConnection(constring);
            if ((this.BID.Text.Trim().Length == 0) || (this.CDNO.Text.Trim().Length == 0))
            {

                MessageBox.Show("Enter correct values in the textboxes");

            }

            else
            {

                try
                {
                    int count = 0;
                    condata1.Open();
                    string Qc = "SELECT card_no FROM LIBRARY.BOOK_LOANS where card_no ='" + this.CDNO.Text + "' and branch_id = '" + Int32.Parse(comboBox1.SelectedItem.ToString()) + "' and book_id = '" + this.BID.Text + "'";
                    MySqlCommand conchk = new MySqlCommand(Qc, condata1);
                    MySqlDataReader Qcread;
                    Qcread = conchk.ExecuteReader();
                    while (Qcread.Read())
                    {
                        count = count + 1;
                    }

                    if (count == 0)
                    {
                        MessageBox.Show(" No Record Found.Please check the data");
                        condata1.Close();
                    }
                    else
                    {

                        DUDATE.Text = (DateTime.Now.Date.AddDays(30).ToString("yyyy/MM/dd"));
                        string constringU = "datasource=localhost;port=3306;username=root;password=sai123";
                        MySqlConnection condata = new MySqlConnection(constringU);
                        string Query = "UPDATE LIBRARY.BOOK_LOANS set due_date ='" + this.DUDATE.Text + "' where book_id = '" + this.BID.Text + "' and card_no = '" + this.CDNO.Text + "';";
                        MySqlCommand coninsert = new MySqlCommand(Query, condata);
                        MySqlDataReader myReader;

                        try
                        {
                            condata.Open();
                            myReader = coninsert.ExecuteReader();

                            MessageBox.Show("Book Loan extended Successfully");
                            DUDATE.Enabled = false;
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
        private void button5_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }
       
        
      
    } // This one is for BookLoan:Form

} //This is for namespace


