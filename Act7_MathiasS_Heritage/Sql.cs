using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace Act7_MathiasS_Heritage
{
    internal class Sql
    {
        private static MySqlConnection sql = new MySqlConnection("server=localhost;database=test;port=3306;User Id=root;password=root");
        
        public void CatchUser(ref DataSet infos)
        {
            try
            {
                sql.Open();
                string query = "SELECT * FROM utilisateurs;";
                infos = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
                da.Fill(infos, "mesDonnees");
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public void AfficheAllUser(string login)
        {
            DataSet Infos = new DataSet();
            CatchUser(ref Infos);
            Console.WriteLine("Liste de tous les users : ");
            for (int i = 0; i < Infos.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(Infos.Tables[0].Rows[i]["id"] + " : " + Infos.Tables[0].Rows[i]["prenomUser"] + " " + Infos.Tables[0].Rows[i]["nomUser"] + ", " + Infos.Tables[0].Rows[i]["role"]);
            }
        }
    }
}
