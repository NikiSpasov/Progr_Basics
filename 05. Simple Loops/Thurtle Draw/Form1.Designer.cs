namespace Thurtle_Draw
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
            this.button1 = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "DrawButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(50, 108);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "ResetButton";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(50, 192);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 2;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(50, 146);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 285);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Thurtle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ShowButton;
    }
}

