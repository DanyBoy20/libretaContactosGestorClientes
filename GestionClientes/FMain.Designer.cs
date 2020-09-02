namespace GestionClientes
{
    partial class FMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstCustomers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblTotalCustomers = new System.Windows.Forms.Label();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstCustomers
            // 
            this.LstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLastName,
            this.colAddress,
            this.colCreateDate});
            this.LstCustomers.FullRowSelect = true;
            this.LstCustomers.HideSelection = false;
            this.LstCustomers.Location = new System.Drawing.Point(12, 137);
            this.LstCustomers.Name = "LstCustomers";
            this.LstCustomers.Size = new System.Drawing.Size(665, 323);
            this.LstCustomers.TabIndex = 1;
            this.LstCustomers.UseCompatibleStateImageBehavior = false;
            this.LstCustomers.View = System.Windows.Forms.View.Details;
            this.LstCustomers.DoubleClick += new System.EventHandler(this.LstCustomers_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 140;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Apellidos";
            this.colLastName.Width = 169;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Dirección";
            this.colAddress.Width = 195;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Text = "Fecha de creación";
            this.colCreateDate.Width = 109;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(12, 108);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "Actualizar";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.White;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Image = global::GestionClientes.Properties.Resources._04DHSISTEMAS_300x84;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(689, 100);
            this.lblLogo.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(93, 108);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(99, 23);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "Nuevo Cliente";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(198, 108);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(99, 23);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Editar Cliente";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(303, 108);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Eliminar Cliente";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblTotalCustomers
            // 
            this.LblTotalCustomers.AutoSize = true;
            this.LblTotalCustomers.BackColor = System.Drawing.Color.White;
            this.LblTotalCustomers.Location = new System.Drawing.Point(12, 472);
            this.LblTotalCustomers.Name = "LblTotalCustomers";
            this.LblTotalCustomers.Size = new System.Drawing.Size(0, 13);
            this.LblTotalCustomers.TabIndex = 6;
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Location = new System.Drawing.Point(408, 108);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(99, 23);
            this.BtnDuplicate.TabIndex = 7;
            this.BtnDuplicate.Text = "Duplicar Cliente";
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 503);
            this.Controls.Add(this.BtnDuplicate);
            this.Controls.Add(this.LblTotalCustomers);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LstCustomers);
            this.Controls.Add(this.lblLogo);
            this.Name = "FMain";
            this.Text = "Libreta Basica Contactos | Clientes";
            this.Activated += new System.EventHandler(this.FMain_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListView LstCustomers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblTotalCustomers;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.ColumnHeader colCreateDate;
    }
}

