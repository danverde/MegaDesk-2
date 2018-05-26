namespace MegaDesk4
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            this.CloseViewAllQuotesButton = new System.Windows.Forms.Button();
            this.viewAll = new System.Windows.Forms.DataGridView();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoteDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseViewAllQuotesButton
            // 
            this.CloseViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseViewAllQuotesButton.Location = new System.Drawing.Point(1364, 735);
            this.CloseViewAllQuotesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseViewAllQuotesButton.Name = "CloseViewAllQuotesButton";
            this.CloseViewAllQuotesButton.Size = new System.Drawing.Size(183, 74);
            this.CloseViewAllQuotesButton.TabIndex = 10;
            this.CloseViewAllQuotesButton.Text = "Close";
            this.CloseViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.CloseViewAllQuotesButton.Click += new System.EventHandler(this.CloseViewAllQuotesButton_Click);
            // 
            // viewAll
            // 
            this.viewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAll.Location = new System.Drawing.Point(0, 22);
            this.viewAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(1547, 676);
            this.viewAll.TabIndex = 11;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(24, 735);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 48);
            this.MessageLabel.TabIndex = 12;
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataSource = typeof(MegaDesk4.Desk.Surface);
            // 
            // quoteDataBindingSource
            // 
            this.quoteDataBindingSource.DataSource = typeof(MegaDesk4.QuoteData);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 831);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.CloseViewAllQuotesButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ViewAllQuotes";
            this.Text = "View Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.viewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseViewAllQuotesButton;
        private System.Windows.Forms.DataGridView viewAll;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        private System.Windows.Forms.BindingSource quoteDataBindingSource;
    }
}