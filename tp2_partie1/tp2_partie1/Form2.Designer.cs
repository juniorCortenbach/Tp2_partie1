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
            this.lblModiferNom = new System.Windows.Forms.Label();
            this.txtNomDeck = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouerUneCarte = new System.Windows.Forms.Button();
            this.btnTablaux = new System.Windows.Forms.Button();
            this.lblGestionDeck = new System.Windows.Forms.Label();
            this.btnImages = new System.Windows.Forms.Button();
            this.imgDeck = new System.Windows.Forms.PictureBox();
            this.tblDeck = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cmbCartes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGestionCartes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.Color.Transparent;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(472, 27);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(190, 31);
            this.lblDeck.TabIndex = 0;
            this.lblDeck.Text = "Gérer un Deck";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisisez votre héro :";
            // 
            // cmbHéros
            // 
            this.cmbHéros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHéros.FormattingEnabled = true;
            this.cmbHéros.Location = new System.Drawing.Point(16, 166);
            this.cmbHéros.Name = "cmbHéros";
            this.cmbHéros.Size = new System.Drawing.Size(238, 21);
            this.cmbHéros.TabIndex = 3;
            // 
            // lblModiferNom
            // 
            this.lblModiferNom.AutoSize = true;
            this.lblModiferNom.BackColor = System.Drawing.Color.Transparent;
            this.lblModiferNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModiferNom.ForeColor = System.Drawing.Color.White;
            this.lblModiferNom.Location = new System.Drawing.Point(67, 93);
            this.lblModiferNom.Name = "lblModiferNom";
            this.lblModiferNom.Size = new System.Drawing.Size(138, 20);
            this.lblModiferNom.TabIndex = 4;
            this.lblModiferNom.Text = "Modifier son nom :";
            // 
            // txtNomDeck
            // 
            this.txtNomDeck.Location = new System.Drawing.Point(20, 116);
            this.txtNomDeck.Name = "txtNomDeck";
            this.txtNomDeck.Size = new System.Drawing.Size(238, 20);
            this.txtNomDeck.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(667, 422);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 34);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouerUneCarte
            // 
            this.btnAjouerUneCarte.Location = new System.Drawing.Point(844, 55);
            this.btnAjouerUneCarte.Name = "btnAjouerUneCarte";
            this.btnAjouerUneCarte.Size = new System.Drawing.Size(118, 34);
            this.btnAjouerUneCarte.TabIndex = 7;
            this.btnAjouerUneCarte.Text = "Ajouter une carte";
            this.btnAjouerUneCarte.UseVisualStyleBackColor = true;
            this.btnAjouerUneCarte.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnTablaux
            // 
            this.btnTablaux.Location = new System.Drawing.Point(140, 43);
            this.btnTablaux.Name = "btnTablaux";
            this.btnTablaux.Size = new System.Drawing.Size(118, 34);
            this.btnTablaux.TabIndex = 10;
            this.btnTablaux.Text = "Tabulaire";
            this.btnTablaux.UseVisualStyleBackColor = true;
            this.btnTablaux.Click += new System.EventHandler(this.btnTableaux_Click);
            // 
            // lblGestionDeck
            // 
            this.lblGestionDeck.AutoSize = true;
            this.lblGestionDeck.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionDeck.ForeColor = System.Drawing.Color.White;
            this.lblGestionDeck.Location = new System.Drawing.Point(91, 9);
            this.lblGestionDeck.Name = "lblGestionDeck";
            this.lblGestionDeck.Size = new System.Drawing.Size(106, 20);
            this.lblGestionDeck.TabIndex = 9;
            this.lblGestionDeck.Text = "Gestion Deck";
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
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(968, 55);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(118, 34);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Enlever une carte";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmbCartes
            // 
            this.cmbCartes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCartes.FormattingEnabled = true;
            this.cmbCartes.Location = new System.Drawing.Point(844, 128);
            this.cmbCartes.Name = "cmbCartes";
            this.cmbCartes.Size = new System.Drawing.Size(238, 21);
            this.cmbCartes.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(891, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choisisez votre cartes :";
            // 
            // lblGestionCartes
            // 
            this.lblGestionCartes.AutoSize = true;
            this.lblGestionCartes.BackColor = System.Drawing.Color.Transparent;
            this.lblGestionCartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCartes.ForeColor = System.Drawing.Color.White;
            this.lblGestionCartes.Location = new System.Drawing.Point(921, 18);
            this.lblGestionCartes.Name = "lblGestionCartes";
            this.lblGestionCartes.Size = new System.Drawing.Size(113, 20);
            this.lblGestionCartes.TabIndex = 16;
            this.lblGestionCartes.Text = "Gestion cartes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tp2_partie1.Properties.Resources.FondDuFormulaire1;
            this.ClientSize = new System.Drawing.Size(1103, 532);
            this.Controls.Add(this.lblGestionCartes);
            this.Controls.Add(this.cmbCartes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.imgDeck);
            this.Controls.Add(this.tblDeck);
            this.Controls.Add(this.btnTablaux);
            this.Controls.Add(this.lblGestionDeck);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnAjouerUneCarte);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtNomDeck);
            this.Controls.Add(this.lblModiferNom);
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
        private System.Windows.Forms.Label lblModiferNom;
        private System.Windows.Forms.TextBox txtNomDeck;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouerUneCarte;
        private System.Windows.Forms.Button btnTablaux;
        private System.Windows.Forms.Label lblGestionDeck;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.PictureBox imgDeck;
        private System.Windows.Forms.DataGridView tblDeck;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cmbCartes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGestionCartes;
    }
}