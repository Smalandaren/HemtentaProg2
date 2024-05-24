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
			this.BookButton.Location = new System.Drawing.Point(687, 387);
			this.BookButton.Margin = new System.Windows.Forms.Padding(2);
			this.BookButton.Name = "BookButton";
			this.BookButton.Size = new System.Drawing.Size(104, 54);
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
			this.MovieSelector.Location = new System.Drawing.Point(9, 404);
			this.MovieSelector.Margin = new System.Windows.Forms.Padding(2);
			this.MovieSelector.Name = "MovieSelector";
			this.MovieSelector.Size = new System.Drawing.Size(150, 24);
			this.MovieSelector.TabIndex = 1;
			this.MovieSelector.SelectedIndexChanged += new System.EventHandler(this.MovieSelector_SelectedIndexChanged);
			// 
			// ChooseSeatLabel
			// 
			this.ChooseSeatLabel.AutoSize = true;
			this.ChooseSeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.ChooseSeatLabel.Location = new System.Drawing.Point(243, 14);
			this.ChooseSeatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ChooseSeatLabel.Name = "ChooseSeatLabel";
			this.ChooseSeatLabel.Size = new System.Drawing.Size(352, 31);
			this.ChooseSeatLabel.TabIndex = 2;
			this.ChooseSeatLabel.Text = "Välj vilka platser du vill boka";
			// 
			// ChooseMovieLabel
			// 
			this.ChooseMovieLabel.AutoSize = true;
			this.ChooseMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.ChooseMovieLabel.Location = new System.Drawing.Point(9, 376);
			this.ChooseMovieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ChooseMovieLabel.Name = "ChooseMovieLabel";
			this.ChooseMovieLabel.Size = new System.Drawing.Size(90, 26);
			this.ChooseMovieLabel.TabIndex = 3;
			this.ChooseMovieLabel.Text = "Välj film";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ChooseMovieLabel);
			this.Controls.Add(this.ChooseSeatLabel);
			this.Controls.Add(this.MovieSelector);
			this.Controls.Add(this.BookButton);
			this.Name = "Form1";
			this.Text = "Biosalong";
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

