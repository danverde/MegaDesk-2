namespace MegaDesk3
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeMainMenuButon = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.newQuoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(312, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 316);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // closeMainMenuButon
            // 
            this.closeMainMenuButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMainMenuButon.Location = new System.Drawing.Point(57, 287);
            this.closeMainMenuButon.Name = "closeMainMenuButon";
            this.closeMainMenuButon.Size = new System.Drawing.Size(200, 50);
            this.closeMainMenuButon.TabIndex = 8;
            this.closeMainMenuButon.Text = "Exit";
            this.closeMainMenuButon.UseVisualStyleBackColor = true;
            this.closeMainMenuButon.Click += new System.EventHandler(this.CloseMainMenuButton_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButton.Location = new System.Drawing.Point(57, 197);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(200, 50);
            this.searchQuotesButton.TabIndex = 7;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesButton.Location = new System.Drawing.Point(57, 111);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(200, 50);
            this.viewQuotesButton.TabIndex = 6;
            this.viewQuotesButton.Text = "View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            this.viewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // newQuoteButton
            // 
            this.newQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteButton.Location = new System.Drawing.Point(57, 27);
            this.newQuoteButton.Name = "newQuoteButton";
            this.newQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.newQuoteButton.TabIndex = 5;
            this.newQuoteButton.Text = "Add New Quote";
            this.newQuoteButton.UseVisualStyleBackColor = true;
            this.newQuoteButton.Click += new System.EventHandler(this.newQuoteButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeMainMenuButon);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.newQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeMainMenuButon;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button newQuoteButton;
    }
}

