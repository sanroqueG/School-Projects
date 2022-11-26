namespace Projeto.Forms
{
    partial class FormTurma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.gridTurmas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "Turma:";
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(481, 45);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(203, 26);
            this.txtTurma.TabIndex = 128;
            // 
            // gridTurmas
            // 
            this.gridTurmas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao});
            this.gridTurmas.Location = new System.Drawing.Point(12, 12);
            this.gridTurmas.Name = "gridTurmas";
            this.gridTurmas.RowHeadersVisible = false;
            this.gridTurmas.RowHeadersWidth = 51;
            this.gridTurmas.Size = new System.Drawing.Size(324, 251);
            this.gridTurmas.TabIndex = 121;
            this.gridTurmas.SelectionChanged += new System.EventHandler(this.gridTurmas_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "IdTurma";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Designação";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(543, 123);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(140, 40);
            this.btnAtualizar.TabIndex = 127;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 126;
            this.label6.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(481, 79);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(203, 26);
            this.txtDesc.TabIndex = 122;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(386, 182);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(140, 40);
            this.btnGravar.TabIndex = 124;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(543, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 125;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(386, 123);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(140, 40);
            this.btnNovo.TabIndex = 123;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.gridTurmas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormTurma";
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.FormTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.DataGridView gridTurmas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}