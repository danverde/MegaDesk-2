namespace MegaDesk4
{
    partial class SearchQuotes
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
            this.CloseSearchQuotesButton = new System.Windows.Forms.Button();
            this.SearchAll = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAll)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseSearchQuotesButton
            // 
            this.CloseSearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSearchQuotesButton.Location = new System.Drawing.Point(1392, 851);
            this.CloseSearchQuotesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseSearchQuotesButton.Name = "CloseSearchQuotesButton";
            this.CloseSearchQuotesButton.Size = new System.Drawing.Size(183, 74);
            this.CloseSearchQuotesButton.TabIndex = 11;
            this.CloseSearchQuotesButton.Text = "Close";
            this.CloseSearchQuotesButton.UseVisualStyleBackColor = true;
            this.CloseSearchQuotesButton.Click += new System.EventHandler(this.CloseSearchQuotesButton_Click);
            // 
            // SearchAll
            // 
            this.SearchAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchAll.Location = new System.Drawing.Point(22, 142);
            this.SearchAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(1547, 676);
            this.SearchAll.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(391, 46);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(194, 65);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(596, 57);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 48);
            this.MessageLabel.TabIndex = 15;
            // 
            // SearchBox
            // 
            this.SearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(22, 42);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(329, 56);
            this.SearchBox.TabIndex = 16;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 958);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchAll);
            this.Controls.Add(this.CloseSearchQuotesButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SearchAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseSearchQuotesButton;
        private System.Windows.Forms.DataGridView SearchAll;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ComboBox SearchBox;
    }
}