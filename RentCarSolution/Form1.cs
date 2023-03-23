using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentCarSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection myconn = new SqlConnection();
        SqlDataAdapter myadapter = new SqlDataAdapter();
        DataTable mydt = new DataTable();
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Z:\\Developer\\CarRental.mdf;Integrated Security=True;Connect Timeout=30";

        string carType = "";

        private void place_Rental_Click(object sender, EventArgs e)
        {

            // Get the selected car type
            
            if (compact.Checked)
                carType = "Compact";
            else if (SUV.Checked)
                carType = "SUV";
            else if (SportsCar.Checked)
                carType = "Sports Car";

            // Get the rental period
            DateTime rentDate = dateTimePicker1.Value;
            DateTime returnDate = dateTimePicker2.Value;
            TimeSpan rentalPeriod = returnDate - rentDate;

            // Calculate the rental cost
            decimal rentalCost = 0;
            if (carType == "Compact")
                rentalCost = 25 * (rentalPeriod.Days + 1);
            else if (carType == "SUV")
                rentalCost = 40 * (rentalPeriod.Days + 1);
            else if (carType == "Sports Car")
                rentalCost = 60 * (rentalPeriod.Days + 1);

            if (checkBox1.Checked)
                rentalCost += 25;


            // Save the rental information to the database
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO CarRental (CarType, Plate#, RentDate, ReturnDate, ExtraDriver, TotalCost) VALUES (@CarType, @Plate#, @RentDate, @ReturnDate, @ExtraDriver, @Cost)", connection);
            command.Parameters.AddWithValue("@CarType", carType);
            command.Parameters.AddWithValue("@Plate#", licensePlate.Text);
            command.Parameters.AddWithValue("@RentDate", rentDate);
            command.Parameters.AddWithValue("@ReturnDate", returnDate);
            command.Parameters.AddWithValue("@ExtraDriver", checkBox1.Checked);
            command.Parameters.AddWithValue("@Cost", rentalCost);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void fill_Button_Click(object sender, EventArgs e)
        {
            // Display the rental information in the DataGridView control
            string selectCommand = "SELECT * FROM CarRental";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }


}
