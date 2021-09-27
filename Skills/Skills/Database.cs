using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    class Database
    {
        private SqlConnection connection;

        //Constructor
        public Database()
        {
            Initialize();
        }

      
        private void Initialize()
        { 
            string connectionString;

            //string to connect to sql database
            connectionString = "Server=localhost; Database=products; Trusted_Connection=True;";

            //makes the connection to the server
            connection = new SqlConnection(connectionString);
        }

    
        public bool OpenConnection()
        {
            //connects to the database
            try
            { 
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                //if there is an error give user the error message
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }

        }

        //Closes connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //Insert statement
        public void Insert(int id, string name, decimal price, int minPlayers, int maxPlayers, string type, int minAge, int maxAge, double playerDuration, string imgUrl)
        {
            //query to insert all new info into database
            string query = "INSERT INTO products (id, name, price, minPlayers, maxPlayers, type, minAge, maxAge, playDuration, imgUrl) VALUES ('" + id++ + "','" + name + "','" + price + "','" + minPlayers + "','" + maxPlayers +"','" + type + "','" + minAge + "','" + maxAge + "','" + (float)playerDuration + "','" + imgUrl + "')";

            //scoped local variable cmd to execute query
            using (var cmd = new SqlCommand(query, connection))
            {
                this.OpenConnection();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(int id)
        {
            //deletes a row at the given row number
            string query = "DELETE FROM products WHERE id=" + id;

            using (var cmd = new SqlCommand(query, connection)) {
                this.OpenConnection();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public Row[] Select()
        {
            string query = "SELECT * FROM products";
            Row[] arr = null;
            using (var command = new SqlCommand(query, connection))
            {
                this.OpenConnection();
                //here i make new row objects and out them in a array
                using (var reader = command.ExecuteReader())
                {
                    var lis = new List<Row>();
                    while (reader.Read()) {
                        lis.Add(new Row { Id = Convert.ToInt32(reader[0]),
                            Name = Convert.ToString(reader[1]), 
                            Price = Convert.ToDecimal(reader[2]),
                            MinPlayers = Convert.ToInt32(reader[3]), 
                            MaxPlayers = Convert.ToInt32(reader[4]), 
                            Type = Convert.ToString(reader[5]),
                            MinAge = Convert.ToInt32(reader[6]), 
                            MaxAge = Convert.ToInt32(reader[7]), 
                            PlayDuration = (float)Convert.ToDouble(reader[8]), 
                            ImgUrl = Convert.ToString(reader[9])
                        });
                    }
                    arr = lis.ToArray();
                }
                this.CloseConnection();
            }
                return arr;
        }
            
        
        //Count statement
        public int Count()
        {
                 string query = "SELECT Count(*) FROM products";
                 int Count = -1;
                //Create sql Command && runs it
                using (var cmd = new SqlCommand(query, connection))
                {
                    this.OpenConnection();
                    Count = (int)cmd.ExecuteScalar();
                    this.CloseConnection();
                }
                return Count;
        }
    }
}

