
namespace ThrowDice
{
    partial class frmMain
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
            this.gbSelectDice = new System.Windows.Forms.GroupBox();
            this.rbD6 = new System.Windows.Forms.RadioButton();
            this.rbD10 = new System.Windows.Forms.RadioButton();
            this.rbD20 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbSelectDice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectDice
            // 
            this.gbSelectDice.Controls.Add(this.rbD20);
            this.gbSelectDice.Controls.Add(this.rbD10);
            this.gbSelectDice.Controls.Add(this.rbD6);
            this.gbSelectDice.Location = new System.Drawing.Point(12, 12);
            this.gbSelectDice.Name = "gbSelectDice";
            this.gbSelectDice.Size = new System.Drawing.Size(90, 100);
            this.gbSelectDice.TabIndex = 0;
            this.gbSelectDice.TabStop = false;
            this.gbSelectDice.Text = "Select a Dice";
            // 
            // rbD6
            // 
            this.rbD6.AutoSize = true;
            this.rbD6.Location = new System.Drawing.Point(6, 19);
            this.rbD6.Name = "rbD6";
            this.rbD6.Size = new System.Drawing.Size(39, 17);
            this.rbD6.TabIndex = 0;
            this.rbD6.TabStop = true;
            this.rbD6.Text = "D6";
            this.rbD6.UseVisualStyleBackColor = true;
            // 
            // rbD10
            // 
            this.rbD10.AutoSize = true;
            this.rbD10.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbD10.Location = new System.Drawing.Point(6, 43);
            this.rbD10.Name = "rbD10";
            this.rbD10.Size = new System.Drawing.Size(45, 17);
            this.rbD10.TabIndex = 1;
            this.rbD10.TabStop = true;
            this.rbD10.Text = "D10";
            this.rbD10.UseVisualStyleBackColor = true;
            // 
            // rbD20
            // 
            this.rbD20.AutoSize = true;
            this.rbD20.Location = new System.Drawing.Point(6, 66);
            this.rbD20.Name = "rbD20";
            this.rbD20.Size = new System.Drawing.Size(45, 17);
            this.rbD20.TabIndex = 2;
            this.rbD20.TabStop = true;
            this.rbD20.Text = "D20";
            this.rbD20.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Throw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(211, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(67, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 31);
            this.lblResult.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(102, 74);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 132);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbSelectDice);
            this.Name = "frmMain";
            this.Text = "ThrowDice for Windows";
            this.gbSelectDice.ResumeLayout(false);
            this.gbSelectDice.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectDice;
        private System.Windows.Forms.RadioButton rbD20;
        private System.Windows.Forms.RadioButton rbD10;
        private System.Windows.Forms.RadioButton rbD6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbout;
    }
}

