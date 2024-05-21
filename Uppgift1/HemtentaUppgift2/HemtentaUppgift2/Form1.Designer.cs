namespace HemtentaUppgift2
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
			this.BookButton = new System.Windows.Forms.Button();
			this.MovieSelector = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// BookButton
			// 
			this.BookButton.Location = new System.Drawing.Point(916, 476);
			this.BookButton.Name = "BookButton";
			this.BookButton.Size = new System.Drawing.Size(139, 66);
			this.BookButton.TabIndex = 0;
			this.BookButton.Text = "Boka";
			this.BookButton.UseVisualStyleBackColor = true;
			this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
			// 
			// MovieSelector
			// 
			this.MovieSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MovieSelector.FormattingEnabled = true;
			this.MovieSelector.Items.AddRange(new object[] {
            "Fall Guy",
            "Boy Kills World"});
			this.MovieSelector.Location = new System.Drawing.Point(12, 498);
			this.MovieSelector.Name = "MovieSelector";
			this.MovieSelector.Size = new System.Drawing.Size(180, 24);
			this.MovieSelector.TabIndex = 1;
			this.MovieSelector.SelectedIndexChanged += new System.EventHandler(this.MovieSelector_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.MovieSelector);
			this.Controls.Add(this.BookButton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button BookButton;
		private System.Windows.Forms.ComboBox MovieSelector;
	}
}

