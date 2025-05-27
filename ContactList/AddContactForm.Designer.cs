namespace ContactList
{
    partial class AddContactForm
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(49, 43);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(52, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ Tên";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(48, 97);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(85, 16);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(162, 43);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(183, 97);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblFullName);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSave;
    }
}