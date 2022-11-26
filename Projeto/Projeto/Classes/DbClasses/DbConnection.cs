using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Classes.DbClasses
{
    internal class DbConnection
    {
        //string sql = "datasource=www.cidenai.edu.pt;port=3306;username=ccidenai_batgpsi;password=triggertgpsi#540;database=ccidenai_bancoalimentar; convert zero datetime=True";
        string sql = "datasource=localhost; username=root; password=; database=bancoalimentar; convert zero datetime=True";
        //string sql = "Datasource =188.166.172.34; username=admin;password=c!d3n@!#123_us3radmin;database=bancoalimentar";
        
        MySqlConnection conexao;
        public MySqlConnection FazerConexao()
        {
            conexao = new MySqlConnection(sql);

            try
            {
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexão SQL! \n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
            return conexao;

        }

        public void FecharConexao()
        {
            conexao.Close();
        }
            


}
}
