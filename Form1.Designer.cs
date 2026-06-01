namespace Fruit_Stand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bananaPic = new System.Windows.Forms.PictureBox();
            this.applePic = new System.Windows.Forms.PictureBox();
            this.orangePic = new System.Windows.Forms.PictureBox();
            this.pearPic = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.runTotal = new System.Windows.Forms.Label();
            this.applePrice = new System.Windows.Forms.TextBox();
            this.bananaPrice = new System.Windows.Forms.TextBox();
            this.orangePrice = new System.Windows.Forms.TextBox();
            this.pearPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bananaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bananaPic
            // 
            this.bananaPic.Image = ((System.Drawing.Image)(resources.GetObject("bananaPic.Image")));
            this.bananaPic.Location = new System.Drawing.Point(100, 106);
            this.bananaPic.Name = "bananaPic";
            this.bananaPic.Size = new System.Drawing.Size(128, 128);
            this.bananaPic.TabIndex = 0;
            this.bananaPic.TabStop = false;
            this.bananaPic.Click += new System.EventHandler(this.bananaPic_Click);
            // 
            // applePic
            // 
            this.applePic.Image = ((System.Drawing.Image)(resources.GetObject("applePic.Image")));
            this.applePic.Location = new System.Drawing.Point(298, 106);
            this.applePic.Name = "applePic";
            this.applePic.Size = new System.Drawing.Size(128, 128);
            this.applePic.TabIndex = 1;
            this.applePic.TabStop = false;
            this.applePic.Click += new System.EventHandler(this.applePic_Click_1);
            // 
            // orangePic
            // 
            this.orangePic.Image = ((System.Drawing.Image)(resources.GetObject("orangePic.Image")));
            this.orangePic.Location = new System.Drawing.Point(100, 288);
            this.orangePic.Name = "orangePic";
            this.orangePic.Size = new System.Drawing.Size(128, 127);
            this.orangePic.TabIndex = 2;
            this.orangePic.TabStop = false;
            this.orangePic.Click += new System.EventHandler(this.orangePic_Click_1);
            // 
            // pearPic
            // 
            this.pearPic.Image = ((System.Drawing.Image)(resources.GetObject("pearPic.Image")));
            this.pearPic.Location = new System.Drawing.Point(298, 288);
            this.pearPic.Name = "pearPic";
            this.pearPic.Size = new System.Drawing.Size(128, 127);
            this.pearPic.TabIndex = 3;
            this.pearPic.TabStop = false;
            this.pearPic.Click += new System.EventHandler(this.pearPic_Click_1);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(652, 330);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(652, 378);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(651, 106);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(76, 29);
            this.totalLbl.TabIndex = 6;
            this.totalLbl.Text = "$0.00";
            // 
            // runTotal
            // 
            this.runTotal.AutoSize = true;
            this.runTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runTotal.Location = new System.Drawing.Point(646, 60);
            this.runTotal.Name = "runTotal";
            this.runTotal.Size = new System.Drawing.Size(80, 31);
            this.runTotal.TabIndex = 7;
            this.runTotal.Text = "Total";
            // 
            // applePrice
            // 
            this.applePrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.applePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applePrice.ForeColor = System.Drawing.SystemColors.Window;
            this.applePrice.Location = new System.Drawing.Point(298, 230);
            this.applePrice.Name = "applePrice";
            this.applePrice.Size = new System.Drawing.Size(128, 26);
            this.applePrice.TabIndex = 9;
            this.applePrice.Text = "1.35 per pound";
            // 
            // bananaPrice
            // 
            this.bananaPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bananaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bananaPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.bananaPrice.Location = new System.Drawing.Point(100, 230);
            this.bananaPrice.Name = "bananaPrice";
            this.bananaPrice.Size = new System.Drawing.Size(128, 26);
            this.bananaPrice.TabIndex = 10;
            this.bananaPrice.Text = "65¢ per pound";
            // 
            // orangePrice
            // 
            this.orangePrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.orangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangePrice.ForeColor = System.Drawing.SystemColors.Window;
            this.orangePrice.Location = new System.Drawing.Point(100, 413);
            this.orangePrice.Name = "orangePrice";
            this.orangePrice.Size = new System.Drawing.Size(128, 26);
            this.orangePrice.TabIndex = 11;
            this.orangePrice.Text = "1.60 per pound";
            // 
            // pearPrice
            // 
            this.pearPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pearPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pearPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.pearPrice.Location = new System.Drawing.Point(298, 413);
            this.pearPrice.Name = "pearPrice";
            this.pearPrice.Size = new System.Drawing.Size(128, 26);
            this.pearPrice.TabIndex = 12;
            this.pearPrice.Text = "1.20 per pound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pearPrice);
            this.Controls.Add(this.orangePrice);
            this.Controls.Add(this.bananaPrice);
            this.Controls.Add(this.applePrice);
            this.Controls.Add(this.runTotal);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.pearPic);
            this.Controls.Add(this.orangePic);
            this.Controls.Add(this.applePic);
            this.Controls.Add(this.bananaPic);
            this.Name = "Form1";
            this.Text = "Fruit Stand";
            ((System.ComponentModel.ISupportInitialize)(this.bananaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaPic;
        private System.Windows.Forms.PictureBox applePic;
        private System.Windows.Forms.PictureBox orangePic;
        private System.Windows.Forms.PictureBox pearPic;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label runTotal;
        private System.Windows.Forms.TextBox applePrice;
        private System.Windows.Forms.TextBox bananaPrice;
        private System.Windows.Forms.TextBox orangePrice;
        private System.Windows.Forms.TextBox pearPrice;
    }
}

