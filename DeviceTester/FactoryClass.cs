using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceTester
{
    class FactoryClass
    {
        // getter and setter properties
        // acts as data carrier in our application
        public int FactoryId { get; set; }
        public string Product { get; set; }
        public string SerialNumber { get; set; }
        public string Country { get; set; }
        public string Frequency { get; set; }
        public string Variant { get; set; }
        public string TemperatureOffset { get; set; }

        readonly static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString; // TODO - update 

        //selecting data from database
        public DataTable Select()
        {
            //step1: Db connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // 
            DataTable dt = new DataTable();
            try
            {
                // Step2: writing the sql query 
                string sql = "SELECT * FROM table_factory";
                // creating the command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating the SQL adapter usind cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        //insert data into DB
        public bool Insert(FactoryClass f)
        {
            //Creating a default return type and setting
            bool isSuccess = false;

            // Step1: connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Step2: Create a SQL query to insert data
                string sql = "INSERT INTO table_factory (Product, SerialNumber, Country, Frequency, Variant, TemperatureOffset) VALUES(@Product, @SerialNumber, @Country, @Frequency, @Variant,  @TemperatureOffset)";

                // creating the command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add data
                cmd.Parameters.AddWithValue("@Product", f.Product);
                cmd.Parameters.AddWithValue("@SerialNumber", f.SerialNumber);
                cmd.Parameters.AddWithValue("@Country", f.Country);
                cmd.Parameters.AddWithValue("@Frequency", f.Frequency);
                cmd.Parameters.AddWithValue("@Variant", f.Variant);
                cmd.Parameters.AddWithValue("@TemperatureOffset", f.TemperatureOffset);

                //Connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // if query was succesfull then the number of rows will be greater than 0
                if (rows > 0)
                    isSuccess = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }


        //update data in the DB
        public bool Update(FactoryClass f)
        {
            //Creating a default return type and setting
            bool isSuccess = false;

            // Step1: connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Step2: Create a SQL query to update data in DB
                string sql = "UPDATE table_factory SET Product=@Product, SerialNumber=@SerialNumber, Country=@Country, Frequency=@Frequency, Variant=@Variant, TemperatureOffset=@TemperatureOffset WHERE FactoryId=@FactoryId";

                // creating the command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add data
                cmd.Parameters.AddWithValue("@Product", f.Product);
                cmd.Parameters.AddWithValue("@SerialNumber", f.SerialNumber);
                cmd.Parameters.AddWithValue("@Country", f.Country);
                cmd.Parameters.AddWithValue("@Frequency", f.Frequency);
                cmd.Parameters.AddWithValue("@Variant", f.Variant);
                cmd.Parameters.AddWithValue("@TemperatureOffset", f.TemperatureOffset);
                cmd.Parameters.AddWithValue("@FactoryId", f.FactoryId);

                //Connection open here
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // if query was succesfull then the number of rows will be greater than 0
                if (rows > 0)
                    isSuccess = true;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //delete data from the DB
        public bool Delete(FactoryClass f)
        {
            //Creating a default return type and setting
            bool isSuccess = false;

            // Step1: connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Step2: Create a SQL query to update data in DB
                string sql = "DELETE FROM table_factory WHERE FactoryId=@FactoryId";

                // creating the command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add data
                cmd.Parameters.AddWithValue("@FactoryId", f.FactoryId);

                //Connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // if query was succesfull then the number of rows will be greater than 0
                if (rows > 0)
                    isSuccess = true;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
