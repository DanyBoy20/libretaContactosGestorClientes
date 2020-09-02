namespace GestionClientes
{
    partial class FCustomer
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BindSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.LblCreateDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindSource, "Name", true));
            this.TxtName.Location = new System.Drawing.Point(82, 55);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(189, 20);
            this.TxtName.TabIndex = 0;
            // 
            // BindSource
            // 
            this.BindSource.DataSource = typeof(GestionClientes.Customer);
            // 
            // TxtLastName
            // 
            this.TxtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindSource, "LastName", true));
            this.TxtLastName.Location = new System.Drawing.Point(82, 81);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(189, 20);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindSource, "Address", true));
            this.TxtAddress.Location = new System.Drawing.Point(82, 107);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(189, 20);
            this.TxtAddress.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(19, 58);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Nombre";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(19, 84);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(49, 13);
            this.LblLastName.TabIndex = 4;
            this.LblLastName.Text = "Apellidos";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(19, 110);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(52, 13);
            this.LblAddress.TabIndex = 5;
            this.LblAddress.Text = "Dirección";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(137, 180);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(218, 180);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(19, 25);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(96, 13);
            this.Lbl.TabIndex = 8;
            this.Lbl.Text = "Fecha de creación";
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblCreateDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindSource, "CreateDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "f"));
            this.LblCreateDate.Location = new System.Drawing.Point(121, 25);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(0, 13);
            this.LblCreateDate.TabIndex = 9;
            // 
            // FCustomer
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(305, 227);
            this.Controls.Add(this.LblCreateDate);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.MaximizeBox = false;
            this.Name = "FCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.BindSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.BindingSource BindSource;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblCreateDate;
    }
}