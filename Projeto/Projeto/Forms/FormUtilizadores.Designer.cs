namespace Projeto.Forms
{
    partial class FormUtilizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelemovel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInsFuncao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Função: ";
            // 
            // cbFuncao
            // 
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(444, 119);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(196, 21);
            this.cbFuncao.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(444, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 24);
            this.txtPassword.TabIndex = 98;
            this.txtPassword.Text = "Cidenai123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Telemovel";
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelemovel.Location = new System.Drawing.Point(118, 127);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(196, 24);
            this.txtTelemovel.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(118, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 24);
            this.txtEmail.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 24);
            this.txtNome.TabIndex = 92;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(57, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 91;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AllowUserToResizeColumns = false;
            this.gridUsers.AllowUserToResizeRows = false;
            this.gridUsers.BackgroundColor = System.Drawing.Color.White;
            this.gridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email,
            this.telefone,
            this.idFuncao,
            this.Password,
            this.Editar,
            this.eliminar});
            this.gridUsers.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridUsers.Location = new System.Drawing.Point(17, 200);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridUsers.Size = new System.Drawing.Size(739, 281);
            this.gridUsers.TabIndex = 90;
            this.gridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "IdUser";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "Telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idFuncao
            // 
            this.idFuncao.DataPropertyName = "IdFuncao";
            this.idFuncao.HeaderText = "Funcao";
            this.idFuncao.Name = "idFuncao";
            this.idFuncao.ReadOnly = true;
            this.idFuncao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "PasswordUser";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnInsFuncao
            // 
            this.btnInsFuncao.BackgroundImage = global::Projeto.Properties.Resources.img_554646;
            this.btnInsFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsFuncao.Location = new System.Drawing.Point(646, 111);
            this.btnInsFuncao.Name = "btnInsFuncao";
            this.btnInsFuncao.Size = new System.Drawing.Size(37, 33);
            this.btnInsFuncao.TabIndex = 103;
            this.btnInsFuncao.UseVisualStyleBackColor = true;
            this.btnInsFuncao.Click += new System.EventHandler(this.btnInsFuncao_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Projeto.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(605, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 36);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Projeto.Properties.Resources.save_icon_3;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(661, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(55, 36);
            this.btnGravar.TabIndex = 104;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources._2861870;
            this.pictureBox1.Location = new System.Drawing.Point(678, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(444, 168);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 26);
            this.txtPesquisa.TabIndex = 106;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "E-mail:";
            // 
            // FormUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 482);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnInsFuncao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gridUsers);
            this.Name = "FormUtilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.FormUtilizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsFuncao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelemovel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.Label label6;
    }
}