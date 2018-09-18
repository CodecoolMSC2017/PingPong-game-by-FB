namespace PingPongGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.title = new System.Windows.Forms.Label();
            this.totalscorelabel = new System.Windows.Forms.Label();
            this.totalscore = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.DarkRed;
            this.title.Location = new System.Drawing.Point(257, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(283, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Ping Pong game";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalscorelabel
            // 
            this.totalscorelabel.AutoSize = true;
            this.totalscorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalscorelabel.Location = new System.Drawing.Point(22, 36);
            this.totalscorelabel.Name = "totalscorelabel";
            this.totalscorelabel.Size = new System.Drawing.Size(128, 26);
            this.totalscorelabel.TabIndex = 1;
            this.totalscorelabel.Text = "Total Score:";
            // 
            // totalscore
            // 
            this.totalscore.AutoSize = true;
            this.totalscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalscore.Location = new System.Drawing.Point(156, 36);
            this.totalscore.Name = "totalscore";
            this.totalscore.Size = new System.Drawing.Size(36, 26);
            this.totalscore.TabIndex = 2;
            this.totalscore.Text = "00";
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.LawnGreen;
            this.easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easy.Location = new System.Drawing.Point(264, 182);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(276, 36);
            this.easy.TabIndex = 3;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.Orange;
            this.medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medium.Location = new System.Drawing.Point(264, 255);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(276, 36);
            this.medium.TabIndex = 4;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Red;
            this.hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hard.Location = new System.Drawing.Point(264, 327);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(276, 36);
            this.hard.TabIndex = 5;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Cart
            // 
            this.Cart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cart.Image = ((System.Drawing.Image)(resources.GetObject("Cart.Image")));
            this.Cart.Location = new System.Drawing.Point(637, 54);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(139, 138);
            this.Cart.TabIndex = 6;
            this.Cart.TabStop = false;
            this.Cart.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.totalscore);
            this.Controls.Add(this.totalscorelabel);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Ping Pong";
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label totalscorelabel;
        private System.Windows.Forms.Label totalscore;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.PictureBox Cart;
    }
}