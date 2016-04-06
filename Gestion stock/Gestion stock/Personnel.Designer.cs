namespace Gestion_stock
{
    partial class Personnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personnel));
            this.ListePersonnel = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListePersonnel
            // 
            this.ListePersonnel.AutoSize = true;
            this.ListePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListePersonnel.Location = new System.Drawing.Point(36, 13);
            this.ListePersonnel.Name = "ListePersonnel";
            this.ListePersonnel.Size = new System.Drawing.Size(235, 31);
            this.ListePersonnel.TabIndex = 0;
            this.ListePersonnel.Text = "Liste du personnel";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(493, 13);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(100, 31);
            this.retour.TabIndex = 1;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 515);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.ListePersonnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personnel";
            this.Text = "Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListePersonnel;
        private System.Windows.Forms.Button retour;
    }
}