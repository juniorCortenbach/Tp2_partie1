namespace tp2_partie1
{
    partial class Form2
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
            this.lblDeck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHéros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomDeck = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(280, 28);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(295, 31);
            this.lblDeck.TabIndex = 0;
            this.lblDeck.Text = "Créer un nouveau deck";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisisez votre héro :";
            // 
            // cmbHéros
            // 
            this.cmbHéros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHéros.FormattingEnabled = true;
            this.cmbHéros.Location = new System.Drawing.Point(35, 169);
            this.cmbHéros.Name = "cmbHéros";
            this.cmbHéros.Size = new System.Drawing.Size(314, 21);
            this.cmbHéros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donnée un nom au deck :";
            // 
            // txtNomDeck
            // 
            this.txtNomDeck.Location = new System.Drawing.Point(179, 99);
            this.txtNomDeck.Name = "txtNomDeck";
            this.txtNomDeck.Size = new System.Drawing.Size(170, 20);
            this.txtNomDeck.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(35, 288);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(154, 36);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(35, 235);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(154, 36);
            this.btnCharger.TabIndex = 7;
            this.btnCharger.Text = "Charger un deck";
            this.btnCharger.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tabulaire";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.Location = new System.Drawing.Point(528, 90);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(77, 20);
            this.lblAffichage.TabIndex = 9;
            this.lblAffichage.Text = "Affichage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Images";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(490, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 185);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(221, 185);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtNomDeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHéros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeck);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHéros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomDeck;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}