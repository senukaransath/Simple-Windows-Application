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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cusapp
{
    public partial class cusManage : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GQQFKO7N;Initial Catalog=myappdp;Integrated Security=True");
        static String id = "0";


        void clearAll()
        {
            textNIC.Clear();
            textFN.Clear();
            textLN.Clear();
            textEmail.Clear();
            textTel.Clear();

            //clear dattime picker
            dateTimePicker1.Value = DateTime.Now;

            //clear radio butn
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;

            //clear combo box
            textType.SelectedIndex = -1;

            this.custableTableAdapter.Fill(this.myappdpDataSet.custable);
        }


        public cusManage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cusManage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textNIC.Clear();
            textFN.Clear();
            textLN.Clear();
            textEmail.Clear();
            textTel.Clear();
            

            //-------clear date time picker
            dateTimePicker1.Value = DateTime.Now;

            // --------clear radio button
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;

            //------clear combo box
            textType.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----Get Values from Textboxes
            string tnic = textNIC.Text;
            string tfname = textFN.Text;
            string tlname = textLN.Text;
            string temail = textEmail.Text;
            string ttel = textTel.Text;

            //-----Get Values from Datetimepicker
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //-----Get Values from Radio button
            string gender = "male";
            if (radioButtonFemale.Checked)
            {
                gender = "female";
            }

            //-----Get Values from Combobox
            string cusType = "";
            if (textType.SelectedItem != null)
            {
                cusType = textType.SelectedItem.ToString();
            }
            


            if (tnic != "" && tfname != "" && tlname != "" && ttel != "" && temail != "" && gender != "" && cusType != "")
            {
                try
                {
                    SqlCommand cmd = null;
                    cmd = new SqlCommand("insert into custable(cusfname, cusTel, cusGender, cusLname, cusEmail, cusType, cusNic, cusDob)values('" + tfname + "', '" + ttel + "', '" + gender + "', '" + tlname + "', '" + temail + "', '" + cusType + "', '" + tnic + "', '" + dob + "' )", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    clearAll();
                    MessageBox.Show("Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Plz fill all feilds");
            }
            

        }

        private void textType_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            clearAll();



            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure, Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("Delete from custable where cusid = '" + id + "' ", con);
                    cmd.ExecuteNonQuery();

                    con.Close();


                    clearAll();
                    MessageBox.Show("Successfully Deleted");


                }
                catch (Exception ee)
                {
                    //throw;
                    MessageBox.Show("Error" + ee.Message);
                    con.Close();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nic = textNIC.Text;

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from custable where cusNic ='" + nic + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        id = myR["cusid"].ToString();
                        textFN.Text = myR["cusfname"].ToString();
                        textLN.Text = myR["cuslname"].ToString();
                        textEmail.Text = myR["cusEmail"].ToString();
                        textTel.Text = myR["cusTel"].ToString();

                        string mydob = myR["cusDob"].ToString();
                        dateTimePicker1.Value = DateTime.Parse(mydob);

                        string gender = myR["cusGender"].ToString();
                        if(gender == "Male")
                        {
                            radioButtonMale.Checked = true;
                        }else
                        {
                            radioButtonFemale.Checked = true;
                        }

                        string cusType1 = myR["cusType"].ToString();
                        textType.SelectedItem = cusType1;

                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this nic..");
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void textNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tnic = textNIC.Text;
            string tfname = textFN.Text;
            string tlname = textLN.Text;
            string temail = textEmail.Text;
            string ttel = textTel.Text;

            //-----Get Values from Datetimepicker
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            //-----Get Values from Radio button
            string gender = "male";
            if (radioButtonFemale.Checked)
            {
                gender = "female";
            }

            //-----Get Values from Combobox
            string cusType = "";
            if (textType.SelectedItem != null)
            {
                cusType = textType.SelectedItem.ToString();
            }



            if (tnic != "" && tfname != "" && tlname != "" && ttel != "" && temail != "" && gender != "" && cusType != "")
            {

 
                
                try
                {
                    SqlCommand cmd = null;
                    cmd = new SqlCommand("Update custable SET cusfname ='" + tfname + "', cusTel =  '" + ttel + "', cusGender = '" + gender + "', cusLname = '" + tlname + "', cusEmail = '" + temail + "', cusType = '" + cusType + "', cusNic = '" + tnic + "', cusDob = '" + dob + "' where cusid='" + id + "' ", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    clearAll();
                    MessageBox.Show("Successfully Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Plz fill all feilds");
            }

        }

        private void cusManage_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myappdpDataSet.custable' table. You can move, or remove it, as needed.
            this.custableTableAdapter.Fill(this.myappdpDataSet.custable);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
