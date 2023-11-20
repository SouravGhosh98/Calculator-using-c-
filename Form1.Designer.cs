namespace My_Calculator
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
            this.btnbs = new System.Windows.Forms.Button();
            this.textresult = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclearentry = new System.Windows.Forms.Button();
            this.btnpm = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btneqal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbs
            // 
            this.btnbs.BackColor = System.Drawing.Color.Red;
            this.btnbs.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnbs.Location = new System.Drawing.Point(324, 118);
            this.btnbs.Name = "btnbs";
            this.btnbs.Size = new System.Drawing.Size(79, 61);
            this.btnbs.TabIndex = 0;
            this.btnbs.Text = "";
            this.btnbs.UseVisualStyleBackColor = false;
            this.btnbs.Click += new System.EventHandler(this.btnbs_Click);
            // 
            // textresult
            // 
            this.textresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresult.Location = new System.Drawing.Point(11, 12);
            this.textresult.Multiline = true;
            this.textresult.Name = "textresult";
            this.textresult.Size = new System.Drawing.Size(392, 84);
            this.textresult.TabIndex = 1;
            this.textresult.Text = "0";
            this.textresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textresult.Click += new System.EventHandler(this.EnterNums);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(23, 117);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 61);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclearentry
            // 
            this.btnclearentry.BackColor = System.Drawing.Color.Transparent;
            this.btnclearentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearentry.Location = new System.Drawing.Point(123, 118);
            this.btnclearentry.Name = "btnclearentry";
            this.btnclearentry.Size = new System.Drawing.Size(79, 61);
            this.btnclearentry.TabIndex = 3;
            this.btnclearentry.Text = "√";
            this.btnclearentry.UseVisualStyleBackColor = false;
            this.btnclearentry.Click += new System.EventHandler(this.btnclearentry_Click);
            // 
            // btnpm
            // 
            this.btnpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpm.Location = new System.Drawing.Point(223, 118);
            this.btnpm.Name = "btnpm";
            this.btnpm.Size = new System.Drawing.Size(79, 61);
            this.btnpm.TabIndex = 4;
            this.btnpm.Text = "±";
            this.btnpm.UseVisualStyleBackColor = true;
            this.btnpm.Click += new System.EventHandler(this.btnpm_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(23, 349);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 61);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.EnterNums);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(325, 195);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(79, 61);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(223, 349);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 61);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.EnterNums);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(123, 195);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 61);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.EnterNums);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(123, 349);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 61);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.EnterNums);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(223, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 61);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.EnterNums);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(324, 349);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(79, 61);
            this.btnmul.TabIndex = 10;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(23, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 61);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.EnterNums);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(324, 272);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(79, 61);
            this.btnsub.TabIndex = 16;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(123, 272);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 61);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.EnterNums);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(223, 272);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 61);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.EnterNums);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(23, 272);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 61);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.EnterNums);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(123, 434);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(79, 61);
            this.btndot.TabIndex = 20;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.EnterNums);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(223, 434);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(79, 61);
            this.btndiv.TabIndex = 19;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(23, 434);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 61);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.EnterNums);
            // 
            // btneqal
            // 
            this.btneqal.BackColor = System.Drawing.Color.Lime;
            this.btneqal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneqal.Location = new System.Drawing.Point(327, 434);
            this.btneqal.Name = "btneqal";
            this.btneqal.Size = new System.Drawing.Size(79, 61);
            this.btneqal.TabIndex = 17;
            this.btneqal.Text = "=";
            this.btneqal.UseVisualStyleBackColor = false;
            this.btneqal.Click += new System.EventHandler(this.btneqal_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 520);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btneqal);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnpm);
            this.Controls.Add(this.btnclearentry);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.btnbs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbs;
        private System.Windows.Forms.TextBox textresult;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclearentry;
        private System.Windows.Forms.Button btnpm;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btneqal;
    }
}

