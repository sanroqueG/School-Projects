
namespace Projeto.Forms
{
    partial class FormProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInsCat = new System.Windows.Forms.Button();
            this.btnInsMarca = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(10, 151);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.Size = new System.Drawing.Size(821, 273);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            this.gridProdutos.SelectionChanged += new System.EventHandler(this.gridProdutos_SelectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(553, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 81;
            this.label11.Text = "Categoria:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(636, 56);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(162, 28);
            this.cmbTipo.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(65, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 26);
            this.txtNome.TabIndex = 63;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(12, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 73;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Enabled = false;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(353, 54);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(156, 28);
            this.cbMarca.TabIndex = 82;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(27, 108);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 20);
            this.lblStock.TabIndex = 86;
            this.lblStock.Text = "Stock:";
            this.lblStock.Visible = false;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(88, 104);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(84, 26);
            this.txtStock.TabIndex = 85;
            this.txtStock.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Marca:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(564, 14);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 26);
            this.txtPesquisa.TabIndex = 90;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Projeto.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(720, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 36);
            this.btnCancelar.TabIndex = 92;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources._2861870;
            this.pictureBox1.Location = new System.Drawing.Point(798, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btnInsCat
            // 
            this.btnInsCat.BackgroundImage = global::Projeto.Properties.Resources._32782241;
            this.btnInsCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsCat.Enabled = false;
            this.btnInsCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsCat.Location = new System.Drawing.Point(803, 56);
            this.btnInsCat.Name = "btnInsCat";
            this.btnInsCat.Size = new System.Drawing.Size(30, 28);
            this.btnInsCat.TabIndex = 89;
            this.btnInsCat.UseVisualStyleBackColor = true;
            this.btnInsCat.Click += new System.EventHandler(this.btnInsCat_Click);
            // 
            // btnInsMarca
            // 
            this.btnInsMarca.BackgroundImage = global::Projeto.Properties.Resources.img_554646;
            this.btnInsMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsMarca.Enabled = false;
            this.btnInsMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsMarca.Location = new System.Drawing.Point(514, 54);
            this.btnInsMarca.Name = "btnInsMarca";
            this.btnInsMarca.Size = new System.Drawing.Size(30, 28);
            this.btnInsMarca.TabIndex = 88;
            this.btnInsMarca.UseVisualStyleBackColor = true;
            this.btnInsMarca.Click += new System.EventHandler(this.btnInsMarca_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Projeto.Properties.Resources.save_icon_3;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(776, 99);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(55, 36);
            this.btnGravar.TabIndex = 74;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 449);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.btnInsCat);
            this.Controls.Add(this.btnInsMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormProduto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsCat;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInsMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}