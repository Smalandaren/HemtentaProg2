namespace HemtentaUppgift1
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
			this.SodaDropDown = new System.Windows.Forms.ComboBox();
			this.AmountDropDown = new System.Windows.Forms.ComboBox();
			this.SugarFreeCheck = new System.Windows.Forms.CheckBox();
			this.OrderButton = new System.Windows.Forms.Button();
			this.OrderTextBox = new System.Windows.Forms.RichTextBox();
			this.ErrorMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SodaDropDown
			// 
			this.SodaDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SodaDropDown.FormattingEnabled = true;
			this.SodaDropDown.Items.AddRange(new object[] {
            "Läsk",
            "Coca-Cola",
            "Pepsi",
            "Sprite",
            "7-Up",
            "Jarritos",
            "Fanta Apelsin",
            "Fanta Tropisk",
            "Fanta Grapefrukt"});
			this.SodaDropDown.Location = new System.Drawing.Point(20, 44);
			this.SodaDropDown.Name = "SodaDropDown";
			this.SodaDropDown.Size = new System.Drawing.Size(121, 21);
			this.SodaDropDown.TabIndex = 0;
			this.SodaDropDown.SelectedIndexChanged += new System.EventHandler(this.SodaDropDown_SelectedIndexChanged);
			// 
			// AmountDropDown
			// 
			this.AmountDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AmountDropDown.FormattingEnabled = true;
			this.AmountDropDown.Items.AddRange(new object[] {
            "Antal",
            "Back 4x4 - 160 kr",
            "Back 6x4 - 240 kr",
            "Back 6x6 - 360 kr"});
			this.AmountDropDown.Location = new System.Drawing.Point(20, 122);
			this.AmountDropDown.Name = "AmountDropDown";
			this.AmountDropDown.Size = new System.Drawing.Size(121, 21);
			this.AmountDropDown.TabIndex = 1;
			this.AmountDropDown.SelectedIndexChanged += new System.EventHandler(this.AmountDropDown_SelectedIndexChanged);
			// 
			// SugarFreeCheck
			// 
			this.SugarFreeCheck.AutoSize = true;
			this.SugarFreeCheck.Location = new System.Drawing.Point(20, 84);
			this.SugarFreeCheck.Name = "SugarFreeCheck";
			this.SugarFreeCheck.Size = new System.Drawing.Size(68, 17);
			this.SugarFreeCheck.TabIndex = 2;
			this.SugarFreeCheck.Text = "Sockerfri";
			this.SugarFreeCheck.UseVisualStyleBackColor = true;
			this.SugarFreeCheck.CheckedChanged += new System.EventHandler(this.SugarFreeCheck_CheckedChanged);
			// 
			// OrderButton
			// 
			this.OrderButton.Location = new System.Drawing.Point(20, 172);
			this.OrderButton.Name = "OrderButton";
			this.OrderButton.Size = new System.Drawing.Size(121, 48);
			this.OrderButton.TabIndex = 3;
			this.OrderButton.Text = "Beställ";
			this.OrderButton.UseVisualStyleBackColor = true;
			this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// OrderTextBox
			// 
			this.OrderTextBox.Location = new System.Drawing.Point(162, 44);
			this.OrderTextBox.Name = "OrderTextBox";
			this.OrderTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.OrderTextBox.Size = new System.Drawing.Size(249, 299);
			this.OrderTextBox.TabIndex = 4;
			this.OrderTextBox.Text = "";
			this.OrderTextBox.TextChanged += new System.EventHandler(this.OrderTextBox_TextChanged);
			// 
			// ErrorMessage
			// 
			this.ErrorMessage.AutoSize = true;
			this.ErrorMessage.Location = new System.Drawing.Point(35, 232);
			this.ErrorMessage.Name = "ErrorMessage";
			this.ErrorMessage.Size = new System.Drawing.Size(94, 13);
			this.ErrorMessage.TabIndex = 5;
			this.ErrorMessage.Text = "Du måste fylla i allt";
			this.ErrorMessage.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 415);
			this.Controls.Add(this.ErrorMessage);
			this.Controls.Add(this.OrderTextBox);
			this.Controls.Add(this.OrderButton);
			this.Controls.Add(this.SugarFreeCheck);
			this.Controls.Add(this.AmountDropDown);
			this.Controls.Add(this.SodaDropDown);
			this.Name = "Form1";
			this.Text = "Läskbeställare";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox SodaDropDown;
		private System.Windows.Forms.ComboBox AmountDropDown;
		private System.Windows.Forms.CheckBox SugarFreeCheck;
		private System.Windows.Forms.Button OrderButton;
		private System.Windows.Forms.RichTextBox OrderTextBox;
		private System.Windows.Forms.Label ErrorMessage;
	}
}

