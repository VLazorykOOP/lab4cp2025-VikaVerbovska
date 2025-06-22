using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ComputerSalesApp
{
    public class Database
    {
        private MySqlConnection connection;

        public Database()
        {
            string connectionString = "server=localhost;user=root;password=171717;database=computersdb;";
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetAllComputers()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT * FROM computers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public void AddComputer(string name, string cpu, string frequency, string gpu, string ram, string soundcard, string hdd)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO computers (name, cpu, frequency, gpu, ram, soundcard, hdd) VALUES (@name, @cpu, @frequency, @gpu, @ram, @soundcard, @hdd)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cpu", cpu);
                cmd.Parameters.AddWithValue("@frequency", frequency);
                cmd.Parameters.AddWithValue("@gpu", gpu);
                cmd.Parameters.AddWithValue("@ram", ram);
                cmd.Parameters.AddWithValue("@soundcard", soundcard);
                cmd.Parameters.AddWithValue("@hdd", hdd);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateComputer(int id, string name, string cpu, string frequency, string gpu, string ram, string soundcard, string hdd)
        {
            try
            {
                connection.Open();
                string query = "UPDATE computers SET name=@name, cpu=@cpu, frequency=@frequency, gpu=@gpu, ram=@ram, soundcard=@soundcard, hdd=@hdd WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cpu", cpu);
                cmd.Parameters.AddWithValue("@frequency", frequency);
                cmd.Parameters.AddWithValue("@gpu", gpu);
                cmd.Parameters.AddWithValue("@ram", ram);
                cmd.Parameters.AddWithValue("@soundcard", soundcard);
                cmd.Parameters.AddWithValue("@hdd", hdd);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteComputer(int id)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM computers WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SearchComputersByName(string searchText)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string query = "SELECT * FROM computers WHERE name LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
