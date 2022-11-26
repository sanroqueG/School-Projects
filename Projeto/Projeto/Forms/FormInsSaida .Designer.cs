namespace Projeto.Forms
{
    partial class FormInsSaida
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
            this.cmbCabaz = new System.Windows.Forms.ComboBox();
            this.cmbRecetor = new System.Windows.Forms.ComboBox();
            this.txtEstafeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridSaidas = new System.Windows.Forms.DataGridView();
            this.btnGravaCabaz = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCabaz
            // 
            this.cmbCabaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCabaz.FormattingEnabled = true;
            this.cmbCabaz.Location = new System.Drawing.Point(84, 11);
            this.cmbCabaz.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCabaz.Name = "cmbCabaz";
            this.cmbCabaz.Size = new System.Drawing.Size(156, 28);
            this.cmbCabaz.TabIndex = 84;
            // 
            // cmbRecetor
            // 
            this.cmbRecetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecetor.FormattingEnabled = true;
            this.cmbRecetor.Location = new System.Drawing.Point(347, 11);
            this.cmbRecetor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRecetor.Name = "cmbRecetor";
            this.cmbRecetor.Size = new System.Drawing.Size(185, 28);
            this.cmbRecetor.TabIndex = 83;
            // 
            // txtEstafeta
            // 
            this.txtEstafeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstafeta.Location = new System.Drawing.Point(101, 63);
            this.txtEstafeta.Name = "txtEstafeta";
            this.txtEstafeta.Size = new System.Drawing.Size(222, 26);
            this.txtEstafeta.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Cabaz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Recetor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Estafeta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Data Receção:";
            // 
            // gridSaidas
            // 
            this.gridSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaidas.Location = new System.Drawing.Point(16, 107);
            this.gridSaidas.Name = "gridSaidas";
            this.gridSaidas.Size = new System.Drawing.Size(813, 321);
            this.gridSaidas.TabIndex = 97;
            // 
            // btnGravaCabaz
            // 
            this.btnGravaCabaz.BackgroundImage = global::Projeto.Properties.Resources.images;
            this.btnGravaCabaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravaCabaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravaCabaz.Location = new System.Drawing.Point(774, 53);
            this.btnGravaCabaz.Name = "btnGravaCabaz";
            this.btnGravaCabaz.Size = new System.Drawing.Size(55, 36);
            this.btnGravaCabaz.TabIndex = 112;
            this.btnGravaCabaz.UseVisualStyleBackColor = true;
            this.btnGravaCabaz.Click += new System.EventHandler(this.btnGravaCabaz_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(696, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker.TabIndex = 113;
            this.dateTimePicker.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            // 
            // FormInsSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 440);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnGravaCabaz);
            this.Controls.Add(this.gridSaidas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstafeta);
            this.Controls.Add(this.cmbCabaz);
            this.Controls.Add(this.cmbRecetor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInsSaida";
            this.Text = "Inserir Saída";
            this.Load += new System.EventHandler(this.FormSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCabaz;
        private System.Windows.Forms.ComboBox cmbRecetor;
        private System.Windows.Forms.TextBox txtEstafeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridSaidas;
        private System.Windows.Forms.Button btnGravaCabaz;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}