namespace ContactList
{
    partial class MainForm
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
            this.lblContactList = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContactList
            // 
            this.lblContactList.AutoSize = true;
            this.lblContactList.Location = new System.Drawing.Point(445, 67);
            this.lblContactList.Name = "lblContactList";
            this.lblContactList.Size = new System.Drawing.Size(113, 16);
            this.lblContactList.TabIndex = 0;
            this.lblContactList.Text = "Danh sách liên hệ";
            // 
            // btnAddContact
            // 
            this.btnAddContact.AutoSize = true;
            this.btnAddContact.Location = new System.Drawing.Point(376, 122);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(94, 26);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Thêm liên hệ";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lblContactList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactList;
        private System.Windows.Forms.Button btnAddContact;
    }
}

