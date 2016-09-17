namespace standardArcade
{
    partial class standardArcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(standardArcade));
            this.playButton = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.packMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(59, 26);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(153, 62);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.Black;
            this.countdown.Location = new System.Drawing.Point(31, 198);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(133, 20);
            this.countdown.TabIndex = 1;
            this.countdown.Text = "Game will start in:";
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.Black;
            this.go.Location = new System.Drawing.Point(115, 129);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(49, 24);
            this.go.TabIndex = 2;
            this.go.Text = "GO!!";
            // 
            // packMan
            // 
            this.packMan.BackColor = System.Drawing.Color.Black;
            this.packMan.Location = new System.Drawing.Point(41, 143);
            this.packMan.Name = "packMan";
            this.packMan.Size = new System.Drawing.Size(75, 23);
            this.packMan.TabIndex = 3;
            this.packMan.Text = "RUN";
            this.packMan.UseVisualStyleBackColor = false;
            this.packMan.Click += new System.EventHandler(this.packMan_Click);
            // 
            // standardArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.packMan);
            this.Controls.Add(this.go);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "standardArcade";
            this.Text = "standardArcade";
            this.Load += new System.EventHandler(this.standardArcade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label go;
        private System.Windows.Forms.Button packMan;
    }
}

