using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace Act7_MathiasS_Heritage
{
    internal class Sql
    {
        private static MySqlConnection sql = new MySqlConnection("server=localhost;database=test ;port=3306;User Id=root;password=root");
        
        public void CatchUser(ref DataSet infos)
        {
            try
            {
                sql.Open();
                string query = "SELECT * FROM utilisateurs;";
                infos = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
                da.Fill(infos, "utilisateurs");
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public void AfficheAllUser()
        {
            DataSet Infos = new DataSet();
            CatchUser(ref Infos);
            Console.WriteLine("Liste de tous les users : ");
            for (int i = 0; i < Infos.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(Infos.Tables[0].Rows[i]["id"] + " : " + Infos.Tables[0].Rows[i]["prenomUser"] + " " + Infos.Tables[0].Rows[i]["nomUser"] + ", " + Infos.Tables[0].Rows[i]["role"]);
            }
        }
        public void CatchItems(ref DataSet infos)
        {
            try
            {
                sql.Open();
                string query = "SELECT * FROM biens;";
                infos = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(query, sql);
                da.Fill(infos, "biens");
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public void AfficheAllItems()
        {
            DataSet Infos = new DataSet();
            CatchItems(ref Infos);
            DataSet User = new DataSet();
            CatchUser(ref User);
            Console.WriteLine("Liste de tous les biens : ");
            for (int i = 0; i < Infos.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(Infos.Tables[0].Rows[i]["bienId"] + " : " + Infos.Tables[0].Rows[i]["nom"] + " mesurant " + Infos.Tables[0].Rows[i]["taille"] + "m2 qui coûte " + Infos.Tables[0].Rows[i]["prix"] + ", est à " + Infos.Tables[0].Rows[i]["ville"] + ", a" + Infos.Tables[0].Rows[i]["chambres"] + " chambres, est possédé par " + User.Tables[0].Rows[(int)Infos.Tables[0].Rows[i]["userId"]]["nomUser"] + " " + User.Tables[0].Rows[(int)Infos.Tables[0].Rows[i]["userId"]]["prenomUser"]);
            }
        }
        public void AddItem(int bienId, string nom, int taille, int prix, int userId, string description, int chambres,string ville)
        {
            try
            {
                sql.Open();
                string query = "INSERT INTO `biens`(`bienId`,`taille`,`ville`,`description`,`nom`,`prix`,`userId`,`chambres`) VALUES(@bienId,@taille,@ville,@description,@nom,@prix,@userId,@chambres); ";
                MySqlCommand da = new MySqlCommand(query, sql);
                da.Parameters.AddWithValue("@bienId", bienId );
                da.Parameters.AddWithValue("@nom", nom); 
                da.Parameters.AddWithValue("@taille", taille); 
                da.Parameters.AddWithValue("@userId", userId); 
                da.Parameters.AddWithValue("@description", description); 
                da.Parameters.AddWithValue("@chambres", chambres); 
                da.Parameters.AddWithValue("@ville", ville);
                da.Parameters.AddWithValue("@prix", prix);
                da.ExecuteNonQuery();
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public void RemItem(int bienId)
        {
            try
            {
                sql.Open();
                string query = "DELETE FROM `biens` WHERE `bienId`= "+bienId+"";
                MySqlCommand da = new MySqlCommand(query, sql);
                da.ExecuteNonQuery();
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
        public void ModifieItem(int bienId, string nom)
        {
            try
            {
                sql.Open();
                string query = "UPDATE `biens` SET `nom`=@nom WHERE `bienId`=@bienId;";
                MySqlCommand da = new MySqlCommand(query, sql);
                da.Parameters.AddWithValue("@nom", nom);
                da.Parameters.AddWithValue("@bienId", bienId);
                da.ExecuteNonQuery();
                sql.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

    }
}
