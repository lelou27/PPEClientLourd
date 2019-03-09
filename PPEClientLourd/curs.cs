using MySql.Data.MySqlClient;
using System;

namespace PPEClientLourd
{
    public class Curs
    {
        Boolean fin;
        MySqlConnection maconnexion;
        MySqlCommand macommand;
        MySqlDataReader monreader;
        public Curs(string connec)
        {
            maconnexion = new MySqlConnection(connec);
            maconnexion.Open();
            monreader = null;

        }
        public MySqlConnection GetMaconnexion()
        {

            return maconnexion;
        }
        public void ReqSelect(string req)
        {
            macommand = new MySqlCommand(req, maconnexion);
            monreader = macommand.ExecuteReader();
            fin = false;
            Suivant();
        }
        public void Fermer()
        {
            if (monreader != null)
                monreader.Close();
            maconnexion.Close();
        }
        public void Suivant()
        {
            Boolean flag;

            if (!fin)
            {
                flag = monreader.Read();
                if (flag == true)
                    fin = false;
                else
                    fin = true;
            }
        }
        public void ReqAdmin(string req)
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.ExecuteNonQuery();

        }
        public object Champ(string nomChamp)
        {
            return monreader[nomChamp];
        }
        public Boolean Fin()
        {
            return fin;
        }
        public string Compter(string req)
        {
            macommand = new MySqlCommand(req, maconnexion);
            return macommand.ExecuteScalar().ToString();
        }
    }
}
