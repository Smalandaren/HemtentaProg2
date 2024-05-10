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
            this.orderTextBox = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderedLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderTextBox
            // 
            this.orderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.orderTextBox.Location = new System.Drawing.Point(548, 12);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.ReadOnly = true;
            this.orderTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.orderTextBox.Size = new System.Drawing.Size(240, 352);
            this.orderTextBox.TabIndex = 0;
            this.orderTextBox.Text = "";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(698, 408);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(90, 30);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Beställ";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderedLabel
            // 
            this.orderedLabel.AutoSize = true;
            this.orderedLabel.Location = new System.Drawing.Point(545, 367);
            this.orderedLabel.Name = "orderedLabel";
            this.orderedLabel.Size = new System.Drawing.Size(127, 13);
            this.orderedLabel.TabIndex = 2;
            this.orderedLabel.Text = "Din beställning är på väg!";
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
            this.clearButton.Location = new System.Drawing.Point(548, 408);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderedLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderTextBox);
            this.Name = "Form1";
            this.Text = "Resturangen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox orderTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label orderedLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

