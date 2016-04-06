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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Location = new System.Drawing.Point(16, 28);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(52, 13);
            this.labelAcc.TabIndex = 0;
            this.labelAcc.Text = "ACCEUIL";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 4;
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
            // 
            // formAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 333);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

