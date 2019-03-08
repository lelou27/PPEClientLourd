using MySql.Data.MySqlClient;

namespace PPEClientLourd
{
    public class Curs
    {
        private bool fin;
        private MySqlConnection maconnexion;
        private MySqlCommand macommand;
        private MySqlDataReader monreader;
        public Curs( string connec )
        {
            maconnexion = new MySqlConnection(connec);
            maconnexion.Open();
            monreader = null;

        }
        public MySqlConnection GetMaconnexion() => maconnexion;
        public void ReqSelect( string req )
        {
            macommand = new MySqlCommand(req, maconnexion);
            monreader = macommand.ExecuteReader();
            fin = false;
            Suivant();
        }
        public void Fermer()
        {
            if (monreader != null)
            {
                monreader.Close();
            }

            maconnexion.Close();
        }
        public void Suivant()
        {
            bool flag;

            if (!fin)
            {
                flag = monreader.Read();
                if (flag == true)
                {
                    fin = false;
                }
                else
                {
                    fin = true;
                }
            }
        }
        public void ReqAdmin( string req )
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.ExecuteNonQuery();

        }
        public object Champ( string nomChamp ) => monreader[nomChamp];
        public bool Fin() => fin;
        public string Compter( string req )
        {
            macommand = new MySqlCommand(req, maconnexion);
            return macommand.ExecuteScalar().ToString();
        }
    }
}
