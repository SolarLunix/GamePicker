namespace GamePicker
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
            this.AllGames = new System.Windows.Forms.Button();
            this.addGameBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllGames
            // 
            this.AllGames.Location = new System.Drawing.Point(12, 218);
            this.AllGames.Name = "AllGames";
            this.AllGames.Size = new System.Drawing.Size(260, 31);
            this.AllGames.TabIndex = 0;
            this.AllGames.Text = "See Games";
            this.AllGames.UseVisualStyleBackColor = true;
            this.AllGames.Click += new System.EventHandler(this.AllGames_Click);
            // 
            // addGameBTN
            // 
            this.addGameBTN.Location = new System.Drawing.Point(12, 12);
            this.addGameBTN.Name = "addGameBTN";
            this.addGameBTN.Size = new System.Drawing.Size(260, 31);
            this.addGameBTN.TabIndex = 1;
            this.addGameBTN.Text = "Add Game";
            this.addGameBTN.UseVisualStyleBackColor = true;
            this.addGameBTN.Click += new System.EventHandler(this.addGameBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.addGameBTN);
            this.Controls.Add(this.AllGames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllGames;
        private System.Windows.Forms.Button addGameBTN;
    }
}

