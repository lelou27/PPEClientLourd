using MySql.Data.MySqlClient;
using System.Data;

namespace PPEClientLourd
{
    public class Curs
    {
        private bool fin;
        private MySqlConnection maconnexion;
        private MySqlCommand macommand;
        private MySqlDataReader monreader;
        private MySqlParameterCollection col;

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

        public void AjouteparametreCol( string nompara, object valeur ) => col.AddWithValue(nompara, valeur);
        public void DirectionparametreCol( string nompara, ParameterDirection Direction ) => col[nompara].Direction = Direction;
        public void SetCol( int i, object valeur ) => col[i].Value = valeur;

        public MySqlParameterCollection GetCol() => col;


        public void ReqAdmin( string req )
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.ExecuteNonQuery();

        }

        public object Appelfonctstockee()
        {
            object O = macommand.ExecuteNonQuery();
            return O;

        }
        public void DefFonctStockee( string req )
        {

            macommand = new MySqlCommand(req, maconnexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            col = macommand.Parameters;


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
