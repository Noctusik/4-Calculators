namespace WinFormsCalculator
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
            this.mainBox = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainBox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainBox.Location = new System.Drawing.Point(12, 12);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(399, 57);
            this.mainBox.TabIndex = 0;
            this.mainBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b7.Location = new System.Drawing.Point(12, 75);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 66);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b8.Location = new System.Drawing.Point(93, 75);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 66);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b9.Location = new System.Drawing.Point(174, 75);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 66);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b4.Location = new System.Drawing.Point(12, 147);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 66);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b5.Location = new System.Drawing.Point(94, 147);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 66);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b6.Location = new System.Drawing.Point(174, 147);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 66);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b1.Location = new System.Drawing.Point(12, 219);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 66);
            this.b1.TabIndex = 7;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b2.Location = new System.Drawing.Point(94, 219);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 66);
            this.b2.TabIndex = 8;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b3.Location = new System.Drawing.Point(174, 219);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 66);
            this.b3.TabIndex = 9;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.b0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b0.Location = new System.Drawing.Point(12, 291);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(157, 66);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // bMinus
            // 
            this.bMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMinus.Location = new System.Drawing.Point(255, 75);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(75, 66);
            this.bMinus.TabIndex = 11;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = false;
            this.bMinus.Click += new System.EventHandler(this.bOperation_Click);
            // 
            // bMultiply
            // 
            this.bMultiply.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bMultiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMultiply.Location = new System.Drawing.Point(255, 147);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(75, 66);
            this.bMultiply.TabIndex = 12;
            this.bMultiply.Text = "*";
            this.bMultiply.UseVisualStyleBackColor = false;
            this.bMultiply.Click += new System.EventHandler(this.bOperation_Click);
            // 
            // bDivide
            // 
            this.bDivide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bDivide.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDivide.Location = new System.Drawing.Point(255, 219);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(75, 66);
            this.bDivide.TabIndex = 13;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = false;
            this.bDivide.Click += new System.EventHandler(this.bOperation_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bClear.Location = new System.Drawing.Point(255, 291);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 66);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bPlus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bPlus.Location = new System.Drawing.Point(336, 75);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(75, 138);
            this.bPlus.TabIndex = 15;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.bOperation_Click);
            // 
            // bResult
            // 
            this.bResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bResult.Location = new System.Drawing.Point(336, 219);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(75, 138);
            this.bResult.TabIndex = 16;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = false;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // bPoint
            // 
            this.bPoint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bPoint.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bPoint.Location = new System.Drawing.Point(174, 291);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(75, 66);
            this.bPoint.TabIndex = 17;
            this.bPoint.Text = ",";
            this.bPoint.UseVisualStyleBackColor = false;
            this.bPoint.Click += new System.EventHandler(this.bNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(423, 367);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.mainBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "WinFroms Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox mainBox;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b0;
        private Button bMinus;
        private Button bMultiply;
        private Button bDivide;
        private Button bClear;
        private Button bPlus;
        private Button bResult;
        private Button bPoint;
    }
}