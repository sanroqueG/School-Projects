using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto.Classes;
using Projeto.Classes.DbClasses;

namespace Projeto
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
       
        private Form activeForm;

        DbConnection con = new DbConnection();
        List<Funcao> listaFuncoes;


        

        List<Permissao> listaPermissao;
        BindingList<Utilizador> listaUtilizador;
        public int userId = -1;
        string permissao = "";
        string user = "";
        string pword = "";
        bool trigger;
        //Constructor

        private string _xamppPanelPath;
        public Form1()
        {
            InitializeComponent();

            _xamppPanelPath = @"C:\xampp\xampp-control.exe";
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            //btnCloseChildFormlogo.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(30, 132, 73);
            public static Color color1 = Color.FromArgb(34, 153, 84);
            public static Color color2 = Color.FromArgb(35, 155, 86);
            public static Color color3 = Color.FromArgb(39, 174, 96);
            public static Color color4 = Color.FromArgb(40, 180, 99);
            public static Color color5 = Color.FromArgb(46, 204, 113);
        }
        private void ActivateButton(object btnSender, Color color)
        {
            try
            {
                if (btnSender != null)
                {
                    try
                    {
                        if (currentButton != (Button)btnSender)
                        {
                            DisableButton();

                            currentButton = (Button)btnSender;
                            currentButton.BackColor = color;
                            currentButton.ForeColor = Color.White;
                            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            panelTitleBar.BackColor = color;
                            //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                            ThemeColor.PrimaryColor = color;
                            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                            btnCloseChildFormlogo.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); 
            }
            
        }
        private void PreencheListaFuncao()
        {
            try
            {
                DbConnection con = new DbConnection();
                listaFuncoes = new List<Funcao>();
                string sql = "select * from funcoes";
                using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcao funcao = new Funcao(reader.GetInt32("id_funcao"), reader.GetString("designacao"), reader.GetString("Permissao"));
                            listaFuncoes.Add(funcao);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
        private void changeCloseFormButtonColor(Color color)
        {
            panelTitleBar.BackColor = color;
            pbUserAvatar.BackColor = color;
           // lblUtilizador.BackColor = color;
            panelLogo.BackColor = Color.Transparent;
            btnCloseChildFormlogo.BackColor = color;
        }
        private void DisableButton()
        {
            try
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        panelMenu.BackColor = RGBColors.color5;
                        previousBtn.BackColor = RGBColors.color5;
                        previousBtn.ForeColor = Color.White;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                ActivateButton(btnSender, RGBColors.color1);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }
        private void btnDoadores_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormDoadores(), sender);
        }
        private void btnReceptores_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormReceptores(), sender);
        }
        private void btnEntradas_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.Entradas(), sender);
        }
        private void btnSaidas_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormCabazes(), sender);
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormProduto(), sender);
        }
        private void btnCabazes_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormSaida(), sender);
        }
        private void btnCloseChildFormlogo_Click(object sender, EventArgs e)
        {
            //changeCloseFormButtonColor(RGBColors.color2);
            //OpenChildForm(new Forms.FormUtilizador(), sender);
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           

                foreach (var process in Process.GetProcessesByName("xamp-control.exe"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        private void panelLoginDesign()
        {
            panelLogin.BorderStyle = BorderStyle.None;
           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {


            ExecuteAsAdmin(_xamppPanelPath);
            ExecuteAsAdmin(_xamppPanelPath);

            panelLoginDesign();
         
           
            pictureBox2.Visible = false;
            cbVerPassword2.Visible = false;
           
            PreencheListaFuncao();
            trigger = false;
            lblTitle.Text = "Autenticação";
            txtConfPassword.Visible = false;
            fieldActivation(trigger);
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            panelLogo.BackColor = RGBColors.color5;
            btnCloseChildFormlogo.BackColor = RGBColors.color5;
            pbUserAvatar.BackColor = RGBColors.color5;
          //  lblUtilizador.BackColor = RGBColors.color5;
            panelMenu.BackColor = RGBColors.color5;
            panelTitleBar.BackColor = RGBColors.color5;
            btnGuardarPassword.Visible = false;

                    lblUtilizador.BackColor = RGBColors.color5;
                    lblUtilizador.ForeColor = Color.White;
                    lblUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            

            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = RGBColors.color5;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        
        private void btnUtilizadores_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormUtilizadores(), sender);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            changeCloseFormButtonColor(RGBColors.color2);
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormDashboard(), sender);
        }
        private void fieldActivation(bool trigger)
        {
            btnCloseChildFormlogo.Enabled = trigger;
            btnCloseChildFormlogo.Visible = trigger;
            btnDashboard.Enabled = trigger;
            btnDashboard.Visible = trigger;
            pbUserAvatar.Enabled = false;
            pbUserAvatar.Visible = false;
            lblUtilizador.Enabled = false;
            lblUtilizador.Visible = false;
          
            btnProdutos.Enabled = trigger;
            btnProdutos.Visible = trigger;
            btnDoadores.Enabled = trigger;
            btnDoadores.Visible = trigger;
            btnReceptores.Enabled = trigger;
            btnReceptores.Visible = trigger;
            btnEntradas.Enabled = trigger;
            btnEntradas.Visible = trigger;
            btnCabazes.Enabled = trigger;
            btnCabazes.Visible = trigger;
            btnSaidas.Enabled = trigger;
            btnSaidas.Visible = trigger;
            btnUtilizadores.Enabled = trigger;
            btnUtilizadores.Visible = trigger;
        }
        private Funcao RetornaFuncao(int idFuncao)
        {
            foreach (Funcao funcao in listaFuncoes)
                if (funcao.CodFuncao == idFuncao)
                    return funcao;
            return null;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM users WHERE email=@email AND password_user=@password";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                listaUtilizador = new BindingList<Utilizador>();
                using (MySqlCommand cmd2 = new MySqlCommand(sql, con.FazerConexao()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUtilizador.Add(new Utilizador(reader.GetString("nome"),
                                                  RetornaFuncao(reader.GetInt32("id_funcao")),
                                                  reader.GetString("password_user")));
                            userId = (reader.GetInt32("id_user"));
                            user = reader.GetString("nome");
                            pword = reader.GetString("password_user");
                        }
                    }
                }

                PreencheListaPermissoes();
                lblUtilizador.Text = user;

                lblUtilizador.AutoSize = true;
                lblUtilizador.TextAlign = ContentAlignment.MiddleCenter;
                // lblUtilizador.Dock = DockStyle.Fill;
                //pictureBox2.Visible = true;

                foreach (Permissao item in listaPermissao)
                {
                    MessageBox.Show(item.Designacao);
                }

                if (pword != txtPassword.Text)
                {
                    labelPasswordIncorreta.Visible = true;

                    labelPasswordIncorreta.Text = "Password incorreta!";
                    labelPasswordIncorreta.ForeColor = Color.Red;
                }
                else
                {
                    labelPasswordIncorreta.Visible = false;
                    labelAltPassword.Font = new Font("Arial", this.labelPasswordIncorreta.Font.Size);
                    labelConfPassword.Font = new Font("Arial", this.labelPasswordIncorreta.Font.Size);
                    pictureBox2.Visible = true;

                    if (pword == "Cidenai123")
                    {

                        MessageBox.Show("Altere a sua password!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtConfPassword.Visible = true;
                        labelAltPassword.Text = "Insira a nova password no campo acima!";
                        labelAltPassword.ForeColor = Color.Red;
                        txtPassword.Text = "";
                        labelConfPassword.Text = "Confirme a password no campo acima!";
                        labelConfPassword.ForeColor = Color.Red;
                        btnLogin.Visible = false;
                        btnGuardarPassword.Visible = true;
                        cbVerPassword2.Visible = true;
                    }
                    else
                    {

                        execPermissao();

                        btnDashboard.PerformClick();

                        panelMenu.Width = 209;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }
        private void verificarNovaSenha(string password, int id)
        {
            string sql = "UPDATE users SET password_user=@password WHERE id_user=@iduser";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@iduser", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
            
        }
        private void btnGuardarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtConfPassword.Text)
                {
                    try
                    {
                        verificarNovaSenha(txtPassword.Text, userId);
                        MessageBox.Show("Password alterada com sucesso! " +
                                        "\nEfetue a autenticação com as novas credenciais!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtConfPassword.Visible = false;
                        labelAltPassword.Visible = false;
                        labelConfPassword.Visible = false;
                        btnGuardarPassword.Visible = false;
                        btnLogin.Visible = true;
                        cbVerPassword2.Visible = false;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords nao coincidem!", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private string checkFuncao() //ver qual funcao o utilizador possui
        {

            string funcao = "";
            foreach (var item in listaUtilizador)
            {
                funcao = (item.IdFuncao).ToString();
            }
            return funcao;
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            txtPassword.Text = "";
            trigger = false;
        }
        private void PreencheListaPermissoes()
        {
            try
            {
                DbConnection con = new DbConnection();
                listaPermissao = new List<Permissao>();
                string sql = "select permissao from funcoes WHERE designacao=@funcao";
                using (MySqlCommand cmd = new MySqlCommand(sql, con.FazerConexao()))
                {
                    cmd.Parameters.AddWithValue("@funcao", checkFuncao());
                    string result = (string)cmd.ExecuteScalar();
                    permissao = result;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
        private void execPermissao() //Ver qual permissao o utilizador possui
        {
            try
            {
                // Permissoes: Administrador | Coordenador | Delegado | Voluntário
                if (permissao == "Administrador")
                {
                    Administrador();
                }
                else if (permissao == "Coordenador")
                {
                    Coordenador();
                }
                else if (permissao == "Delegado")
                {
                    Delegado();
                }
                else if (permissao == "Voluntário")
                {
                    Voluntario();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
           
        }
        private void Administrador()
        {
            btnCloseChildFormlogo.Enabled = true;
            btnCloseChildFormlogo.Visible = true;
            btnDashboard.Enabled = true;
            btnDashboard.Visible = true;
            pbUserAvatar.Enabled = true;
            pbUserAvatar.Visible = true;
            lblUtilizador.Enabled = true;
            lblUtilizador.Visible = true;
            btnProdutos.Enabled = true;
            btnProdutos.Visible = true;
            btnDoadores.Enabled = true;
            btnDoadores.Visible = true;
            btnReceptores.Enabled = true;
            btnReceptores.Visible = true;
            btnEntradas.Enabled = true;
            btnEntradas.Visible = true;
            btnCabazes.Enabled = true;
            btnCabazes.Visible = true;
            btnSaidas.Enabled = true;
            btnSaidas.Visible = true;
            btnUtilizadores.Enabled = true;
            btnUtilizadores.Visible = true;
        }
        private void Coordenador()
        {
            btnCloseChildFormlogo.Enabled = true;
            btnCloseChildFormlogo.Visible = true;
            btnDashboard.Enabled = true;
            btnDashboard.Visible = true;
            pbUserAvatar.Enabled = true;
            pbUserAvatar.Visible = true;
            lblUtilizador.Enabled = true;
            lblUtilizador.Visible = true;
            btnProdutos.Enabled = true;
            btnProdutos.Visible = true;
            btnDoadores.Enabled = true;
            btnDoadores.Visible = true;
            btnReceptores.Enabled = true;
            btnReceptores.Visible = true;
            btnEntradas.Enabled = true;
            btnEntradas.Visible = true;
            btnCabazes.Enabled = true;
            btnCabazes.Visible = true;
            btnSaidas.Enabled = true;
            btnSaidas.Visible = true;
            btnUtilizadores.Enabled = false;
            btnUtilizadores.Visible = false;
        }
        private void Delegado()
        {
            btnCloseChildFormlogo.Enabled = true;
            btnCloseChildFormlogo.Visible = true;

            pbUserAvatar.Enabled = true;
            pbUserAvatar.Visible = true;

            btnDashboard.Enabled = true;
            btnDashboard.Visible = true;

            lblUtilizador.Enabled = true;
            lblUtilizador.Visible = true;

            btnProdutos.Enabled = true;
            btnProdutos.Visible = true;

            btnDoadores.Enabled = false;
            btnDoadores.Visible = false;

            btnReceptores.Enabled = false;
            btnReceptores.Visible = false;

            btnEntradas.Enabled = true;
            btnEntradas.Visible = true;

            btnCabazes.Enabled = true;
            btnCabazes.Visible = true;

            btnSaidas.Enabled = false;
            btnSaidas.Visible = false;

            btnUtilizadores.Enabled = false;
            btnUtilizadores.Visible = false;
        }
        private void Voluntario()
        {
            btnCloseChildFormlogo.Enabled = true;
            btnCloseChildFormlogo.Visible = true;

            pbUserAvatar.Enabled = true;
            pbUserAvatar.Visible = true;

            btnDashboard.Enabled = true;
            btnDashboard.Visible = true;

            lblUtilizador.Enabled = true;
            lblUtilizador.Visible = true;

            btnProdutos.Enabled = true;
            btnProdutos.Visible = true;

            btnDoadores.Enabled = false;
            btnDoadores.Visible = false;

            btnReceptores.Enabled = false;
            btnReceptores.Visible = false;

            btnEntradas.Enabled = true;
            btnEntradas.Visible = true;

            btnCabazes.Enabled = true;
            btnCabazes.Visible = true;

            btnSaidas.Enabled = false;
            btnSaidas.Visible = false;

            btnUtilizadores.Enabled = false;
            btnUtilizadores.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo sair?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }


        private void cbVerPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void cbVerPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerPassword2.Checked == true)
            {
                txtConfPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfPassword.PasswordChar = '*';
            }
        }
    }
}
