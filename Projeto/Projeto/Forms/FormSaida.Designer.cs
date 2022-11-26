namespace Projeto.Forms
{
    partial class FormSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gridSaidas = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.designacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estafeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(288, 23);
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
            this.rdbData.Location = new System.Drawing.Point(381, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(644, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(467, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(171, 26);
            this.txtPesquisa.TabIndex = 100;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // gridSaidas
            // 
            this.gridSaidas.AllowUserToDeleteRows = false;
            this.gridSaidas.AllowUserToResizeColumns = false;
            this.gridSaidas.AllowUserToResizeRows = false;
            this.gridSaidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSaidas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSaidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSaidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSaidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designacao,
            this.recetor,
            this.estafeta,
            this.data,
            this.eliminar});
            this.gridSaidas.Location = new System.Drawing.Point(180, 73);
            this.gridSaidas.Name = "gridSaidas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSaidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSaidas.RowHeadersWidth = 51;
            this.gridSaidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridSaidas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSaidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSaidas.Size = new System.Drawing.Size(498, 392);
            this.gridSaidas.TabIndex = 98;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(175, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 99;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // designacao
            // 
            this.designacao.DataPropertyName = "Designacao";
            this.designacao.HeaderText = "Designação";
            this.designacao.Name = "designacao";
            this.designacao.ReadOnly = true;
            this.designacao.Width = 108;
            // 
            // recetor
            // 
            this.recetor.DataPropertyName = "Recetor";
            this.recetor.HeaderText = "Recetor";
            this.recetor.Name = "recetor";
            this.recetor.ReadOnly = true;
            this.recetor.Width = 83;
            // 
            // estafeta
            // 
            this.estafeta.DataPropertyName = "Estafeta";
            this.estafeta.HeaderText = "Estafeta";
            this.estafeta.Name = "estafeta";
            this.estafeta.ReadOnly = true;
            this.estafeta.Width = 85;
            // 
            // data
            // 
            this.data.DataPropertyName = "DataRececao";
            this.data.HeaderText = "Data Receção";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 113;
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
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            this.eliminar.Width = 64;
            // 
            // FormSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridSaidas);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormSaida";
            this.Text = "Saídas";
            this.Load += new System.EventHandler(this.FormSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView gridSaidas;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn designacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estafeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}