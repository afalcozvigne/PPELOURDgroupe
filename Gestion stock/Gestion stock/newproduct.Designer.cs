namespace Gestion_stock
{
    partial class newproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newproduct));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.qteqtock = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.Famille = new System.Windows.Forms.Label();
            this.Ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 136);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(142, 20);
            this.textBox.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Labelle Produit";
            // 
            // qteqtock
            // 
            this.qteqtock.AutoSize = true;
            this.qteqtock.Location = new System.Drawing.Point(12, 120);
            this.qteqtock.Name = "qteqtock";
            this.qteqtock.Size = new System.Drawing.Size(85, 13);
            this.qteqtock.TabIndex = 6;
            this.qteqtock.Text = "Quantite stocker";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Location = new System.Drawing.Point(12, 179);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(70, 13);
            this.prix.TabIndex = 7;
            this.prix.Text = "Prix de Vente";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(12, 241);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 8;
            this.description.Text = "Description";
            // 
            // Famille
            // 
            this.Famille.AutoSize = true;
            this.Famille.Location = new System.Drawing.Point(12, 299);
            this.Famille.Name = "Famille";
            this.Famille.Size = new System.Drawing.Size(75, 13);
            this.Famille.TabIndex = 9;
            this.Famille.Text = "Famille Produit";
            // 
            // Ajout
            // 
            this.Ajout.Location = new System.Drawing.Point(179, 315);
            this.Ajout.Name = "Ajout";
            this.Ajout.Size = new System.Drawing.Size(75, 23);
            this.Ajout.TabIndex = 10;
            this.Ajout.Text = "Valider";
            this.Ajout.UseVisualStyleBackColor = true;
            this.Ajout.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // newproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 347);
            this.Controls.Add(this.Ajout);
            this.Controls.Add(this.Famille);
            this.Controls.Add(this.description);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.qteqtock);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newproduct";
            this.Text = "newproduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label qteqtock;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label Famille;
        private System.Windows.Forms.Button Ajout;
    }
}