namespace ToDo_List
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
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.Create = new System.Windows.Forms.Button();
            this.newCheckbox = new System.Windows.Forms.TextBox();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkList
            // 
            this.checkList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkList.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(12, 47);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(676, 418);
            this.checkList.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Create.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create.Location = new System.Drawing.Point(694, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // newCheckbox
            // 
            this.newCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.newCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCheckbox.Location = new System.Drawing.Point(12, 16);
            this.newCheckbox.Name = "newCheckbox";
            this.newCheckbox.PlaceholderText = "Checklist Item";
            this.newCheckbox.Size = new System.Drawing.Size(676, 20);
            this.newCheckbox.TabIndex = 2;
            this.newCheckbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.Location = new System.Drawing.Point(694, 438);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(94, 29);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.newCheckbox);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.checkList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "To Do";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CheckedListBox checkList;
        private Button Create;
        private TextBox newCheckbox;
        private Button Quit;
    }
}