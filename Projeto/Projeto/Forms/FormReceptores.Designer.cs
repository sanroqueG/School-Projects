
namespace Projeto.Forms
{
    partial class FormReceptores
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gridRecetor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtEE = new System.Windows.Forms.TextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnInsTurma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecetor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Projeto.Properties.Resources.cancel;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(724, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 36);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources._2861870;
            this.pictureBox1.Location = new System.Drawing.Point(798, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(564, 17);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(228, 26);
            this.txtPesquisa.TabIndex = 106;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // gridRecetor
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecetor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRecetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecetor.Location = new System.Drawing.Point(14, 133);
            this.gridRecetor.Name = "gridRecetor";
            this.gridRecetor.RowHeadersWidth = 51;
            this.gridRecetor.Size = new System.Drawing.Size(821, 273);
            this.gridRecetor.TabIndex = 93;
            this.gridRecetor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRecetor_CellClick);
            this.gridRecetor.SelectionChanged += new System.EventHandler(this.gridRecetor_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Turma:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Enabled = false;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(518, 53);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 20);
            this.lblStock.TabIndex = 102;
            this.lblStock.Text = "EE:";
            // 
            // txtEE
            // 
            this.txtEE.Enabled = false;
            this.txtEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEE.Location = new System.Drawing.Point(559, 49);
            this.txtEE.Name = "txtEE";
            this.txtEE.Size = new System.Drawing.Size(276, 26);
            this.txtEE.TabIndex = 101;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.Enabled = false;
            this.cmbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(357, 48);
            this.cmbTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(117, 28);
            this.cmbTurma.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(69, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 26);
            this.txtNome.TabIndex = 94;
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Projeto.Properties.Resources.save_icon_3;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(780, 81);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(55, 36);
            this.btnGravar.TabIndex = 97;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 36);
            this.btnNovo.TabIndex = 96;
            this.btnNovo.Text = "Inserir";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnInsTurma
            // 
            this.btnInsTurma.BackgroundImage = global::Projeto.Properties.Resources._32782241;
            this.btnInsTurma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsTurma.Enabled = false;
            this.btnInsTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsTurma.Location = new System.Drawing.Point(479, 47);
            this.btnInsTurma.Name = "btnInsTurma";
            this.btnInsTurma.Size = new System.Drawing.Size(30, 28);
            this.btnInsTurma.TabIndex = 109;
            this.btnInsTurma.UseVisualStyleBackColor = true;
            this.btnInsTurma.Click += new System.EventHandler(this.btnInsTurma_Click);
            // 
            // FormReceptores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 424);
            this.Controls.Add(this.btnInsTurma);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridRecetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtEE);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Name = "FormReceptores";
            this.Text = "Receptores";
            this.Load += new System.EventHandler(this.FormReceptores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecetor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView gridRecetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtEE;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnInsTurma;
    }
}