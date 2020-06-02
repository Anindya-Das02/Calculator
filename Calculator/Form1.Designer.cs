namespace Calculator
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonOpenBracket = new System.Windows.Forms.Button();
            this.ButtonCloseBracket = new System.Windows.Forms.Button();
            this.ButtonDigit4 = new System.Windows.Forms.Button();
            this.ButtonDigit5 = new System.Windows.Forms.Button();
            this.ButtonDigit6 = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDigit1 = new System.Windows.Forms.Button();
            this.ButtonDigit2 = new System.Windows.Forms.Button();
            this.ButtonDigit3 = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonDigit0 = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDigit7 = new System.Windows.Forms.Button();
            this.ButtonDigit8 = new System.Windows.Forms.Button();
            this.ButtonDigit9 = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.OutputResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(13, 36);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(266, 35);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Tomato;
            this.ButtonClear.FlatAppearance.BorderSize = 0;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClear.Location = new System.Drawing.Point(13, 76);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(62, 42);
            this.ButtonClear.TabIndex = 1;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDelete.Location = new System.Drawing.Point(81, 76);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(62, 42);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "DEL";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonOpenBracket
            // 
            this.ButtonOpenBracket.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonOpenBracket.FlatAppearance.BorderSize = 0;
            this.ButtonOpenBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenBracket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonOpenBracket.Location = new System.Drawing.Point(149, 76);
            this.ButtonOpenBracket.Name = "ButtonOpenBracket";
            this.ButtonOpenBracket.Size = new System.Drawing.Size(62, 42);
            this.ButtonOpenBracket.TabIndex = 1;
            this.ButtonOpenBracket.Text = "(";
            this.ButtonOpenBracket.UseVisualStyleBackColor = false;
            this.ButtonOpenBracket.Click += new System.EventHandler(this.ButtonOpenBracket_Click);
            // 
            // ButtonCloseBracket
            // 
            this.ButtonCloseBracket.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonCloseBracket.FlatAppearance.BorderSize = 0;
            this.ButtonCloseBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCloseBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseBracket.Location = new System.Drawing.Point(217, 76);
            this.ButtonCloseBracket.Name = "ButtonCloseBracket";
            this.ButtonCloseBracket.Size = new System.Drawing.Size(62, 42);
            this.ButtonCloseBracket.TabIndex = 1;
            this.ButtonCloseBracket.Text = ")";
            this.ButtonCloseBracket.UseVisualStyleBackColor = false;
            this.ButtonCloseBracket.Click += new System.EventHandler(this.ButtonCloseBracket_Click);
            // 
            // ButtonDigit4
            // 
            this.ButtonDigit4.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit4.FlatAppearance.BorderSize = 0;
            this.ButtonDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit4.ForeColor = System.Drawing.Color.White;
            this.ButtonDigit4.Location = new System.Drawing.Point(13, 172);
            this.ButtonDigit4.Name = "ButtonDigit4";
            this.ButtonDigit4.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit4.TabIndex = 1;
            this.ButtonDigit4.Text = "4";
            this.ButtonDigit4.UseVisualStyleBackColor = false;
            this.ButtonDigit4.Click += new System.EventHandler(this.ButtonDigit4_Click);
            // 
            // ButtonDigit5
            // 
            this.ButtonDigit5.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit5.FlatAppearance.BorderSize = 0;
            this.ButtonDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit5.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit5.Location = new System.Drawing.Point(81, 172);
            this.ButtonDigit5.Name = "ButtonDigit5";
            this.ButtonDigit5.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit5.TabIndex = 1;
            this.ButtonDigit5.Text = "5";
            this.ButtonDigit5.UseVisualStyleBackColor = false;
            this.ButtonDigit5.Click += new System.EventHandler(this.ButtonDigit5_Click);
            // 
            // ButtonDigit6
            // 
            this.ButtonDigit6.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit6.FlatAppearance.BorderSize = 0;
            this.ButtonDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit6.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit6.Location = new System.Drawing.Point(149, 172);
            this.ButtonDigit6.Name = "ButtonDigit6";
            this.ButtonDigit6.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit6.TabIndex = 1;
            this.ButtonDigit6.Text = "6";
            this.ButtonDigit6.UseVisualStyleBackColor = false;
            this.ButtonDigit6.Click += new System.EventHandler(this.ButtonDigit6_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonMultiply.FlatAppearance.BorderSize = 0;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiply.Location = new System.Drawing.Point(217, 172);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(62, 42);
            this.ButtonMultiply.TabIndex = 1;
            this.ButtonMultiply.Text = "x";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonDigit1
            // 
            this.ButtonDigit1.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit1.FlatAppearance.BorderSize = 0;
            this.ButtonDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit1.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit1.Location = new System.Drawing.Point(13, 220);
            this.ButtonDigit1.Name = "ButtonDigit1";
            this.ButtonDigit1.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit1.TabIndex = 1;
            this.ButtonDigit1.Text = "1";
            this.ButtonDigit1.UseVisualStyleBackColor = false;
            this.ButtonDigit1.Click += new System.EventHandler(this.ButtonDigit1_Click);
            // 
            // ButtonDigit2
            // 
            this.ButtonDigit2.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit2.FlatAppearance.BorderSize = 0;
            this.ButtonDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit2.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit2.Location = new System.Drawing.Point(81, 220);
            this.ButtonDigit2.Name = "ButtonDigit2";
            this.ButtonDigit2.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit2.TabIndex = 1;
            this.ButtonDigit2.Text = "2";
            this.ButtonDigit2.UseVisualStyleBackColor = false;
            this.ButtonDigit2.Click += new System.EventHandler(this.ButtonDigit2_Click);
            // 
            // ButtonDigit3
            // 
            this.ButtonDigit3.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit3.FlatAppearance.BorderSize = 0;
            this.ButtonDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit3.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit3.Location = new System.Drawing.Point(149, 220);
            this.ButtonDigit3.Name = "ButtonDigit3";
            this.ButtonDigit3.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit3.TabIndex = 1;
            this.ButtonDigit3.Text = "3";
            this.ButtonDigit3.UseVisualStyleBackColor = false;
            this.ButtonDigit3.Click += new System.EventHandler(this.ButtonDigit3_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonSubtract.FlatAppearance.BorderSize = 0;
            this.ButtonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubtract.Location = new System.Drawing.Point(217, 220);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(62, 42);
            this.ButtonSubtract.TabIndex = 1;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = false;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonDigit0
            // 
            this.ButtonDigit0.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit0.FlatAppearance.BorderSize = 0;
            this.ButtonDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit0.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDigit0.Location = new System.Drawing.Point(13, 268);
            this.ButtonDigit0.Name = "ButtonDigit0";
            this.ButtonDigit0.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit0.TabIndex = 1;
            this.ButtonDigit0.Text = "0";
            this.ButtonDigit0.UseVisualStyleBackColor = false;
            this.ButtonDigit0.Click += new System.EventHandler(this.ButtonDigit0_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.Color.Black;
            this.ButtonDot.FlatAppearance.BorderSize = 0;
            this.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDot.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonDot.Location = new System.Drawing.Point(81, 268);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(62, 42);
            this.ButtonDot.TabIndex = 1;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonEqual.FlatAppearance.BorderSize = 0;
            this.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEqual.Location = new System.Drawing.Point(149, 268);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(62, 42);
            this.ButtonEqual.TabIndex = 1;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = false;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Location = new System.Drawing.Point(217, 268);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(62, 42);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDigit7
            // 
            this.ButtonDigit7.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit7.FlatAppearance.BorderSize = 0;
            this.ButtonDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit7.ForeColor = System.Drawing.Color.White;
            this.ButtonDigit7.Location = new System.Drawing.Point(13, 124);
            this.ButtonDigit7.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDigit7.Name = "ButtonDigit7";
            this.ButtonDigit7.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit7.TabIndex = 1;
            this.ButtonDigit7.Text = "7";
            this.ButtonDigit7.UseVisualStyleBackColor = false;
            this.ButtonDigit7.Click += new System.EventHandler(this.ButtonDigit7_Click);
            // 
            // ButtonDigit8
            // 
            this.ButtonDigit8.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit8.FlatAppearance.BorderSize = 0;
            this.ButtonDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit8.ForeColor = System.Drawing.Color.White;
            this.ButtonDigit8.Location = new System.Drawing.Point(81, 124);
            this.ButtonDigit8.Name = "ButtonDigit8";
            this.ButtonDigit8.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit8.TabIndex = 1;
            this.ButtonDigit8.Text = "8";
            this.ButtonDigit8.UseVisualStyleBackColor = false;
            this.ButtonDigit8.Click += new System.EventHandler(this.ButtonDigit8_Click);
            // 
            // ButtonDigit9
            // 
            this.ButtonDigit9.BackColor = System.Drawing.Color.Black;
            this.ButtonDigit9.FlatAppearance.BorderSize = 0;
            this.ButtonDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDigit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDigit9.ForeColor = System.Drawing.Color.White;
            this.ButtonDigit9.Location = new System.Drawing.Point(149, 124);
            this.ButtonDigit9.Name = "ButtonDigit9";
            this.ButtonDigit9.Size = new System.Drawing.Size(62, 42);
            this.ButtonDigit9.TabIndex = 1;
            this.ButtonDigit9.Text = "9";
            this.ButtonDigit9.UseVisualStyleBackColor = false;
            this.ButtonDigit9.Click += new System.EventHandler(this.ButtonDigit9_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonDivide.FlatAppearance.BorderSize = 0;
            this.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivide.Location = new System.Drawing.Point(217, 124);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(62, 42);
            this.ButtonDivide.TabIndex = 1;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // OutputResult
            // 
            this.OutputResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputResult.Location = new System.Drawing.Point(12, 19);
            this.OutputResult.Name = "OutputResult";
            this.OutputResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputResult.Size = new System.Drawing.Size(267, 13);
            this.OutputResult.TabIndex = 2;
            this.OutputResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(294, 329);
            this.Controls.Add(this.OutputResult);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonSubtract);
            this.Controls.Add(this.ButtonDigit3);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDigit9);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.ButtonDigit6);
            this.Controls.Add(this.ButtonDigit2);
            this.Controls.Add(this.ButtonCloseBracket);
            this.Controls.Add(this.ButtonDigit8);
            this.Controls.Add(this.ButtonDigit0);
            this.Controls.Add(this.ButtonDigit5);
            this.Controls.Add(this.ButtonDigit1);
            this.Controls.Add(this.ButtonDigit7);
            this.Controls.Add(this.ButtonOpenBracket);
            this.Controls.Add(this.ButtonDigit4);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "C# Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonOpenBracket;
        private System.Windows.Forms.Button ButtonCloseBracket;
        private System.Windows.Forms.Button ButtonDigit4;
        private System.Windows.Forms.Button ButtonDigit5;
        private System.Windows.Forms.Button ButtonDigit6;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDigit1;
        private System.Windows.Forms.Button ButtonDigit2;
        private System.Windows.Forms.Button ButtonDigit3;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonDigit0;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDigit7;
        private System.Windows.Forms.Button ButtonDigit8;
        private System.Windows.Forms.Button ButtonDigit9;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Label OutputResult;
    }
}

