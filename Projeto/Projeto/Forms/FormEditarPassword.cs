using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;

namespace Projeto.Forms
{
    public partial class FormEditarPassword : Form
    {
        Form1 f1 = new Form1();
        DbConnection con = new DbConnection();
     
        public FormEditarPassword()
        {
            InitializeComponent();
        }

        int iduser = 0;
        public int currentUserId(int id)
        {
          iduser = id;
            MessageBox.Show("A " + iduser);

            return iduser;
        }


      
        private void btnGravar_Click(object sender, EventArgs e)
        {
            iduser = currentUserId(f1.userId);
            string sql = "UPDATE password_user WHERE id=@user_id";

            using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user_id", iduser);
                cmd.ExecuteNonQuery();
            }

            
        }
    }
}
