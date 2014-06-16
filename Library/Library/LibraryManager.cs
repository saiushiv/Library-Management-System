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
    public partial class LibraryManager : Form
    {
        public LibraryManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BOOK;", condata);
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

                bkcount.Text = dbt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            condata.Close();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var childform = new ListofBorrowers();
            this.SendToBack();
            childform.ShowDialog();
            this.BringToFront();
                        
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var childform = new BookLoan();
            this.SendToBack();
            childform.ShowDialog();
            this.BringToFront();
                        
        }

        private void button8_Click(object sender, EventArgs e)
        {

                  
            
            if ((this.textBox1.Text.Trim().Length != 0) && (this.textBox2.Text.Trim().Length != 0) && (this.textBox3.Text.Trim().Length != 0))
            {
                string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                MySqlConnection condata = new MySqlConnection(constring);
                MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where ((x.book_id = '"+this.textBox1.Text+"' and x.book_id = y.book_id) and (x.title like '%"+this.textBox2.Text+"%'and x.book_id = y.book_id) and (y.author_name like '%"+this.textBox3.Text+"%' and x.book_id = y.book_id))) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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
                    bkcount.Text = dbt.Rows.Count.ToString();

                    if (bkcount.Text == "0")
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            //

            else if ((this.textBox1.Text.Trim().Length != 0) && (this.textBox2.Text.Trim().Length != 0))
                 {
                string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                MySqlConnection condata = new MySqlConnection(constring);
                MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where ((x.book_id = '"+this.textBox1.Text+"' and x.book_id=y.book_id) and (x.title like '%"+this.textBox2.Text+"%' and x.book_id=y.book_id))) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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

                    bkcount.Text = dbt.Rows.Count.ToString();
                    if (bkcount.Text == "0")
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
            }
            ///////////////////

            else if ((this.textBox1.Text.Trim().Length != 0) && (this.textBox3.Text.Trim().Length != 0))
                 {
                     string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                     MySqlConnection condata = new MySqlConnection(constring);
                     MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where ((x.book_id = '"+this.textBox1.Text+"' and x.book_id=y.book_id) and (y.author_name like '%"+this.textBox3.Text+"%' and x.book_id=y.book_id))) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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

                         bkcount.Text = dbt.Rows.Count.ToString();
                         if (bkcount.Text == "0")
                         {
                             MessageBox.Show("No Record Found");
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message);
                     }

              }

            //////////////

            else if ((this.textBox2.Text.Trim().Length != 0) && (this.textBox3.Text.Trim().Length != 0))
            {
                string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                MySqlConnection condata = new MySqlConnection(constring);
                MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where ((x.title like '%" + this.textBox2.Text + "%' and x.book_id=y.book_id) and (y.author_name like '%" + this.textBox3.Text + "%' and x.book_id=y.book_id))) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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

                    bkcount.Text = dbt.Rows.Count.ToString();
                    if (bkcount.Text == "0")
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

                if (textBox1.Text != "")
                {
                    string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                    MySqlConnection condata = new MySqlConnection(constring);
                    MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where x.book_id = '" + textBox1.Text + "' and x.book_id=y.book_id) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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

                        bkcount.Text = dbt.Rows.Count.ToString();
                        if (bkcount.Text == "0")
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox2.Text != "")
                {
                    string constring = "datasource=localhost;port=3306;username=root;password=sai123";
                    MySqlConnection condata = new MySqlConnection(constring);
                    MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where x.title like '%" + textBox2.Text + "%' and x.book_id=y.book_id) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);

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

                        bkcount.Text = dbt.Rows.Count.ToString();
                        if (bkcount.Text == "0")
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
                    MySqlCommand cmddata = new MySqlCommand("select First.bid as book_id , First.title as title, First.author_name,First.brid as branch_id , First.bname as branch_name,First.bcopies as no_of_copies, ifnull(second.num_out1,0) as num_out, (select(no_of_copies - num_out)) as num_avail from (select b2.book_id as bid, b1.title as title, b1.author_name as author_name,b3.branch_name as bname, b2.branch_id as brid, b2.no_of_copies as bcopies from (select x.book_id, x.title ,y.author_name from library.book x, library.book_authors y where y.author_name like '%" + textBox3.Text + "%' and x.book_id=y.book_id) as b1, library.book_copies as b2, library.library_branch as b3 where b1.book_id = b2.book_id and b2.branch_id = b3.branch_id group by b2.book_id, b2.branch_id) as First left outer join (select book_id as bid, branch_id as brid, count(*) as num_out1 from library.book_loans group by book_id, branch_id) as second on First.bid = second.bid and First.brid = second.brid;", condata);
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

                        bkcount.Text = dbt.Rows.Count.ToString();
                        if (bkcount.Text == "0")
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=sai123";
            MySqlConnection condata = new MySqlConnection(constring);
            MySqlCommand cmddata = new MySqlCommand("SELECT * FROM LIBRARY.BOOK;", condata);
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

                bkcount.Text = dbt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            condata.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["book_id"].Value.ToString();
                textBox2.Text = row.Cells["title"].Value.ToString();
               
            }
        }

     }
}
