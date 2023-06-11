using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using SoulLinkApp.Services;


namespace SoulLinkApp
{
    public partial class GenOnePokedex
    {
        public void PrintPokedex()
        {
            //String to connect to server from my localhost :)
            string myConnectionString = "server=localhost;port=3306;user id =dylanburton;password=l0jbRxhP&1v-;database=pokedex";
            //Connection object used to connect to server.
            MySqlConnection pokedexConnection = new MySqlConnection(myConnectionString);

            pokedexConnection.Open();

            /*
             * make a command to perform database operations with MySqlCommand object
             * for this situation, I am displaying the contents of my "Gen 1 Pokedex"
             */
            MySqlCommand displayPokedex = new MySqlCommand("SELECT * FROM gen1", pokedexConnection);
            MySqlDataReader reader = displayPokedex.ExecuteReader();


            //output contents to command line
            while (reader.Read())
            {
                Console.WriteLine($"{reader["number"].ToString()} {reader["name"].ToString()}\tType 1:{reader["type1_id"]}\tType 2:{reader["type2_id"]}\nHP:{reader["hp"]}\tAttack:{reader["attack"]}\tDefense:{reader["defense"]}\tSpecial:{reader["special"]}\tSpeed:{reader["speed"]}");
            }


            //Don't forget to close :)
            pokedexConnection.Close();
        }

    }
}
