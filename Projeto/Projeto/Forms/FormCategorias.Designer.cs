namespace Projeto
{
    partial class FormCategorias
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(198, 155);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizar.TabIndex = 104;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nome: ";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(263, 33);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(227, 26);
            this.txtCategoria.TabIndex = 99;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(352, 98);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(140, 40);
            this.btnGravar.TabIndex = 101;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(352, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(198, 98);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 100;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCategorias);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 258);
            this.panel1.TabIndex = 98;
            // 
            // gridCategorias
            // 
            this.gridCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategoria,
            this.Descricao});
            this.gridCategorias.Location = new System.Drawing.Point(3, 7);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.RowHeadersVisible = false;
            this.gridCategorias.RowHeadersWidth = 51;
            this.gridCategorias.Size = new System.Drawing.Size(160, 251);
            this.gridCategorias.TabIndex = 0;
            this.gridCategorias.SelectionChanged += new System.EventHandler(this.gridCategorias_SelectionChanged);
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "IdCategoria";
            this.IdCategoria.HeaderText = "ID";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Designação";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 277);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}