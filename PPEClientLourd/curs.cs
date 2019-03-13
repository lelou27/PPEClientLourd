using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace PPEClientLourd
{
    public class Curs
    {
        Boolean fin;
        MySqlConnection maconnexion;
        MySqlCommand macommand;
        MySqlDataReader monreader;
        MySqlParameterCollection col;

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

        public void AjouteparametreCol(string nompara, object valeur)
        {

            col.AddWithValue(nompara, valeur);

        }
        public void DirectionparametreCol(string nompara, ParameterDirection Direction)
        {
            col[nompara].Direction = Direction;
        }
        public void SetCol(int i, Object valeur)
        {
            col[i].Value = valeur;

        }

        public MySqlParameterCollection GetCol()
        {

            return col;
        }


        public void ReqAdmin(string req)
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.ExecuteNonQuery();

        }

        public Object Appelfonctstockee()
        {
            Object O = macommand.ExecuteNonQuery();
            return O;

        }
        public void DefFonctStockee(string req)
        {

            macommand = new MySqlCommand(req, maconnexion);
            macommand.CommandType = CommandType.StoredProcedure;
            col = macommand.Parameters;


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
