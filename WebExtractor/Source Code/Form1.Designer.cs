
namespace WebExtractor
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
            this.Startbtn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneCounter = new System.Windows.Forms.Label();
            this.emailCounter = new System.Windows.Forms.Label();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.Black;
            this.Startbtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Startbtn.Location = new System.Drawing.Point(243, 3);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(115, 27);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "Extract";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(723, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Web Extractor                                                                    " +
    "                                                       ";
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDown);
            this.lblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseMove);
            this.lblName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseUp);
            // 
            // CloseApp
            // 
            this.CloseApp.AutoSize = true;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApp.ForeColor = System.Drawing.Color.Red;
            this.CloseApp.Location = new System.Drawing.Point(341, 1);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(18, 18);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "X";
            this.CloseApp.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.phoneCounter);
            this.panel1.Controls.Add(this.emailCounter);
            this.panel1.Controls.Add(this.URLBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ResultBox);
            this.panel1.Controls.Add(this.Startbtn);
            this.panel1.Location = new System.Drawing.Point(-1, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 272);
            this.panel1.TabIndex = 3;
            // 
            // phoneCounter
            // 
            this.phoneCounter.AutoSize = true;
            this.phoneCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.phoneCounter.ForeColor = System.Drawing.Color.White;
            this.phoneCounter.Location = new System.Drawing.Point(9, 55);
            this.phoneCounter.Name = "phoneCounter";
            this.phoneCounter.Size = new System.Drawing.Size(53, 13);
            this.phoneCounter.TabIndex = 7;
            this.phoneCounter.Text = "Phone : 0";
            // 
            // emailCounter
            // 
            this.emailCounter.AutoSize = true;
            this.emailCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.emailCounter.ForeColor = System.Drawing.Color.White;
            this.emailCounter.Location = new System.Drawing.Point(9, 30);
            this.emailCounter.Name = "emailCounter";
            this.emailCounter.Size = new System.Drawing.Size(47, 13);
            this.emailCounter.TabIndex = 6;
            this.emailCounter.Text = "Email : 0";
            // 
            // URLBox
            // 
            this.URLBox.BackColor = System.Drawing.Color.Black;
            this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLBox.ForeColor = System.Drawing.Color.Red;
            this.URLBox.Location = new System.Drawing.Point(42, 3);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(195, 20);
            this.URLBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "URL :";
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.Black;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.ForeColor = System.Drawing.Color.White;
            this.ResultBox.Location = new System.Drawing.Point(6, 71);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(352, 182);
            this.ResultBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(359, 276);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebExtractorForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label CloseApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phoneCounter;
        private System.Windows.Forms.Label emailCounter;
    }
}

