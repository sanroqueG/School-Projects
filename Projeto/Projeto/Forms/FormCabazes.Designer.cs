
namespace Projeto.Forms
{
    partial class FormCabazes
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.gridNomeCabaz = new System.Windows.Forms.DataGridView();
            this.Cabazes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarProdutosCabaz = new System.Windows.Forms.Button();
            this.btnApagarCabaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNomeCabaz)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(400, 26);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 103;
            this.radioButton1.Text = "Produto";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Checked = true;
            this.rdbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbData.Location = new System.Drawing.Point(493, 25);
            this.rdbData.Margin = new System.Windows.Forms.Padding(2);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(60, 21);
            this.rdbData.TabIndex = 102;
            this.rdbData.TabStop = true;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources._2861870;
            this.pictureBox1.Location = new System.Drawing.Point(796, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(562, 21);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 26);
            this.txtPesquisa.TabIndex = 100;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(10, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 99;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToResizeColumns = false;
            this.gridProdutos.AllowUserToResizeRows = false;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(400, 92);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridProdutos.Size = new System.Drawing.Size(301, 359);
            this.gridProdutos.TabIndex = 98;
            // 
            // gridNomeCabaz
            // 
            this.gridNomeCabaz.AllowUserToAddRows = false;
            this.gridNomeCabaz.AllowUserToDeleteRows = false;
            this.gridNomeCabaz.AllowUserToResizeColumns = false;
            this.gridNomeCabaz.AllowUserToResizeRows = false;
            this.gridNomeCabaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNomeCabaz.BackgroundColor = System.Drawing.Color.White;
            this.gridNomeCabaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNomeCabaz.Location = new System.Drawing.Point(113, 92);
            this.gridNomeCabaz.MultiSelect = false;
            this.gridNomeCabaz.Name = "gridNomeCabaz";
            this.gridNomeCabaz.ReadOnly = true;
            this.gridNomeCabaz.ShowEditingIcon = false;
            this.gridNomeCabaz.Size = new System.Drawing.Size(240, 359);
            this.gridNomeCabaz.TabIndex = 104;
            this.gridNomeCabaz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNomeCabaz_CellClick);
            // 
            // Cabazes
            // 
            this.Cabazes.AutoSize = true;
            this.Cabazes.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cabazes.Location = new System.Drawing.Point(189, 68);
            this.Cabazes.Name = "Cabazes";
            this.Cabazes.Size = new System.Drawing.Size(80, 21);
            this.Cabazes.TabIndex = 105;
            this.Cabazes.Text = "CABAZES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 106;
            this.label1.Text = "PRODUTOS";
            // 
            // btnEditarProdutosCabaz
            // 
            this.btnEditarProdutosCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProdutosCabaz.Location = new System.Drawing.Point(722, 92);
            this.btnEditarProdutosCabaz.Name = "btnEditarProdutosCabaz";
            this.btnEditarProdutosCabaz.Size = new System.Drawing.Size(90, 67);
            this.btnEditarProdutosCabaz.TabIndex = 107;
            this.btnEditarProdutosCabaz.Text = "Editar Produtos";
            this.btnEditarProdutosCabaz.UseVisualStyleBackColor = true;
            this.btnEditarProdutosCabaz.Click += new System.EventHandler(this.btnEditarProdutosCabaz_Click);
            // 
            // btnApagarCabaz
            // 
            this.btnApagarCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarCabaz.Location = new System.Drawing.Point(152, 461);
            this.btnApagarCabaz.Name = "btnApagarCabaz";
            this.btnApagarCabaz.Size = new System.Drawing.Size(143, 36);
            this.btnApagarCabaz.TabIndex = 108;
            this.btnApagarCabaz.Text = "Apagar Cabaz";
            this.btnApagarCabaz.UseVisualStyleBackColor = true;
            this.btnApagarCabaz.Click += new System.EventHandler(this.btnApagarCabaz_Click);
            // 
            // FormCabazes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 509);
            this.Controls.Add(this.btnApagarCabaz);
            this.Controls.Add(this.btnEditarProdutosCabaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cabazes);
            this.Controls.Add(this.gridNomeCabaz);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormCabazes";
            this.Text = "Cabazes Criados";
            this.Load += new System.EventHandler(this.FormCabazes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNomeCabaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DataGridView gridNomeCabaz;
        private System.Windows.Forms.Label Cabazes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarProdutosCabaz;
        private System.Windows.Forms.Button btnApagarCabaz;
    }
}