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
            this.btnTablaux = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.btnImages = new System.Windows.Forms.Button();
            this.imgDeck = new System.Windows.Forms.PictureBox();
            this.tblDeck = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.Color.Transparent;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(399, 28);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(295, 31);
            this.lblDeck.TabIndex = 0;
            this.lblDeck.Text = "Créer un nouveau deck";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisisez votre héro :";
            // 
            // cmbHéros
            // 
            this.cmbHéros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHéros.FormattingEnabled = true;
            this.cmbHéros.Location = new System.Drawing.Point(20, 233);
            this.cmbHéros.Name = "cmbHéros";
            this.cmbHéros.Size = new System.Drawing.Size(238, 21);
            this.cmbHéros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donnée un nom au deck :";
            // 
            // txtNomDeck
            // 
            this.txtNomDeck.Location = new System.Drawing.Point(20, 116);
            this.txtNomDeck.Name = "txtNomDeck";
            this.txtNomDeck.Size = new System.Drawing.Size(170, 20);
            this.txtNomDeck.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(140, 152);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 34);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(16, 152);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(118, 34);
            this.btnCharger.TabIndex = 7;
            this.btnCharger.Text = "Charger un deck";
            this.btnCharger.UseVisualStyleBackColor = true;
            // 
            // btnTablaux
            // 
            this.btnTablaux.Location = new System.Drawing.Point(140, 43);
            this.btnTablaux.Name = "btnTablaux";
            this.btnTablaux.Size = new System.Drawing.Size(118, 34);
            this.btnTablaux.TabIndex = 10;
            this.btnTablaux.Text = "Tabulaire";
            this.btnTablaux.UseVisualStyleBackColor = true;
            this.btnTablaux.Click += new System.EventHandler(this.btnTablaux_Click);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.BackColor = System.Drawing.Color.Transparent;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.ForeColor = System.Drawing.Color.White;
            this.lblAffichage.Location = new System.Drawing.Point(16, 13);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(77, 20);
            this.lblAffichage.TabIndex = 9;
            this.lblAffichage.Text = "Affichage";
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(16, 43);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(118, 34);
            this.btnImages.TabIndex = 8;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // imgDeck
            // 
            this.imgDeck.Location = new System.Drawing.Point(335, 76);
            this.imgDeck.Name = "imgDeck";
            this.imgDeck.Size = new System.Drawing.Size(450, 340);
            this.imgDeck.TabIndex = 12;
            this.imgDeck.TabStop = false;
            // 
            // tblDeck
            // 
            this.tblDeck.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblDeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDeck.Location = new System.Drawing.Point(335, 76);
            this.tblDeck.Name = "tblDeck";
            this.tblDeck.Size = new System.Drawing.Size(450, 340);
            this.tblDeck.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tp2_partie1.Properties.Resources.FondDuFormulaire1;
            this.ClientSize = new System.Drawing.Size(974, 532);
            this.Controls.Add(this.imgDeck);
            this.Controls.Add(this.tblDeck);
            this.Controls.Add(this.btnTablaux);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtNomDeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHéros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeck);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeck)).EndInit();
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
        private System.Windows.Forms.Button btnTablaux;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.PictureBox imgDeck;
        private System.Windows.Forms.DataGridView tblDeck;
    }
}