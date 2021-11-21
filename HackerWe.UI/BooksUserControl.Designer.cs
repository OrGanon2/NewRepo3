
namespace HackerWe.UI
{
    partial class BooksUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksUserControl));
            this.AddBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.IdentityNumberText = new System.Windows.Forms.TextBox();
            this.NumberOfPagesText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NumberOfCopiesText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePublishedPicker = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(89, 423);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(156, 92);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identity Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number Of Pages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numbers Of Copies";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(144, 72);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(125, 27);
            this.IdText.TabIndex = 8;
            // 
            // IdentityNumberText
            // 
            this.IdentityNumberText.Location = new System.Drawing.Point(144, 119);
            this.IdentityNumberText.Name = "IdentityNumberText";
            this.IdentityNumberText.Size = new System.Drawing.Size(125, 27);
            this.IdentityNumberText.TabIndex = 9;
            // 
            // NumberOfPagesText
            // 
            this.NumberOfPagesText.Location = new System.Drawing.Point(144, 253);
            this.NumberOfPagesText.Name = "NumberOfPagesText";
            this.NumberOfPagesText.Size = new System.Drawing.Size(125, 27);
            this.NumberOfPagesText.TabIndex = 10;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(144, 211);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(125, 27);
            this.AuthorText.TabIndex = 11;
            this.AuthorText.TextChanged += new System.EventHandler(this.AuhthorText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(144, 164);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(125, 27);
            this.NameText.TabIndex = 12;
            // 
            // NumberOfCopiesText
            // 
            this.NumberOfCopiesText.Location = new System.Drawing.Point(144, 300);
            this.NumberOfCopiesText.Name = "NumberOfCopiesText";
            this.NumberOfCopiesText.Size = new System.Drawing.Size(125, 27);
            this.NumberOfCopiesText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date Published";
            // 
            // DatePublishedPicker
            // 
            this.DatePublishedPicker.Location = new System.Drawing.Point(147, 348);
            this.DatePublishedPicker.Name = "DatePublishedPicker";
            this.DatePublishedPicker.Size = new System.Drawing.Size(250, 27);
            this.DatePublishedPicker.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblMessage.Location = new System.Drawing.Point(328, 423);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(499, 120);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "";
            // 
            // BooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.DatePublishedPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfCopiesText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.NumberOfPagesText);
            this.Controls.Add(this.IdentityNumberText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBookButton);
            this.Name = "BooksUserControl";
            this.Size = new System.Drawing.Size(876, 603);
            this.Load += new System.EventHandler(this.BooksUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox IdentityNumberText;
        private System.Windows.Forms.TextBox NumberOfPagesText;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox NumberOfCopiesText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DatePublishedPicker;
        private System.Windows.Forms.RichTextBox lblMessage;
    }
}
