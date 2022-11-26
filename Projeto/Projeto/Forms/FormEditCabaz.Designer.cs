namespace Projeto.Forms
{
    partial class FormEditCabaz
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
            this.gridCabaz = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbInserirProduto = new System.Windows.Forms.ComboBox();
            this.txtInserirQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabaz)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCabaz
            // 
            this.gridCabaz.AllowUserToAddRows = false;
            this.gridCabaz.AllowUserToDeleteRows = false;
            this.gridCabaz.AllowUserToOrderColumns = true;
            this.gridCabaz.AllowUserToResizeColumns = false;
            this.gridCabaz.AllowUserToResizeRows = false;
            this.gridCabaz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridCabaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCabaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Editar,
            this.Eliminar});
            this.gridCabaz.Location = new System.Drawing.Point(12, 151);
            this.gridCabaz.Name = "gridCabaz";
            this.gridCabaz.Size = new System.Drawing.Size(405, 237);
            this.gridCabaz.TabIndex = 0;
            this.gridCabaz.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCabaz_CellClick);
            this.gridCabaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCabaz_CellContentClick);
            this.gridCabaz.SelectionChanged += new System.EventHandler(this.gridCabaz_SelectionChanged);
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(104, 34);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(155, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(104, 70);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(155, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(275, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbInserirProduto
            // 
            this.cbInserirProduto.FormattingEnabled = true;
            this.cbInserirProduto.Location = new System.Drawing.Point(447, 226);
            this.cbInserirProduto.Name = "cbInserirProduto";
            this.cbInserirProduto.Size = new System.Drawing.Size(121, 21);
            this.cbInserirProduto.TabIndex = 7;
            // 
            // txtInserirQuantidade
            // 
            this.txtInserirQuantidade.Location = new System.Drawing.Point(447, 283);
            this.txtInserirQuantidade.Name = "txtInserirQuantidade";
            this.txtInserirQuantidade.Size = new System.Drawing.Size(121, 20);
            this.txtInserirQuantidade.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade:";
            // 
            // FormEditCabaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInserirQuantidade);
            this.Controls.Add(this.cbInserirProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.gridCabaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEditCabaz";
            this.Text = "Editar Cabaz";
            this.Load += new System.EventHandler(this.FormEditCabaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCabaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCabaz;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbInserirProduto;
        private System.Windows.Forms.TextBox txtInserirQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}