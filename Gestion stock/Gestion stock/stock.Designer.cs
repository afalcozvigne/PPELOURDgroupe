namespace Gestion_stock
{
    partial class stock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelleproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtestockproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventeproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleproduitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Addproduct = new System.Windows.Forms.Button();
            this.CmdEnt = new System.Windows.Forms.Button();
            this.Vente = new System.Windows.Forms.Button();
            this.buttonretoure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitsDataGridViewTextBoxColumn,
            this.labelleproduitsDataGridViewTextBoxColumn,
            this.qtestockproduitsDataGridViewTextBoxColumn,
            this.prixventeproduitsDataGridViewTextBoxColumn,
            this.descriptionproduitsDataGridViewTextBoxColumn,
            this.familleproduitsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 377);
            this.dataGridView1.TabIndex = 1;
            // 
            // idproduitsDataGridViewTextBoxColumn
            // 
            this.idproduitsDataGridViewTextBoxColumn.DataPropertyName = "id_produits";
            this.idproduitsDataGridViewTextBoxColumn.HeaderText = "id_produits";
            this.idproduitsDataGridViewTextBoxColumn.Name = "idproduitsDataGridViewTextBoxColumn";
            this.idproduitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labelleproduitsDataGridViewTextBoxColumn
            // 
            this.labelleproduitsDataGridViewTextBoxColumn.DataPropertyName = "labelle_produits";
            this.labelleproduitsDataGridViewTextBoxColumn.HeaderText = "labelle_produits";
            this.labelleproduitsDataGridViewTextBoxColumn.Name = "labelleproduitsDataGridViewTextBoxColumn";
            // 
            // qtestockproduitsDataGridViewTextBoxColumn
            // 
            this.qtestockproduitsDataGridViewTextBoxColumn.DataPropertyName = "qtestock_produits";
            this.qtestockproduitsDataGridViewTextBoxColumn.HeaderText = "qtestock_produits";
            this.qtestockproduitsDataGridViewTextBoxColumn.Name = "qtestockproduitsDataGridViewTextBoxColumn";
            // 
            // prixventeproduitsDataGridViewTextBoxColumn
            // 
            this.prixventeproduitsDataGridViewTextBoxColumn.DataPropertyName = "prixvente_produits";
            this.prixventeproduitsDataGridViewTextBoxColumn.HeaderText = "prixvente_produits";
            this.prixventeproduitsDataGridViewTextBoxColumn.Name = "prixventeproduitsDataGridViewTextBoxColumn";
            // 
            // descriptionproduitsDataGridViewTextBoxColumn
            // 
            this.descriptionproduitsDataGridViewTextBoxColumn.DataPropertyName = "description_produits";
            this.descriptionproduitsDataGridViewTextBoxColumn.HeaderText = "description_produits";
            this.descriptionproduitsDataGridViewTextBoxColumn.Name = "descriptionproduitsDataGridViewTextBoxColumn";
            // 
            // familleproduitsDataGridViewTextBoxColumn
            // 
            this.familleproduitsDataGridViewTextBoxColumn.DataPropertyName = "famille_produits";
            this.familleproduitsDataGridViewTextBoxColumn.HeaderText = "famille_produits";
            this.familleproduitsDataGridViewTextBoxColumn.Name = "familleproduitsDataGridViewTextBoxColumn";
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "Produits";
            this.produitsBindingSource.DataSource = this.gestionStockDataSet;
            // 
            // gestionStockDataSet
            // 
            this.gestionStockDataSet.DataSetName = "GestionStockDataSet";
            this.gestionStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // Addproduct
            // 
            this.Addproduct.Location = new System.Drawing.Point(689, 367);
            this.Addproduct.Name = "Addproduct";
            this.Addproduct.Size = new System.Drawing.Size(189, 56);
            this.Addproduct.TabIndex = 2;
            this.Addproduct.Text = "Ajouter un produit";
            this.Addproduct.UseVisualStyleBackColor = true;
            this.Addproduct.Click += new System.EventHandler(this.Addproduct_Click);
            // 
            // CmdEnt
            // 
            this.CmdEnt.Location = new System.Drawing.Point(689, 293);
            this.CmdEnt.Name = "CmdEnt";
            this.CmdEnt.Size = new System.Drawing.Size(189, 56);
            this.CmdEnt.TabIndex = 3;
            this.CmdEnt.Text = "Commande";
            this.CmdEnt.UseVisualStyleBackColor = true;
            // 
            // Vente
            // 
            this.Vente.Location = new System.Drawing.Point(689, 218);
            this.Vente.Name = "Vente";
            this.Vente.Size = new System.Drawing.Size(189, 56);
            this.Vente.TabIndex = 4;
            this.Vente.Text = "Vente";
            this.Vente.UseVisualStyleBackColor = true;
            // 
            // buttonretoure
            // 
            this.buttonretoure.Location = new System.Drawing.Point(802, 13);
            this.buttonretoure.Name = "buttonretoure";
            this.buttonretoure.Size = new System.Drawing.Size(75, 23);
            this.buttonretoure.TabIndex = 5;
            this.buttonretoure.Text = "retour";
            this.buttonretoure.UseVisualStyleBackColor = true;
            this.buttonretoure.Click += new System.EventHandler(this.buttonretoure_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 434);
            this.Controls.Add(this.buttonretoure);
            this.Controls.Add(this.Vente);
            this.Controls.Add(this.CmdEnt);
            this.Controls.Add(this.Addproduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelleproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtestockproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventeproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleproduitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Addproduct;
        private System.Windows.Forms.Button CmdEnt;
        private System.Windows.Forms.Button Vente;
        private System.Windows.Forms.Button buttonretoure;
    }
}