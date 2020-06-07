using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPIM
{
    public class SQLcommand
    {
        
        MySqlCommand cmd = new MySqlCommand();

        #region VARIAVEIS
        // >PRIVATE<
        private DataTable _dtcadunidade = new DataTable();

        // >PUBLIC<
        public DataTable dtcadunidade
        {
            get
            {
                return _dtcadunidade;
            }
            set
            {
                _dtcadunidade = value;
            }
        }
        #endregion

        #region METODOS - SELECT
        public void cadunidadeselect_porID(string idunidade)
        { 
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "SELECT * FROM cadunidade where id_unidade ='"+idunidade+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(_dtcadunidade);
            cmd.Connection.Close();
        }
        
        #endregion

        #region METODOS - INSERT, UPDATE, DELETE
        public void cadunidadeinsert(string desc, string status)
        {
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "insert into cadunidade (descricao, status) values ('"+desc+"','"+status+"')";
            try
            {
                cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Connection.Close();
        }

        public void cadunidadeupdate(string desc, string status,string id)
        {
            cmd.Connection = connectionString.conn();
            cmd.CommandText = "update cadunidade set descricao='" + desc + "', status='" + status + "' where id_unidade='" + id + "';";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Connection.Close();
        }
        #endregion
    }
}
