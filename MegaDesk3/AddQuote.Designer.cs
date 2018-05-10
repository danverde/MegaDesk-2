namespace MegaDesk3
{
    partial class AddQuote
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
            this.closeAddQuoteButton = new System.Windows.Forms.Button();
            this.saveNewQuoteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeAddQuoteButton
            // 
            this.closeAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAddQuoteButton.Location = new System.Drawing.Point(539, 375);
            this.closeAddQuoteButton.Name = "closeAddQuoteButton";
            this.closeAddQuoteButton.Size = new System.Drawing.Size(100, 40);
            this.closeAddQuoteButton.TabIndex = 9;
            this.closeAddQuoteButton.Text = "Cancel";
            this.closeAddQuoteButton.UseVisualStyleBackColor = true;
            this.closeAddQuoteButton.Click += new System.EventHandler(this.closeAddQuoteButton_Click);
            // 
            // saveNewQuoteButton
            // 
            this.saveNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewQuoteButton.Location = new System.Drawing.Point(665, 375);
            this.saveNewQuoteButton.Name = "saveNewQuoteButton";
            this.saveNewQuoteButton.Size = new System.Drawing.Size(100, 40);
            this.saveNewQuoteButton.TabIndex = 10;
            this.saveNewQuoteButton.Text = "Save";
            this.saveNewQuoteButton.UseVisualStyleBackColor = true;
            this.saveNewQuoteButton.Click += new System.EventHandler(this.saveNewQuoteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(98, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 29);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(183, 59);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(228, 20);
            this.nameInput.TabIndex = 12;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveNewQuoteButton);
            this.Controls.Add(this.closeAddQuoteButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddQuoteButton;
        private System.Windows.Forms.Button saveNewQuoteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
    }
}