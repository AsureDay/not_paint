
namespace drowing_lines_and_other_things
{
    partial class FormColorChange
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
            this.fieldHexColor = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fieldHexColor
            // 
            this.fieldHexColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fieldHexColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldHexColor.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldHexColor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fieldHexColor.Location = new System.Drawing.Point(194, 10);
            this.fieldHexColor.Name = "fieldHexColor";
            this.fieldHexColor.Size = new System.Drawing.Size(150, 50);
            this.fieldHexColor.TabIndex = 0;
            this.fieldHexColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldHexColor.TextChanged += new System.EventHandler(this.HexFieldTextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(11, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "HEX color";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(68, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(302, 44);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Red Green Blue";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBox1.Location = new System.Drawing.Point(49, 164);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 43);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.RTextChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBox2.Location = new System.Drawing.Point(194, 164);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(80, 43);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.GTextChanged);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBox3.Location = new System.Drawing.Point(350, 164);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(80, 43);
            this.maskedTextBox3.TabIndex = 5;
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.TextChanged += new System.EventHandler(this.BTextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(12, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(31, 44);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "R";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.HideSelection = false;
            this.textBox4.Location = new System.Drawing.Point(154, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(34, 44);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "G";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.HideSelection = false;
            this.textBox5.Location = new System.Drawing.Point(314, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(30, 44);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "B";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point(447, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(102, 44);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Size";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeTextBox.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sizeTextBox.Location = new System.Drawing.Point(555, 10);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(65, 50);
            this.sizeTextBox.TabIndex = 10;
            this.sizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeTextBox.TextChanged += new System.EventHandler(this.sizeTextBox_TextChanged);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.maskedTextBox4.Location = new System.Drawing.Point(596, 164);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(80, 43);
            this.maskedTextBox4.TabIndex = 11;
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox4.TextChanged += new System.EventHandler(this.maskedTextBox4_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.HideSelection = false;
            this.textBox7.Location = new System.Drawing.Point(555, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(156, 44);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Fill color";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormColorChange
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(862, 370);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fieldHexColor);
            this.Name = "FormColorChange";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Color change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox fieldHexColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MaskedTextBox sizeTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox textBox7;
    }
}