using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.App.Persistencia
{
    public class AppContext2
    {
        public NpgsqlConnection Client = new NpgsqlConnection();
        static String Host = "localhost";
        static String DbName = "Prueba";
        static String Username = "postgres";
        static String Password = "6y2w4r3e3e1q9o";
        static String Port = "5432";

        String Cadena = "server="+Host+";"+"port="+Port+";"+"user id="+Username+";"+"password="+Password+";"+"database="+DbName+";";

        public NpgsqlConnection Connection()
        {
            try
            {
                Client.ConnectionString = Cadena;
                Client.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch(NpgsqlException e)
            {
                Console.Write("No hubo conexión a la base de datos (postgresql), erro: " + e.ToString());
            }

            return Client;
        }
        
    }
}
