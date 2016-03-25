namespace tp2_partie1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tblCarte = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imgCartes = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDeck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCartes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCarte
            // 
            this.tblCarte.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblCarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCarte.Location = new System.Drawing.Point(323, 71);
            this.tblCarte.Name = "tblCarte";
            this.tblCarte.Size = new System.Drawing.Size(450, 340);
            this.tblCarte.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.BackColor = System.Drawing.Color.Transparent;
            this.lblAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.ForeColor = System.Drawing.Color.White;
            this.lblAffichage.Location = new System.Drawing.Point(98, 12);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(77, 20);
            this.lblAffichage.TabIndex = 2;
            this.lblAffichage.Text = "Affichage";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tabulaire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgCartes
            // 
            this.imgCartes.Location = new System.Drawing.Point(323, 71);
            this.imgCartes.Name = "imgCartes";
            this.imgCartes.Size = new System.Drawing.Size(450, 340);
            this.imgCartes.TabIndex = 4;
            this.imgCartes.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Charger";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion des decks";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.Color.Transparent;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(430, 24);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(203, 31);
            this.lblDeck.TabIndex = 8;
            this.lblDeck.Text = "Jeu HeartStone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 532);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.imgCartes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblCarte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCartes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCarte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imgCartes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDeck;
    }
}

