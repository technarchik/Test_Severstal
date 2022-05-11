
namespace Notes
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.openButton = new System.Windows.Forms.Button();
            this.noteBody = new System.Windows.Forms.RichTextBox();
            this.nameOfNote = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openButton.Location = new System.Drawing.Point(484, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(55, 44);
            this.openButton.TabIndex = 10;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            this.openButton.MouseHover += new System.EventHandler(this.openButton_MouseHover_1);
            // 
            // noteBody
            // 
            this.noteBody.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.noteBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteBody.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteBody.ForeColor = System.Drawing.SystemColors.Window;
            this.noteBody.Location = new System.Drawing.Point(12, 55);
            this.noteBody.Name = "noteBody";
            this.noteBody.Size = new System.Drawing.Size(527, 405);
            this.noteBody.TabIndex = 9;
            this.noteBody.Text = "Напишите что-нибудь!";
            // 
            // nameOfNote
            // 
            this.nameOfNote.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nameOfNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOfNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfNote.ForeColor = System.Drawing.SystemColors.Window;
            this.nameOfNote.Location = new System.Drawing.Point(12, 11);
            this.nameOfNote.Name = "nameOfNote";
            this.nameOfNote.Size = new System.Drawing.Size(392, 27);
            this.nameOfNote.TabIndex = 8;
            this.nameOfNote.Text = "Название заметки";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(421, -1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(57, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(551, 473);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.noteBody);
            this.Controls.Add(this.nameOfNote);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Notes - New Note";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.RichTextBox noteBody;
        private System.Windows.Forms.TextBox nameOfNote;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}