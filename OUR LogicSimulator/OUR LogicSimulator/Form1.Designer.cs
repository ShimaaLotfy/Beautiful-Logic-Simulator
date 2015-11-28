namespace OUR_LogicSimulator
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
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input3 = new System.Windows.Forms.TextBox();
            this.Out = new System.Windows.Forms.TextBox();
            this.Out2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(23, 33);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 0;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(23, 78);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 1;
            // 
            // Input3
            // 
            this.Input3.Location = new System.Drawing.Point(143, 120);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(100, 20);
            this.Input3.TabIndex = 2;
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(143, 54);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(100, 20);
            this.Out.TabIndex = 3;
            // 
            // Out2
            // 
            this.Out2.Location = new System.Drawing.Point(256, 89);
            this.Out2.Name = "Out2";
            this.Out2.Size = new System.Drawing.Size(100, 20);
            this.Out2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Out2);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input3;
        private System.Windows.Forms.TextBox Out;
        private System.Windows.Forms.TextBox Out2;
        private System.Windows.Forms.Button button1;
    }
}

