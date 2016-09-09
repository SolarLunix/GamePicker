namespace GamePicker
{
    partial class AddGame
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
            this.platformLBL = new System.Windows.Forms.Label();
            this.pcGameCheck = new System.Windows.Forms.CheckBox();
            this.xBox360GameCheck = new System.Windows.Forms.CheckBox();
            this.gameNameLbl = new System.Windows.Forms.Label();
            this.gameNameInput = new System.Windows.Forms.TextBox();
            this.attributesLBL = new System.Windows.Forms.Label();
            this.onlineMultiCheck = new System.Windows.Forms.CheckBox();
            this.loclalMulitCheck = new System.Windows.Forms.CheckBox();
            this.addGameBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // platformLBL
            // 
            this.platformLBL.AutoSize = true;
            this.platformLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLBL.Location = new System.Drawing.Point(12, 9);
            this.platformLBL.Name = "platformLBL";
            this.platformLBL.Size = new System.Drawing.Size(106, 25);
            this.platformLBL.TabIndex = 0;
            this.platformLBL.Text = "Platform:";
            // 
            // pcGameCheck
            // 
            this.pcGameCheck.AutoSize = true;
            this.pcGameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcGameCheck.Location = new System.Drawing.Point(17, 37);
            this.pcGameCheck.Name = "pcGameCheck";
            this.pcGameCheck.Size = new System.Drawing.Size(49, 24);
            this.pcGameCheck.TabIndex = 1;
            this.pcGameCheck.Text = "PC";
            this.pcGameCheck.UseVisualStyleBackColor = true;
            // 
            // xBox360GameCheck
            // 
            this.xBox360GameCheck.AutoSize = true;
            this.xBox360GameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xBox360GameCheck.Location = new System.Drawing.Point(123, 37);
            this.xBox360GameCheck.Name = "xBox360GameCheck";
            this.xBox360GameCheck.Size = new System.Drawing.Size(91, 24);
            this.xBox360GameCheck.TabIndex = 2;
            this.xBox360GameCheck.Text = "Xbox360";
            this.xBox360GameCheck.UseVisualStyleBackColor = true;
            // 
            // gameNameLbl
            // 
            this.gameNameLbl.AutoSize = true;
            this.gameNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLbl.Location = new System.Drawing.Point(12, 78);
            this.gameNameLbl.Name = "gameNameLbl";
            this.gameNameLbl.Size = new System.Drawing.Size(80, 25);
            this.gameNameLbl.TabIndex = 3;
            this.gameNameLbl.Text = "Game:";
            // 
            // gameNameInput
            // 
            this.gameNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameInput.Location = new System.Drawing.Point(17, 106);
            this.gameNameInput.Name = "gameNameInput";
            this.gameNameInput.Size = new System.Drawing.Size(280, 26);
            this.gameNameInput.TabIndex = 4;
            // 
            // attributesLBL
            // 
            this.attributesLBL.AutoSize = true;
            this.attributesLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLBL.Location = new System.Drawing.Point(12, 149);
            this.attributesLBL.Name = "attributesLBL";
            this.attributesLBL.Size = new System.Drawing.Size(120, 25);
            this.attributesLBL.TabIndex = 5;
            this.attributesLBL.Text = "Attributes:";
            // 
            // onlineMultiCheck
            // 
            this.onlineMultiCheck.AutoSize = true;
            this.onlineMultiCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineMultiCheck.Location = new System.Drawing.Point(168, 177);
            this.onlineMultiCheck.Name = "onlineMultiCheck";
            this.onlineMultiCheck.Size = new System.Drawing.Size(152, 24);
            this.onlineMultiCheck.TabIndex = 7;
            this.onlineMultiCheck.Text = "Online Multiplayer";
            this.onlineMultiCheck.UseVisualStyleBackColor = true;
            // 
            // loclalMulitCheck
            // 
            this.loclalMulitCheck.AutoSize = true;
            this.loclalMulitCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loclalMulitCheck.Location = new System.Drawing.Point(17, 177);
            this.loclalMulitCheck.Name = "loclalMulitCheck";
            this.loclalMulitCheck.Size = new System.Drawing.Size(145, 24);
            this.loclalMulitCheck.TabIndex = 6;
            this.loclalMulitCheck.Text = "Local Multiplayer";
            this.loclalMulitCheck.UseVisualStyleBackColor = true;
            // 
            // addGameBtn
            // 
            this.addGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameBtn.Location = new System.Drawing.Point(12, 415);
            this.addGameBtn.Name = "addGameBtn";
            this.addGameBtn.Size = new System.Drawing.Size(116, 28);
            this.addGameBtn.TabIndex = 8;
            this.addGameBtn.Text = "Add Game";
            this.addGameBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(194, 415);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 28);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(322, 455);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addGameBtn);
            this.Controls.Add(this.onlineMultiCheck);
            this.Controls.Add(this.loclalMulitCheck);
            this.Controls.Add(this.attributesLBL);
            this.Controls.Add(this.gameNameInput);
            this.Controls.Add(this.gameNameLbl);
            this.Controls.Add(this.xBox360GameCheck);
            this.Controls.Add(this.pcGameCheck);
            this.Controls.Add(this.platformLBL);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label platformLBL;
        private System.Windows.Forms.CheckBox pcGameCheck;
        private System.Windows.Forms.CheckBox xBox360GameCheck;
        private System.Windows.Forms.Label gameNameLbl;
        private System.Windows.Forms.TextBox gameNameInput;
        private System.Windows.Forms.Label attributesLBL;
        private System.Windows.Forms.CheckBox onlineMultiCheck;
        private System.Windows.Forms.CheckBox loclalMulitCheck;
        private System.Windows.Forms.Button addGameBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}