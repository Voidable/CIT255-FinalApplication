namespace FinalApplication
{
    partial class GreetingForm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(12, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(152, 13);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Welcome to the List of Games!";
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Location = new System.Drawing.Point(12, 44);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(212, 13);
            this.lblDesc1.TabIndex = 1;
            this.lblDesc1.Text = "Within this program is a list of  video games!";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Location = new System.Drawing.Point(12, 67);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(341, 13);
            this.lblDesc2.TabIndex = 2;
            this.lblDesc2.Text = "There is some games added to it already, but feel free to add your own.";
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinue.Location = new System.Drawing.Point(12, 199);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(100, 50);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(572, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lblDesc1);
            this.Controls.Add(this.lblGreeting);
            this.MaximumSize = new System.Drawing.Size(700, 300);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
    }
}

