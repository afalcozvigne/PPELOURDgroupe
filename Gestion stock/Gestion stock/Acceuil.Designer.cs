namespace Gestion_stock
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.Personalisation = new System.Windows.Forms.Button();
            this.newaccount = new System.Windows.Forms.Button();
            this.gestion = new System.Windows.Forms.Button();
            this.ListePerso = new System.Windows.Forms.Button();
            this.WavAttittude = new System.Windows.Forms.Label();
            this.compte = new System.Windows.Forms.Label();
            this.connexionLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Personalisation
            // 
            this.Personalisation.Location = new System.Drawing.Point(13, 309);
            this.Personalisation.Name = "Personalisation";
            this.Personalisation.Size = new System.Drawing.Size(465, 69);
            this.Personalisation.TabIndex = 0;
            this.Personalisation.Text = "Personalisation";
            this.Personalisation.UseVisualStyleBackColor = true;
            // 
            // newaccount
            // 
            this.newaccount.Location = new System.Drawing.Point(327, 400);
            this.newaccount.Name = "newaccount";
            this.newaccount.Size = new System.Drawing.Size(151, 69);
            this.newaccount.TabIndex = 1;
            this.newaccount.Text = "Nouveaux compte";
            this.newaccount.UseVisualStyleBackColor = true;
            // 
            // gestion
            // 
            this.gestion.Location = new System.Drawing.Point(170, 400);
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(151, 69);
            this.gestion.TabIndex = 2;
            this.gestion.Text = "Gestion de stock";
            this.gestion.UseVisualStyleBackColor = true;
            // 
            // ListePerso
            // 
            this.ListePerso.Location = new System.Drawing.Point(13, 400);
            this.ListePerso.Name = "ListePerso";
            this.ListePerso.Size = new System.Drawing.Size(151, 69);
            this.ListePerso.TabIndex = 3;
            this.ListePerso.Text = "Liste du personnel";
            this.ListePerso.UseVisualStyleBackColor = true;
            // 
            // WavAttittude
            // 
            this.WavAttittude.AutoSize = true;
            this.WavAttittude.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WavAttittude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WavAttittude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WavAttittude.Location = new System.Drawing.Point(117, 237);
            this.WavAttittude.MaximumSize = new System.Drawing.Size(300, 300);
            this.WavAttittude.Name = "WavAttittude";
            this.WavAttittude.Size = new System.Drawing.Size(272, 25);
            this.WavAttittude.TabIndex = 4;
            this.WavAttittude.Text = "Bienvenue sur WavAttitude";
            // 
            // compte
            // 
            this.compte.AutoSize = true;
            this.compte.Location = new System.Drawing.Point(324, 153);
            this.compte.Name = "compte";
            this.compte.Size = new System.Drawing.Size(93, 13);
            this.compte.TabIndex = 5;
            this.compte.Text = "compte connecter";
            // 
            // connexionLabel
            // 
            this.connexionLabel.AutoSize = true;
            this.connexionLabel.Location = new System.Drawing.Point(441, 153);
            this.connexionLabel.Name = "connexionLabel";
            this.connexionLabel.Size = new System.Drawing.Size(56, 13);
            this.connexionLabel.TabIndex = 6;
            this.connexionLabel.TabStop = true;
            this.connexionLabel.Text = "connexion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 139);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.connexionLabel);
            this.Controls.Add(this.compte);
            this.Controls.Add(this.WavAttittude);
            this.Controls.Add(this.ListePerso);
            this.Controls.Add(this.gestion);
            this.Controls.Add(this.newaccount);
            this.Controls.Add(this.Personalisation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Personalisation;
        private System.Windows.Forms.Button newaccount;
        private System.Windows.Forms.Button gestion;
        private System.Windows.Forms.Button ListePerso;
        private System.Windows.Forms.Label WavAttittude;
        private System.Windows.Forms.Label compte;
        private System.Windows.Forms.LinkLabel connexionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}