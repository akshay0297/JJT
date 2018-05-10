using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;


namespace Try1
{
    public partial class Form1 : Form
    {
        MySqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;

        private MySqlConnection connection;

        private string server, database, uid, password;


        public void connect1()
        {
            try
            {
                server = "localhost";
                // port = "3306";
                database = "jjt";
                uid = "root";
                password = "akshay";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connected");
            }
            catch (Exception e)
            { 
                Console.WriteLine("Error: " + e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        public Form1()
        {
            InitializeComponent();
        }


        private void addCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Added ! ");
        }


        private void viewBal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }


        private void modBal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
