
namespace Inheritance_polymorphism_task
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
            this.cowMilk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.fLoc = new System.Windows.Forms.TextBox();
            this.Profit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goatMilk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cowVac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.goatVac = new System.Windows.Forms.TextBox();
            this.jCowVac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cowMilk
            // 
            this.cowMilk.Location = new System.Drawing.Point(12, 34);
            this.cowMilk.Multiline = true;
            this.cowMilk.Name = "cowMilk";
            this.cowMilk.Size = new System.Drawing.Size(162, 23);
            this.cowMilk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price of cows milk:";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(433, 63);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(128, 31);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // fLoc
            // 
            this.fLoc.Location = new System.Drawing.Point(293, 30);
            this.fLoc.Multiline = true;
            this.fLoc.Name = "fLoc";
            this.fLoc.Size = new System.Drawing.Size(403, 27);
            this.fLoc.TabIndex = 3;
            // 
            // Profit
            // 
            this.Profit.Location = new System.Drawing.Point(397, 172);
            this.Profit.Multiline = true;
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(199, 66);
            this.Profit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost of goat vaccination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Profit";
            // 
            // goatMilk
            // 
            this.goatMilk.Location = new System.Drawing.Point(12, 88);
            this.goatMilk.Multiline = true;
            this.goatMilk.Name = "goatMilk";
            this.goatMilk.Size = new System.Drawing.Size(161, 23);
            this.goatMilk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price of goats milk:";
            // 
            // cowVac
            // 
            this.cowVac.Location = new System.Drawing.Point(13, 172);
            this.cowVac.Multiline = true;
            this.cowVac.Name = "cowVac";
            this.cowVac.Size = new System.Drawing.Size(160, 23);
            this.cowVac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost of cow vaccination:";
            // 
            // goatVac
            // 
            this.goatVac.Location = new System.Drawing.Point(12, 287);
            this.goatVac.Multiline = true;
            this.goatVac.Name = "goatVac";
            this.goatVac.Size = new System.Drawing.Size(160, 23);
            this.goatVac.TabIndex = 11;
            // 
            // jCowVac
            // 
            this.jCowVac.Location = new System.Drawing.Point(13, 229);
            this.jCowVac.Multiline = true;
            this.jCowVac.Name = "jCowVac";
            this.jCowVac.Size = new System.Drawing.Size(159, 23);
            this.jCowVac.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost of jersey cow vaccination:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jCowVac);
            this.Controls.Add(this.goatVac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cowVac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goatMilk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.fLoc);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cowMilk);
            this.Name = "Form1";
            this.Text = "Animal Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cowMilk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox fLoc;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goatMilk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cowVac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox goatVac;
        private System.Windows.Forms.TextBox jCowVac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

