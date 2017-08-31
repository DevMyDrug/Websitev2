using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebTest1
{
    public class Database
    {
        MySqlConnection co = new MySqlConnection();

        public Database()
        {
            co = new MySqlConnection("server=localhost;port=3306;user id=root;password=Amandine#0604;database=website1;");
        }

        public Dictionary<string, string> Query(string query)
        {
            Dictionary<string, string> dicoRep = new Dictionary<string, string>();

            co.Open();
            using (var command = co.CreateCommand())
            {
                command.CommandText = query;
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        dicoRep.Add(dataReader.GetName(i), dataReader[i].ToString());
                    }
                }
            }
            co.Close();
            return dicoRep;
        }

        public void NonQuery(string nonquery, Dictionary<string, object> vars = null)
        {
            co.Open();
            MySqlCommand command = co.CreateCommand();
            command.CommandText = nonquery;
            if (vars != null && vars.Keys.Count > 0)
            {
                foreach (string key in vars.Keys)
                {
                    command.Parameters.AddWithValue(key, vars[key]);
                }
            }
            command.ExecuteNonQuery();
            co.Close();
        }

    }
}