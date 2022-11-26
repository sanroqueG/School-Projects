
namespace Projeto.Forms
{
    partial class FormDoadores
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gridDadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsCat = new System.Windows.Forms.Button();
            this.btnInsLocal = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(564, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 26);
            this.txtPesquisa.TabIndex = 106;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged_1);
            // 
            // gridDadores
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDadores.Location = new System.Drawing.Point(19, 159);
            this.gridDadores.Name = "gridDadores";
            this.gridDadores.RowHeadersWidth = 51;
            this.gridDadores.Size = new System.Drawing.Size(821, 273);
            this.gridDadores.TabIndex = 93;
            this.gridDadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDadores_CellClick);
            this.gridDadores.SelectionChanged += new System.EventHandler(this.gridDadores_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Localidade:";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(603, 60);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(120, 20);
            this.lblNIF.TabIndex = 102;
            this.lblNIF.Text = "Contribuinte Nº:";
            // 
            // txtNif
            // 
            this.txtNif.Enabled = false;
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(727, 58);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(111, 26);
            this.txtNif.TabIndex = 101;
            // 
            // cbLocal
            // 
            this.cbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocal.Enabled = false;
            this.cbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(464, 106);
            this.cbLocal.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(156, 28);
            this.cbLocal.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(305, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 99;
            this.label11.Text = "Categoria:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(388, 58);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(162, 28);
            this.cmbTipo.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 26);
            this.txtNome.TabIndex = 94;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(12, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 96;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Morada:";
            // 
            // txtMorada
            // 
            this.txtMorada.Enabled = false;
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(87, 108);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(264, 26);
            this.txtMorada.TabIndex = 109;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Projeto.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(727, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 36);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources._2861870;
            this.pictureBox1.Location = new System.Drawing.Point(798, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsCat
            // 
            this.btnInsCat.BackgroundImage = global::Projeto.Properties.Resources._32782241;
            this.btnInsCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsCat.Enabled = false;
            this.btnInsCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsCat.Location = new System.Drawing.Point(555, 58);
            this.btnInsCat.Name = "btnInsCat";
            this.btnInsCat.Size = new System.Drawing.Size(30, 28);
            this.btnInsCat.TabIndex = 105;
            this.btnInsCat.UseVisualStyleBackColor = true;
            this.btnInsCat.Click += new System.EventHandler(this.btnInsCat_Click_1);
            // 
            // btnInsLocal
            // 
            this.btnInsLocal.BackgroundImage = global::Projeto.Properties.Resources.img_554646;
            this.btnInsLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsLocal.Enabled = false;
            this.btnInsLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsLocal.Location = new System.Drawing.Point(625, 106);
            this.btnInsLocal.Name = "btnInsLocal";
            this.btnInsLocal.Size = new System.Drawing.Size(30, 28);
            this.btnInsLocal.TabIndex = 104;
            this.btnInsLocal.UseVisualStyleBackColor = true;
            this.btnInsLocal.Click += new System.EventHandler(this.btnInsLocal_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Projeto.Properties.Resources.save_icon_3;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(783, 103);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(55, 36);
            this.btnGravar.TabIndex = 97;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // FormDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridDadores);
            this.Controls.Add(this.btnInsCat);
            this.Controls.Add(this.btnInsLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormDoadores";
            this.Text = "Dadores";
            this.Load += new System.EventHandler(this.FormDoadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView gridDadores;
        private System.Windows.Forms.Button btnInsCat;
        private System.Windows.Forms.Button btnInsLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMorada;
    }
}