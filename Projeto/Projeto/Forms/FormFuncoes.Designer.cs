namespace Projeto.Forms
{
    partial class FormFuncoes
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
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridFuncao = new System.Windows.Forms.DataGridView();
            this.CodMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPerms = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(228, 167);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizar.TabIndex = 111;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "Designação:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Enabled = false;
            this.txtFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(310, 43);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(230, 26);
            this.txtFuncao.TabIndex = 106;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(384, 112);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(140, 40);
            this.btnGravar.TabIndex = 108;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(384, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 109;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(228, 112);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 107;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridFuncao);
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 258);
            this.panel1.TabIndex = 105;
            // 
            // gridFuncao
            // 
            this.gridFuncao.AllowUserToAddRows = false;
            this.gridFuncao.AllowUserToDeleteRows = false;
            this.gridFuncao.AllowUserToResizeColumns = false;
            this.gridFuncao.AllowUserToResizeRows = false;
            this.gridFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMarca,
            this.Descricao});
            this.gridFuncao.Location = new System.Drawing.Point(3, 3);
            this.gridFuncao.Name = "gridFuncao";
            this.gridFuncao.ReadOnly = true;
            this.gridFuncao.RowHeadersVisible = false;
            this.gridFuncao.RowHeadersWidth = 51;
            this.gridFuncao.Size = new System.Drawing.Size(150, 251);
            this.gridFuncao.TabIndex = 0;
            this.gridFuncao.SelectionChanged += new System.EventHandler(this.gridFuncao_SelectionChanged);
            // 
            // CodMarca
            // 
            this.CodMarca.DataPropertyName = "CodFuncao";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nivel de Permissão:";
            // 
            // cbPerms
            // 
            this.cbPerms.FormattingEnabled = true;
            this.cbPerms.Location = new System.Drawing.Point(358, 80);
            this.cbPerms.Name = "cbPerms";
            this.cbPerms.Size = new System.Drawing.Size(157, 21);
            this.cbPerms.TabIndex = 114;
            // 
            // FormFuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 322);
            this.Controls.Add(this.cbPerms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Name = "FormFuncoes";
            this.Text = "FormFuncoes";
            this.Load += new System.EventHandler(this.FormFuncoes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridFuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPerms;
    }
}