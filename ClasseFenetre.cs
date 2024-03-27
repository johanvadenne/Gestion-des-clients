using Classe_Rideau;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_clients
{
    internal class ClasseFenetre
    {
        ClasseADO BdRideau = new ClasseADO();

        public int numClient { get; set; }
        public int numFenetre { get; set; }
        public decimal hauteurFenetre { get; set; }
        public decimal largeurFenetre { get; set; }

        public DataTable SQLFenetreClient(int numClient)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT NUMFENETRE ,HAUTEURFENETRE, LARGEURFENETRE FROM FENETRE WHERE NUMCLIENT = " + numClient.ToString(), BdRideau.ConnexionBase());

            DataTable fenetres = new DataTable();
            fenetres.Load(sqlCmd.ExecuteReader());
            return fenetres;
        }


        public DataTable SQLSelectFenetre(int NumFenetre)
        {
            string ChSqlCmd = "select * from FENETRE where NUMFENETRE=" + NumFenetre;
            SqlCommand sqlCmd = new SqlCommand(ChSqlCmd, BdRideau.ConnexionBase());

            // On exécute un curseur pour traiter les données dans la classe
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            this.numClient = Convert.ToInt32(reader["NUMCLIENT"].ToString());
            this.numFenetre = Convert.ToInt32(reader["HAUTEURFENETRE"].ToString());
            this.hauteurFenetre = Convert.ToDecimal(reader["HAUTE"].ToString());
            this.largeurFenetre = Convert.ToDecimal(reader["LARGEURFENETRE"].ToString());
            reader.Close();

            // on Affecte le DataReader dans un DataTable pour l'application cliente
            DataTable selectFenetre = new DataTable();
            selectFenetre.Load(sqlCmd.ExecuteReader());

            return selectFenetre;
        }

    }
}
