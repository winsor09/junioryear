namespace Intro_to_WinForms
{
    partial class Form1
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
            this.do_something = new System.Windows.Forms.Button();
            this.fail_safe = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // do_something
            // 
            this.do_something.Location = new System.Drawing.Point(75, 53);
            this.do_something.Name = "do_something";
            this.do_something.Size = new System.Drawing.Size(252, 114);
            this.do_something.TabIndex = 0;
            this.do_something.Text = "do something\r\n";
            this.do_something.UseVisualStyleBackColor = true;
            this.do_something.Click += new System.EventHandler(this.do_something_Click);
            // 
            // fail_safe
            // 
            this.fail_safe.AutoSize = true;
            this.fail_safe.Location = new System.Drawing.Point(535, 30);
            this.fail_safe.Name = "fail_safe";
            this.fail_safe.Size = new System.Drawing.Size(127, 17);
            this.fail_safe.TabIndex = 1;
            this.fail_safe.Text = "check box something\r\n";
            this.fail_safe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(535, 146);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(654, 229);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 3;
            this.label.Text = "yeeeeeettt";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(50, 191);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(499, 228);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(405, 104);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.fail_safe);
            this.Controls.Add(this.do_something);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button do_something;
        private System.Windows.Forms.CheckBox fail_safe;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox;
    }
}

