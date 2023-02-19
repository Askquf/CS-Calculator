
namespace Calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.sq_root = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.eqv = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.nul = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.memory_out = new System.Windows.Forms.Button();
            this.memory_in = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(466, 31);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(366, 93);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(112, 34);
            this.div.TabIndex = 1;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(366, 133);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(112, 34);
            this.mult.TabIndex = 2;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(366, 173);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(112, 34);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(366, 213);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(112, 34);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(248, 93);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(112, 34);
            this.b9.TabIndex = 5;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(248, 133);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(112, 34);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(248, 173);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(112, 34);
            this.b3.TabIndex = 7;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // sq_root
            // 
            this.sq_root.Location = new System.Drawing.Point(366, 253);
            this.sq_root.Name = "sq_root";
            this.sq_root.Size = new System.Drawing.Size(112, 34);
            this.sq_root.TabIndex = 8;
            this.sq_root.Text = "sqrt";
            this.sq_root.UseVisualStyleBackColor = true;
            this.sq_root.Click += new System.EventHandler(this.sq_root_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(130, 93);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(112, 34);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(130, 133);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(112, 34);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(130, 173);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(112, 34);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // eqv
            // 
            this.eqv.Location = new System.Drawing.Point(248, 213);
            this.eqv.Name = "eqv";
            this.eqv.Size = new System.Drawing.Size(112, 74);
            this.eqv.TabIndex = 12;
            this.eqv.Text = "=";
            this.eqv.UseVisualStyleBackColor = true;
            this.eqv.Click += new System.EventHandler(this.eqv_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 94);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(112, 34);
            this.b7.TabIndex = 13;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 134);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(112, 34);
            this.b4.TabIndex = 14;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 173);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(112, 34);
            this.b1.TabIndex = 15;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // nul
            // 
            this.nul.Location = new System.Drawing.Point(12, 213);
            this.nul.Name = "nul";
            this.nul.Size = new System.Drawing.Size(112, 74);
            this.nul.TabIndex = 16;
            this.nul.Text = "0";
            this.nul.UseVisualStyleBackColor = true;
            this.nul.Click += new System.EventHandler(this.nul_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(130, 54);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(112, 34);
            this.del.TabIndex = 17;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(12, 54);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(112, 34);
            this.clear_all.TabIndex = 17;
            this.clear_all.Text = "CA";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // memory_out
            // 
            this.memory_out.Location = new System.Drawing.Point(248, 54);
            this.memory_out.Name = "memory_out";
            this.memory_out.Size = new System.Drawing.Size(112, 34);
            this.memory_out.TabIndex = 17;
            this.memory_out.Text = "MW";
            this.memory_out.UseVisualStyleBackColor = true;
            this.memory_out.Click += new System.EventHandler(this.memory_out_Click);
            // 
            // memory_in
            // 
            this.memory_in.Location = new System.Drawing.Point(366, 53);
            this.memory_in.Name = "memory_in";
            this.memory_in.Size = new System.Drawing.Size(112, 34);
            this.memory_in.TabIndex = 17;
            this.memory_in.Text = "MS";
            this.memory_in.UseVisualStyleBackColor = true;
            this.memory_in.Click += new System.EventHandler(this.memory_in_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(130, 213);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(112, 74);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(130, 290);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(348, 48);
            this.Memory.TabIndex = 19;
            this.Memory.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 74);
            this.label2.TabIndex = 20;
            this.label2.Text = "Number in memory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.memory_in);
            this.Controls.Add(this.memory_out);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.del);
            this.Controls.Add(this.nul);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.eqv);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.sq_root);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button sq_root;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button eqv;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button nul;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button memory_out;
        private System.Windows.Forms.Button memory_in;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label label2;
    }
}

