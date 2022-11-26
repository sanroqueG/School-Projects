namespace Projeto
{
    partial class FormCatDadores
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
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridCat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(182, 315);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 36);
            this.btnAtualizar.TabIndex = 104;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nome: ";
            // 
            // txtCat
            // 
            this.txtCat.Enabled = false;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(78, 276);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(262, 26);
            this.txtCat.TabIndex = 99;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(86, 357);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(90, 36);
            this.btnGravar.TabIndex = 101;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(182, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 36);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(86, 315);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 100;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCat);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 258);
            this.panel1.TabIndex = 98;
            // 
            // gridCat
            // 
            this.gridCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCat.Location = new System.Drawing.Point(3, 3);
            this.gridCat.Name = "gridCat";
            this.gridCat.RowHeadersWidth = 51;
            this.gridCat.Size = new System.Drawing.Size(325, 251);
            this.gridCat.TabIndex = 0;
            this.gridCat.SelectionChanged += new System.EventHandler(this.gridCat_SelectionChanged);
            // 
            // FormCatDadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 405);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Name = "FormCatDadores";
            this.Text = "FormCatDadores";
            this.Load += new System.EventHandler(this.FormCatDadores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridCat;
    }
}