namespace Projeto.Forms
{
    partial class FormInsCabazes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridInsSaidas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCabaz = new System.Windows.Forms.TextBox();
            this.btnGravarProd = new System.Windows.Forms.Button();
            this.btnGravaCabaz = new System.Windows.Forms.Button();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInsSaidas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInsSaidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInsSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.quantidade,
            this.Editar,
            this.eliminar});
            this.gridInsSaidas.Location = new System.Drawing.Point(12, 67);
            this.gridInsSaidas.Name = "gridInsSaidas";
            this.gridInsSaidas.RowHeadersWidth = 51;
            this.gridInsSaidas.Size = new System.Drawing.Size(410, 273);
            this.gridInsSaidas.TabIndex = 93;
            this.gridInsSaidas.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Nome Cabaz:";
            // 
            // txtNomeCabaz
            // 
            this.txtNomeCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCabaz.Location = new System.Drawing.Point(122, 21);
            this.txtNomeCabaz.Name = "txtNomeCabaz";
            this.txtNomeCabaz.Size = new System.Drawing.Size(127, 26);
            this.txtNomeCabaz.TabIndex = 94;
            // 
            // btnGravarProd
            // 
            this.btnGravarProd.BackgroundImage = global::Projeto.Properties.Resources.save_icon_3;
            this.btnGravarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarProd.Location = new System.Drawing.Point(367, 355);
            this.btnGravarProd.Name = "btnGravarProd";
            this.btnGravarProd.Size = new System.Drawing.Size(55, 36);
            this.btnGravarProd.TabIndex = 110;
            this.btnGravarProd.UseVisualStyleBackColor = true;
            this.btnGravarProd.Click += new System.EventHandler(this.btnGravarProd_Click);
            // 
            // btnGravaCabaz
            // 
            this.btnGravaCabaz.BackgroundImage = global::Projeto.Properties.Resources.images;
            this.btnGravaCabaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravaCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravaCabaz.Location = new System.Drawing.Point(366, 16);
            this.btnGravaCabaz.Name = "btnGravaCabaz";
            this.btnGravaCabaz.Size = new System.Drawing.Size(55, 36);
            this.btnGravaCabaz.TabIndex = 111;
            this.btnGravaCabaz.UseVisualStyleBackColor = true;
            this.btnGravaCabaz.Click += new System.EventHandler(this.btnGravaCabaz_Click);
            // 
            // produto
            // 
            this.produto.DataPropertyName = "Produto";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            // 
            // FormInsCabazes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 412);
            this.Controls.Add(this.btnGravaCabaz);
            this.Controls.Add(this.btnGravarProd);
            this.Controls.Add(this.gridInsSaidas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeCabaz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInsCabazes";
            this.Text = "Inserir Produtos no Cabaz";
            this.Load += new System.EventHandler(this.FormInsSaidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInsSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridInsSaidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCabaz;
        private System.Windows.Forms.Button btnGravarProd;
        private System.Windows.Forms.Button btnGravaCabaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}