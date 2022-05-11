
namespace Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveButton = new System.Windows.Forms.Button();
            this.nameOfNote = new System.Windows.Forms.TextBox();
            this.noteBody = new System.Windows.Forms.RichTextBox();
            this.listOfNotes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(421, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(57, 50);
            this.saveButton.TabIndex = 1;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // nameOfNote
            // 
            this.nameOfNote.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameOfNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOfNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfNote.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfNote.Location = new System.Drawing.Point(12, 12);
            this.nameOfNote.Name = "nameOfNote";
            this.nameOfNote.Size = new System.Drawing.Size(392, 27);
            this.nameOfNote.TabIndex = 2;
            this.nameOfNote.Text = "Название заметки";
            // 
            // noteBody
            // 
            this.noteBody.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.noteBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteBody.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteBody.ForeColor = System.Drawing.SystemColors.Window;
            this.noteBody.Location = new System.Drawing.Point(12, 56);
            this.noteBody.Name = "noteBody";
            this.noteBody.Size = new System.Drawing.Size(527, 405);
            this.noteBody.TabIndex = 3;
            this.noteBody.Text = "Напишите что-нибудь!";
            this.noteBody.MouseClick += new System.Windows.Forms.MouseEventHandler(this.noteBody_MouseClick);
            // 
            // listOfNotes
            // 
            this.listOfNotes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listOfNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOfNotes.ForeColor = System.Drawing.SystemColors.Window;
            this.listOfNotes.FormattingEnabled = true;
            this.listOfNotes.ItemHeight = 19;
            this.listOfNotes.Location = new System.Drawing.Point(573, 56);
            this.listOfNotes.Name = "listOfNotes";
            this.listOfNotes.Size = new System.Drawing.Size(177, 308);
            this.listOfNotes.TabIndex = 4;
            this.listOfNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOfNotes_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(573, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваши заметки:";
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openButton.Location = new System.Drawing.Point(484, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(55, 44);
            this.openButton.TabIndex = 6;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.MouseHover += new System.EventHandler(this.openButton_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(633, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(57, 49);
            this.addButton.TabIndex = 7;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseHover += new System.EventHandler(this.addButton_MouseHover);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(704, 14);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(37, 36);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseHover += new System.EventHandler(this.deleteButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfNotes);
            this.Controls.Add(this.noteBody);
            this.Controls.Add(this.nameOfNote);
            this.Controls.Add(this.saveButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameOfNote;
        private System.Windows.Forms.RichTextBox noteBody;
        private System.Windows.Forms.ListBox listOfNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

