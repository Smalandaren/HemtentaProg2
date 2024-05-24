namespace HemtentaUppgift3
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
			this.orderButton = new System.Windows.Forms.Button();
			this.orderedLabel = new System.Windows.Forms.Label();
			this.totalLabel = new System.Windows.Forms.Label();
			this.clearButton = new System.Windows.Forms.Button();
			this.orderBox = new System.Windows.Forms.ListBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.MainLabel = new System.Windows.Forms.Label();
			this.DessertLabel = new System.Windows.Forms.Label();
			this.DrinkLabel = new System.Windows.Forms.Label();
			this.funLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// orderButton
			// 
			this.orderButton.Location = new System.Drawing.Point(698, 425);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(90, 30);
			this.orderButton.TabIndex = 1;
			this.orderButton.Text = "Beställ";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// orderedLabel
			// 
			this.orderedLabel.AutoSize = true;
			this.orderedLabel.Location = new System.Drawing.Point(545, 363);
			this.orderedLabel.Name = "orderedLabel";
			this.orderedLabel.Size = new System.Drawing.Size(130, 13);
			this.orderedLabel.TabIndex = 2;
			this.orderedLabel.Text = "Din beställning är på väg! ";
			this.orderedLabel.Visible = false;
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Location = new System.Drawing.Point(545, 380);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(0, 13);
			this.totalLabel.TabIndex = 3;
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(12, 425);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(90, 30);
			this.clearButton.TabIndex = 4;
			this.clearButton.Text = "Rensa";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// orderBox
			// 
			this.orderBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderBox.FormattingEnabled = true;
			this.orderBox.ItemHeight = 14;
			this.orderBox.Location = new System.Drawing.Point(548, 12);
			this.orderBox.Name = "orderBox";
			this.orderBox.Size = new System.Drawing.Size(240, 340);
			this.orderBox.TabIndex = 5;
			this.orderBox.SelectedIndexChanged += new System.EventHandler(this.orderBox_SelectedIndexChanged);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(548, 425);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(90, 30);
			this.removeButton.TabIndex = 6;
			this.removeButton.Text = "Ta bort";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// MainLabel
			// 
			this.MainLabel.AutoSize = true;
			this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.MainLabel.Location = new System.Drawing.Point(30, 57);
			this.MainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MainLabel.Name = "MainLabel";
			this.MainLabel.Size = new System.Drawing.Size(106, 26);
			this.MainLabel.TabIndex = 7;
			this.MainLabel.Text = "Huvudrätt";
			// 
			// DessertLabel
			// 
			this.DessertLabel.AutoSize = true;
			this.DessertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.DessertLabel.Location = new System.Drawing.Point(30, 158);
			this.DessertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DessertLabel.Name = "DessertLabel";
			this.DessertLabel.Size = new System.Drawing.Size(89, 26);
			this.DessertLabel.TabIndex = 8;
			this.DessertLabel.Text = "Efterrätt";
			// 
			// DrinkLabel
			// 
			this.DrinkLabel.AutoSize = true;
			this.DrinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.DrinkLabel.Location = new System.Drawing.Point(30, 260);
			this.DrinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DrinkLabel.Name = "DrinkLabel";
			this.DrinkLabel.Size = new System.Drawing.Size(74, 26);
			this.DrinkLabel.TabIndex = 9;
			this.DrinkLabel.Text = "Dricka";
			// 
			// funLabel
			// 
			this.funLabel.AutoSize = true;
			this.funLabel.Location = new System.Drawing.Point(545, 409);
			this.funLabel.Name = "funLabel";
			this.funLabel.Size = new System.Drawing.Size(156, 13);
			this.funLabel.TabIndex = 10;
			this.funLabel.Text = "Ha det så kult på restaurangen!";
			this.funLabel.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 467);
			this.Controls.Add(this.funLabel);
			this.Controls.Add(this.DrinkLabel);
			this.Controls.Add(this.DessertLabel);
			this.Controls.Add(this.MainLabel);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.orderBox);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.orderedLabel);
			this.Controls.Add(this.orderButton);
			this.Name = "Form1";
			this.Text = "Resturangen";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label orderedLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox orderBox;
        private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Label MainLabel;
		private System.Windows.Forms.Label DessertLabel;
		private System.Windows.Forms.Label DrinkLabel;
		private System.Windows.Forms.Label funLabel;
	}
}

