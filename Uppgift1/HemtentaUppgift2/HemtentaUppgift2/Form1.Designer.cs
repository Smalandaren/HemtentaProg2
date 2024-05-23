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
			this.ChooseSeatLabel = new System.Windows.Forms.Label();
			this.ChooseMovieLabel = new System.Windows.Forms.Label();
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
			this.MovieSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.MovieSelector.FormattingEnabled = true;
			this.MovieSelector.Items.AddRange(new object[] {
            "Fall Guy",
            "Boy Kills World"});
			this.MovieSelector.Location = new System.Drawing.Point(12, 497);
			this.MovieSelector.Name = "MovieSelector";
			this.MovieSelector.Size = new System.Drawing.Size(199, 28);
			this.MovieSelector.TabIndex = 1;
			this.MovieSelector.SelectedIndexChanged += new System.EventHandler(this.MovieSelector_SelectedIndexChanged);
			// 
			// ChooseSeatLabel
			// 
			this.ChooseSeatLabel.AutoSize = true;
			this.ChooseSeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.ChooseSeatLabel.Location = new System.Drawing.Point(324, 17);
			this.ChooseSeatLabel.Name = "ChooseSeatLabel";
			this.ChooseSeatLabel.Size = new System.Drawing.Size(444, 39);
			this.ChooseSeatLabel.TabIndex = 2;
			this.ChooseSeatLabel.Text = "Välj vilka platser du vill boka";
			// 
			// ChooseMovieLabel
			// 
			this.ChooseMovieLabel.AutoSize = true;
			this.ChooseMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.ChooseMovieLabel.Location = new System.Drawing.Point(12, 463);
			this.ChooseMovieLabel.Name = "ChooseMovieLabel";
			this.ChooseMovieLabel.Size = new System.Drawing.Size(108, 31);
			this.ChooseMovieLabel.TabIndex = 3;
			this.ChooseMovieLabel.Text = "Välj film";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.ChooseMovieLabel);
			this.Controls.Add(this.ChooseSeatLabel);
			this.Controls.Add(this.MovieSelector);
			this.Controls.Add(this.BookButton);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button BookButton;
		private System.Windows.Forms.ComboBox MovieSelector;
		private System.Windows.Forms.Label ChooseSeatLabel;
		private System.Windows.Forms.Label ChooseMovieLabel;
	}
}

