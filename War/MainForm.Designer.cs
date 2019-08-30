namespace War
{
    partial class MainForm
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
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.btnReflect = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ComputerBox = new System.Windows.Forms.GroupBox();
            this.lblComputerMove = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.PlayerBox.SuspendLayout();
            this.ComputerBox.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerBox
            // 
            this.PlayerBox.Controls.Add(this.btnReflect);
            this.PlayerBox.Controls.Add(this.btnBlock);
            this.PlayerBox.Controls.Add(this.btnShoot);
            this.PlayerBox.Controls.Add(this.btnLoad);
            this.PlayerBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(126, 142);
            this.PlayerBox.TabIndex = 1;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Your Move";
            // 
            // btnReflect
            // 
            this.btnReflect.Location = new System.Drawing.Point(6, 105);
            this.btnReflect.Name = "btnReflect";
            this.btnReflect.Size = new System.Drawing.Size(111, 23);
            this.btnReflect.TabIndex = 3;
            this.btnReflect.Text = "Reflect";
            this.btnReflect.UseVisualStyleBackColor = true;
            this.btnReflect.Click += new System.EventHandler(this.btnReflect_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(6, 77);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(111, 23);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(6, 48);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(111, 23);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(111, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ComputerBox
            // 
            this.ComputerBox.Controls.Add(this.lblComputerMove);
            this.ComputerBox.Location = new System.Drawing.Point(144, 12);
            this.ComputerBox.Name = "ComputerBox";
            this.ComputerBox.Size = new System.Drawing.Size(126, 142);
            this.ComputerBox.TabIndex = 2;
            this.ComputerBox.TabStop = false;
            this.ComputerBox.Text = "Computer Move";
            // 
            // lblComputerMove
            // 
            this.lblComputerMove.AutoSize = true;
            this.lblComputerMove.Location = new System.Drawing.Point(7, 20);
            this.lblComputerMove.Name = "lblComputerMove";
            this.lblComputerMove.Size = new System.Drawing.Size(79, 13);
            this.lblComputerMove.TabIndex = 0;
            this.lblComputerMove.Text = "You\'ll find out...";
            // 
            // StatusBox
            // 
            this.StatusBox.Controls.Add(this.btnPlayAgain);
            this.StatusBox.Controls.Add(this.lblStatus);
            this.StatusBox.Location = new System.Drawing.Point(274, 12);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(126, 142);
            this.StatusBox.TabIndex = 3;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Status";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.Location = new System.Drawing.Point(9, 105);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Time to play!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 167);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ComputerBox);
            this.Controls.Add(this.PlayerBox);
            this.Name = "MainForm";
            this.Text = "War";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayerBox.ResumeLayout(false);
            this.ComputerBox.ResumeLayout(false);
            this.ComputerBox.PerformLayout();
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Button btnReflect;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox ComputerBox;
        private System.Windows.Forms.GroupBox StatusBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblComputerMove;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

