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
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.DimensionsGroup = new System.Windows.Forms.GroupBox();
            this.DepthInput = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.MaterialInput = new System.Windows.Forms.ComboBox();
            this.RushDaysLabel = new System.Windows.Forms.Label();
            this.RushOrderInput = new System.Windows.Forms.ComboBox();
            this.DimensionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAddQuoteButton
            // 
            this.closeAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAddQuoteButton.Location = new System.Drawing.Point(274, 277);
            this.closeAddQuoteButton.Name = "closeAddQuoteButton";
            this.closeAddQuoteButton.Size = new System.Drawing.Size(100, 40);
            this.closeAddQuoteButton.TabIndex = 7;
            this.closeAddQuoteButton.Text = "Cancel";
            this.closeAddQuoteButton.UseVisualStyleBackColor = true;
            this.closeAddQuoteButton.Click += new System.EventHandler(this.closeAddQuoteButton_Click);
            // 
            // saveNewQuoteButton
            // 
            this.saveNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewQuoteButton.Location = new System.Drawing.Point(405, 277);
            this.saveNewQuoteButton.Name = "saveNewQuoteButton";
            this.saveNewQuoteButton.Size = new System.Drawing.Size(100, 40);
            this.saveNewQuoteButton.TabIndex = 8;
            this.saveNewQuoteButton.Text = "Save";
            this.saveNewQuoteButton.UseVisualStyleBackColor = true;
            this.saveNewQuoteButton.Click += new System.EventHandler(this.saveNewQuoteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(37, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 24);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Customer Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // customerNameInput
            // 
            this.customerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameInput.Location = new System.Drawing.Point(197, 26);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(228, 29);
            this.customerNameInput.TabIndex = 1;
            this.customerNameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // DimensionsGroup
            // 
            this.DimensionsGroup.Controls.Add(this.DepthInput);
            this.DimensionsGroup.Controls.Add(this.DepthLabel);
            this.DimensionsGroup.Controls.Add(this.WidthLabel);
            this.DimensionsGroup.Controls.Add(this.WidthInput);
            this.DimensionsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimensionsGroup.Location = new System.Drawing.Point(42, 165);
            this.DimensionsGroup.Name = "DimensionsGroup";
            this.DimensionsGroup.Size = new System.Drawing.Size(212, 152);
            this.DimensionsGroup.TabIndex = 3;
            this.DimensionsGroup.TabStop = false;
            this.DimensionsGroup.Text = "Dimensions";
            // 
            // DepthInput
            // 
            this.DepthInput.Location = new System.Drawing.Point(104, 91);
            this.DepthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(77, 29);
            this.DepthInput.TabIndex = 5;
            this.DepthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(12, 96);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(60, 24);
            this.DepthLabel.TabIndex = 2;
            this.DepthLabel.Text = "Depth";
            this.DepthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(10, 43);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(58, 24);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(104, 38);
            this.WidthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(77, 29);
            this.WidthInput.TabIndex = 4;
            this.WidthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(37, 90);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(75, 24);
            this.MaterialLabel.TabIndex = 15;
            this.MaterialLabel.Text = "Material";
            // 
            // MaterialInput
            // 
            this.MaterialInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialInput.FormattingEnabled = true;
            this.MaterialInput.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.MaterialInput.Location = new System.Drawing.Point(197, 88);
            this.MaterialInput.Name = "MaterialInput";
            this.MaterialInput.Size = new System.Drawing.Size(228, 32);
            this.MaterialInput.TabIndex = 2;
            // 
            // RushDaysLabel
            // 
            this.RushDaysLabel.AutoSize = true;
            this.RushDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDaysLabel.Location = new System.Drawing.Point(260, 165);
            this.RushDaysLabel.Name = "RushDaysLabel";
            this.RushDaysLabel.Size = new System.Drawing.Size(108, 24);
            this.RushDaysLabel.TabIndex = 17;
            this.RushDaysLabel.Text = "Rush Order";
            this.RushDaysLabel.Click += new System.EventHandler(this.RushDaysLabel_Click);
            // 
            // RushOrderInput
            // 
            this.RushOrderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushOrderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderInput.FormattingEnabled = true;
            this.RushOrderInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.RushOrderInput.Location = new System.Drawing.Point(380, 160);
            this.RushOrderInput.Name = "RushOrderInput";
            this.RushOrderInput.Size = new System.Drawing.Size(121, 32);
            this.RushOrderInput.TabIndex = 6;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 366);
            this.Controls.Add(this.RushOrderInput);
            this.Controls.Add(this.RushDaysLabel);
            this.Controls.Add(this.MaterialInput);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DimensionsGroup);
            this.Controls.Add(this.customerNameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveNewQuoteButton);
            this.Controls.Add(this.closeAddQuoteButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.DimensionsGroup.ResumeLayout(false);
            this.DimensionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddQuoteButton;
        private System.Windows.Forms.Button saveNewQuoteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.GroupBox DimensionsGroup;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.ComboBox MaterialInput;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown DepthInput;
        private System.Windows.Forms.Label RushDaysLabel;
        private System.Windows.Forms.ComboBox RushOrderInput;
    }
}