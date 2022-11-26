namespace Projeto.Forms
{
    partial class FormLocalidades
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
            this.gridLocais = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.id_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLocais
            // 
            this.gridLocais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocais.ColumnHeadersVisible = false;
            this.gridLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_local,
            this.designacao});
            this.gridLocais.Location = new System.Drawing.Point(12, 12);
            this.gridLocais.Name = "gridLocais";
            this.gridLocais.RowHeadersVisible = false;
            this.gridLocais.RowHeadersWidth = 51;
            this.gridLocais.Size = new System.Drawing.Size(210, 251);
            this.gridLocais.TabIndex = 112;
            this.gridLocais.SelectionChanged += new System.EventHandler(this.gridLocais_SelectionChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(433, 121);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizar.TabIndex = 118;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Localidade:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Enabled = false;
            this.txtLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidade.Location = new System.Drawing.Point(363, 77);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(211, 26);
            this.txtLocalidade.TabIndex = 113;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(277, 177);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(140, 40);
            this.btnGravar.TabIndex = 115;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(433, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 116;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(277, 121);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 114;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Código Postal:";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Enabled = false;
            this.txtCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPostal.Location = new System.Drawing.Point(363, 43);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(211, 26);
            this.txtCodPostal.TabIndex = 119;
            // 
            // id_local
            // 
            this.id_local.DataPropertyName = "CodLocal";
            this.id_local.HeaderText = "ID";
            this.id_local.Name = "id_local";
            this.id_local.ReadOnly = true;
            // 
            // designacao
            // 
            this.designacao.DataPropertyName = "Localidade";
            this.designacao.HeaderText = "Designação";
            this.designacao.Name = "designacao";
            this.designacao.ReadOnly = true;
            // 
            // FormLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.gridLocais);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLocalidades";
            this.Load += new System.EventHandler(this.FormLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLocais;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn designacao;
    }
}