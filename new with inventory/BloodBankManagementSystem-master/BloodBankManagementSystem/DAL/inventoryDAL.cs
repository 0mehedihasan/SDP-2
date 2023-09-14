using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagementSystem.BLL;

namespace BloodBankManagementSystem.DAL
{
    class inventoryDAL
    {
        //Create a Connection String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT to display data in DataGridView from database
        public DataTable Select()
        {
            // Create object to DataTAble to hold the data from database and return it
            DataTable dt = new DataTable();

            //Create object of SQL Connection to Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write SQL Query to SElect the DAta from DAtabase
                string sql = "SELECT * FROM tbl_inventory";

                //Create the SQlCommand to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQl DAta Adapter to Hold the Data Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open Database Connection
                conn.Open();

                //Pass the Data from adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region INSERT data to database
        public bool Insert(inventoryBLL d)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Create SqlConnection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write the Query to INSERT data into database
                string sql = "INSERT INTO tbl_inventory (Quanity_No,O_positive,O_negative,A_positive,A_negative,B_positive,B_negative,AB_positive,AB_negative) VALUES (@Quanity_No,@O_positive,@O_negative,@A_positive,@A_negative,@B_positive,@B_negative,@AB_positive,@AB_negative)";

                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value to SQL Query
                cmd.Parameters.AddWithValue("@Quantity_No", d.Quantity_No);
                cmd.Parameters.AddWithValue("@O_positive", d.O_positive);
                cmd.Parameters.AddWithValue("@O_negative", d.O_negative);
                cmd.Parameters.AddWithValue("@A_positive", d.A_positive);
                cmd.Parameters.AddWithValue("@A_negative", d.A_negative);
                cmd.Parameters.AddWithValue("@B_positive", d.B_negative);
                cmd.Parameters.AddWithValue("@B_negative", d.B_negative);
                cmd.Parameters.AddWithValue("@AB_positive", d.AB_positive);
                cmd.Parameters.AddWithValue("@AB_negative", d.AB_negative);

                //Open DAtabase Connection
                conn.Open();

                //Create an Integer Variable to Check whether the query was executed Successfully or Not
                int rows = cmd.ExecuteNonQuery();

                //If the Query is Executed Successfully the value of rows willb e greater than Zero else it will be Zero
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion


    }
}
