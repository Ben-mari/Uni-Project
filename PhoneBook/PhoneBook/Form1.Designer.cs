namespace PhoneBook
{
    partial class Telephonebook
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
            this.ContactsDataGrid = new System.Windows.Forms.DataGridView();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FieldButt = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SaveButt = new System.Windows.Forms.Button();
            this.BirthdayBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactsDataGrid
            // 
            this.ContactsDataGrid.AllowUserToOrderColumns = true;
            this.ContactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDataGrid.Location = new System.Drawing.Point(12, 175);
            this.ContactsDataGrid.Name = "ContactsDataGrid";
            this.ContactsDataGrid.RowHeadersWidth = 51;
            this.ContactsDataGrid.RowTemplate.Height = 24;
            this.ContactsDataGrid.Size = new System.Drawing.Size(776, 258);
            this.ContactsDataGrid.TabIndex = 25;
            this.ContactsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsDataGrid_CellDoubleClick);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(363, 102);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(100, 22);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "E-mail:";
            // 
            // MobileLabel
            // 
            this.MobileLabel.Location = new System.Drawing.Point(363, 77);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(100, 22);
            this.MobileLabel.TabIndex = 23;
            this.MobileLabel.Text = "Mobile:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(363, 46);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(100, 22);
            this.LastNameLabel.TabIndex = 22;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(469, 102);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(319, 22);
            this.EmailBox.TabIndex = 21;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(469, 74);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(319, 22);
            this.PhoneBox.TabIndex = 20;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(469, 46);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(319, 22);
            this.LastNameBox.TabIndex = 19;
            // 
            // FieldButt
            // 
            this.FieldButt.Location = new System.Drawing.Point(12, 118);
            this.FieldButt.Name = "FieldButt";
            this.FieldButt.Size = new System.Drawing.Size(150, 51);
            this.FieldButt.TabIndex = 18;
            this.FieldButt.Text = "Clear Fields";
            this.FieldButt.UseVisualStyleBackColor = true;
            this.FieldButt.Click += new System.EventHandler(this.FieldButt_Click);
            // 
            // DeleteButt
            // 
            this.DeleteButt.Location = new System.Drawing.Point(186, 118);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(150, 51);
            this.DeleteButt.TabIndex = 17;
            this.DeleteButt.Text = "Delete";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(363, 18);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(100, 22);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(469, 18);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(319, 22);
            this.FirstNameBox.TabIndex = 15;
            // 
            // SaveButt
            // 
            this.SaveButt.Location = new System.Drawing.Point(80, 41);
            this.SaveButt.Name = "SaveButt";
            this.SaveButt.Size = new System.Drawing.Size(168, 55);
            this.SaveButt.TabIndex = 14;
            this.SaveButt.Text = "Save";
            this.SaveButt.UseVisualStyleBackColor = true;
            this.SaveButt.Click += new System.EventHandler(this.SaveButt_Click);
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(469, 132);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(319, 22);
            this.BirthdayBox.TabIndex = 26;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(363, 132);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(100, 22);
            this.BirthdayLabel.TabIndex = 27;
            this.BirthdayLabel.Text = "Birthday :";
            // 
            // Telephonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.BirthdayBox);
            this.Controls.Add(this.ContactsDataGrid);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.MobileLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FieldButt);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SaveButt);
            this.Name = "Telephonebook";
            this.Text = "Telephonebook";
            this.Load += new System.EventHandler(this.Telephonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContactsDataGrid;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Button FieldButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Button SaveButt;
        private System.Windows.Forms.TextBox BirthdayBox;
        private System.Windows.Forms.Label BirthdayLabel;
    }
}

