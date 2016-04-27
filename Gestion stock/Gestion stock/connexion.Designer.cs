namespace Gestion_stock
{
    partial class formAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAcc));
            this.labelAcc = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.logintext = new System.Windows.Forms.TextBox();
            this.mdptext = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Location = new System.Drawing.Point(16, 28);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(52, 13);
            this.labelAcc.TabIndex = 0;
            this.labelAcc.Text = "ACCUEIL";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(121, 104);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(121, 176);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(74, 13);
            this.mdp.TabIndex = 2;
            this.mdp.Text = "Mot De Passe";
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(151, 120);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(155, 20);
            this.logintext.TabIndex = 3;
            this.logintext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logintext_KeyPress);
            // 
            // mdptext
            // 
            this.mdptext.Location = new System.Drawing.Point(151, 192);
            this.mdptext.Name = "mdptext";
            this.mdptext.Size = new System.Drawing.Size(155, 20);
            this.mdptext.TabIndex = 4;
            this.mdptext.UseSystemPasswordChar = true;
            this.mdptext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mdptext_KeyPress);
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.SystemColors.Highlight;
            this.valider.Location = new System.Drawing.Point(151, 236);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(185, 35);
            this.valider.TabIndex = 5;
            this.valider.Text = "Connexion";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "nouveaux compte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.mdptext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.labelAcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAcc";
            this.Text = "Acceuil connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.TextBox mdptext;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.Button button1;
    }
}

