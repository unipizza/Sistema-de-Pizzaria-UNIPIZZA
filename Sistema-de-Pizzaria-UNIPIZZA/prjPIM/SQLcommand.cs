using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPIM
{
    public class SQLcommand
    {
        MySqlCommand cmd = new MySqlCommand();

        #region VARIAVEIS
        // >PRIVATE<
        private DataTable _dtpizza_porID = new DataTable();
        private DataTable _dtmatprima_porIDPIZZA = new DataTable();
        private DataTable _dtinsertpizza = new DataTable();

        // >PUBLIC<
        public DataTable dtpizza_porID
        {
            get
            {
                return _dtpizza_porID;
            }
            set
            {
                _dtpizza_porID = value;
            }
        }
        public DataTable dtmatprima_porIDPIZZA
        {
            get
            {
                return _dtmatprima_porIDPIZZA;
            }
            set
            {
                _dtmatprima_porIDPIZZA = value;
            }
        }
        public DataTable inserepizza
        {
            get
            {
                return _dtinsertpizza;
            }
            set
            {
                _dtinsertpizza = value;
            }
        }
        #endregion

        #region METODOS - SELECT
        public void selectpizza_porID(int pizzaid)
        { 
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "SELECT * FROM CADPROD WHERE CADPROD_IDPROD = '" + pizzaid + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(_dtpizza_porID);
            cmd.Connection.Close();
        }
        public void selectmatprima_porDESC(int pizzaid){
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "SELECT m.cadmprima_idmat,m.cadmprima_desc,p.pizzaxmat_qtd " +
                "FROM cadmprima M INNER JOIN PIZZAXMAT P ON M.cadmprima_idmat = P.pizzaxmat_idmat " +
                "WHERE P.pizzaxmat_idpizza =  '" + pizzaid + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(_dtmatprima_porIDPIZZA);
            cmd.Connection.Close();
        }
        public void insertpizza(string pizzadesc, string pizzavalor, string pizzagruprod, string pizzastatus)
        {
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "INSERT INTO CADPROD (cadprod_desc, cadprod_valor, cadprod_idgruprod, cadprod_status) " +
                "VALUES ('"+pizzadesc+"','"+pizzavalor+"','"+pizzagruprod+"','"+pizzastatus+"');";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        #endregion

        #region METODOS - INSERT, UPDATE, DELETE
        #endregion
    }
}
