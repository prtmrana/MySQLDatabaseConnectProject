using MySqlConnector;

namespace MySQLDatabaseConnectProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=mydata;password=mypassword");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM emp", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "| " + reader[1]);
            }
            conn.Close();
        }
    }
}