namespace Projeto.Forms
{
    partial class FormMarcas
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gridMarcas = new System.Windows.Forms.DataGridView();
            this.CodMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(194, 159);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizar.TabIndex = 97;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "Nome: ";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(260, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(230, 26);
            this.txtMarca.TabIndex = 89;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(350, 104);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(140, 40);
            this.btnGravar.TabIndex = 92;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(350, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 93;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(194, 104);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 91;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // gridMarcas
            // 
            this.gridMarcas.AllowUserToAddRows = false;
            this.gridMarcas.AllowUserToDeleteRows = false;
            this.gridMarcas.AllowUserToResizeColumns = false;
            this.gridMarcas.AllowUserToResizeRows = false;
            this.gridMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMarca,
            this.Descricao});
            this.gridMarcas.Location = new System.Drawing.Point(3, 3);
            this.gridMarcas.Name = "gridMarcas";
            this.gridMarcas.ReadOnly = true;
            this.gridMarcas.RowHeadersVisible = false;
            this.gridMarcas.RowHeadersWidth = 51;
            this.gridMarcas.Size = new System.Drawing.Size(160, 251);
            this.gridMarcas.TabIndex = 0;
            this.gridMarcas.SelectionChanged += new System.EventHandler(this.gridMarcas_SelectionChanged_1);
            // 
            // CodMarca
            // 
            this.CodMarca.DataPropertyName = "CodMarca";
            this.CodMarca.HeaderText = "ID";
            this.CodMarca.Name = "CodMarca";
            this.CodMarca.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Designação";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridMarcas);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 258);
            this.panel1.TabIndex = 88;
            // 
            // FormMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 277);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMarcas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMarcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gridMarcas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}