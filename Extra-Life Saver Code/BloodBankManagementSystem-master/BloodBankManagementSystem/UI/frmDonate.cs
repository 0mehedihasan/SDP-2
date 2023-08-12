using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmDonate : Form
    {
        //Create object of Donor BLL and Donor DAL
        donateBLL d = new donateBLL();
        //donorDAL dal = new donorDAL();
        donateDAL dal = new donateDAL();
        userDAL udal = new userDAL();


        public frmDonate()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
        }

        private void frmDonate_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //We will write the code to Donate Blood To Another Person Etc
            //Step 1. Get the DAta from Donate Form
            d.first_name = txtQuantity.Text;
            d.last_name = txtdonorLastName.Text;
            d.email = txtdonorEmail.Text;
            d.gender = cmbdonorGender.Text;
            //d.blood_group = cmbBloodGroup.Text;
            d.contact = txtdonorContact.Text;
            d.address = txtdonorAddress.Text;
            d.donate_date = DateTime.Now;

            //Get The ID of Logged In USer
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.donate_by = usr.user_id;

            //Step2: Inserting Data into Database
            //Create a Boolean Variable to Isnert DAta into DAtabase and check whether the data inserted successfully of not
            bool isSuccess = dal.Insert(d);
            //bool delete = dal.Delete(d);
            //bool data = dal.Select(d);
            //if the Data is inserted successfully then the values of isSuccess will be True else it will be false
            if (isSuccess == true)
            {
                //Data Inserted Successfully
                MessageBox.Show("Blood Donate Information Added Successfully");

                //Refresh Datagrid View
                DataTable dt = dal.Select();
                dgvDonate.DataSource = dt;

                //Clear all the Textboxes
                Clear();
            }
            else
            {
                //FAiled to Insert Data
                MessageBox.Show("Failed to Add Donate Blood.");
            }
        }
        //Create a Method to Clear all the Textboxes
        public void Clear()
        {
            //Clear all the TExtboxes
            txtQuantity.Text = "";
            txtdonorLastName.Text = "";
            txtdonorEmail.Text = "";
            txtDonorID.Text = "";
            cmbdonorGender.Text = "";
            //cmbBloodGroup.Text = "";
            txtdonorContact.Text = "";
            txtdonorAddress.Text = "";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
