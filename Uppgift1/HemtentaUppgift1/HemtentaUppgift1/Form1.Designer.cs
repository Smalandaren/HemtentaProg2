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
			this.ErrorMessage = new System.Windows.Forms.Label();
			this.OutputBox = new System.Windows.Forms.ListBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
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
			this.OrderButton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
			this.OrderButton.Location = new System.Drawing.Point(20, 172);
			this.OrderButton.Name = "OrderButton";
			this.OrderButton.Size = new System.Drawing.Size(121, 48);
			this.OrderButton.TabIndex = 3;
			this.OrderButton.Text = "Beställ";
			this.OrderButton.UseVisualStyleBackColor = true;
			this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
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
			// OutputBox
			// 
			this.OutputBox.FormattingEnabled = true;
			this.OutputBox.Location = new System.Drawing.Point(171, 44);
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.Size = new System.Drawing.Size(249, 329);
			this.OutputBox.TabIndex = 6;
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(20, 342);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(77, 31);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Rensa";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(20, 305);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(77, 31);
			this.RemoveButton.TabIndex = 8;
			this.RemoveButton.Text = "Ta Bort";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 431);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.OutputBox);
			this.Controls.Add(this.ErrorMessage);
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
		private System.Windows.Forms.Label ErrorMessage;
		private System.Windows.Forms.ListBox OutputBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button RemoveButton;
	}
}

