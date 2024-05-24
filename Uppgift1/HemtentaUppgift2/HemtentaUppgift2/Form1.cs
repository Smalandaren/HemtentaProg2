using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HemtentaUppgift2
{
    public partial class Form1 : Form
    {
		//Lista över alla platser (2 av varje plats, en för varje film)
        public List<Seat> seats = new List<Seat>();

		//Lista över alla knappar, endast en uppsättning
		public List<CheckBox> buttons = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
			CreateButtons();
			FillSeatList();
		}

		/// <summary>
		/// Metoden för bokningsknappen. Loopar genom alla platser för varje knapp och bokar en plats om den hittar en vald knapp. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BookButton_Click(object sender, EventArgs e)
		{
			if(MovieSelector.Text == String.Empty)
			{
                Console.WriteLine("Ingen film vald");
				ChooseMovieLabel.ForeColor = Color.Red;
				return;
            }

			bool found = false;
			foreach (CheckBox button in buttons)
			{
				foreach (Seat seat in seats)
				{
                    if (button.Name == seat.name && seat.movie == MovieSelector.Text && button.Checked)
					{
						found = true;
                        seat.booked = true;
						button.Checked = false;
						button.Enabled = false;
						ChooseSeatLabel.ForeColor = Color.Black;
					}
				}
			}

			if (!found)
			{
				ChooseSeatLabel.ForeColor = Color.Red;
			}
		}

		/// <summary>
		/// Skapar alla platser - en för varje plats för varje film - och lägger dem i listan 'seats'. 
		/// </summary>
        public void FillSeatList()
        {
			string[] movies = new string[2] { "Fall Guy", "Boy Kills World" };

			foreach (string movie in movies)
			{
				foreach (char c in "ABCDEFGHIJ")
				{
					for (int i = 1; i <= 15; i++)
					{
						seats.Add(new Seat($"{c}{i}", movie, false));
					}
				}
			}
		}

		/// <summary>
		/// Skapar alla knappar som motsvarar de olika platserna och ger dem namn och text. 
		/// Lägger också till dem i en lista med alla knappar för att underlätta loopning. 
		/// </summary>
        public void CreateButtons()
        {
			int x = 10;
			int y = 60;

			foreach (char c in "ABCDEFGHIJ")
			{
				for (int i = 1; i <= 15; i++)
				{

					x += 45;

					CheckBox button = new CheckBox();
					button.Appearance = Appearance.Button;
					button.Left = x;
					button.Top = y;
					button.Width = 40;
					button.Text = $"{c}{i}";
					button.Name = $"{c}{i}";
					button.Font = new Font("Courier New", 8, FontStyle.Regular);
					Controls.Add(button);
					button.Click += DynamicButtonClick;
					buttons.Add(button);

				}
				y += 30;
				x = 10;
			}
			
		}

		/// <summary>
		/// Metoden för när platsknapper trycks på, används inte
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DynamicButtonClick(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
		}

		/// <summary>
		/// Metoden för när valet av film ändras. 
		/// Loopar genom alla knappar och platser och disablar eller enablar de beroende på om de är bokade för den valde filmen. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MovieSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChooseMovieLabel.ForeColor = Color.Black;

			foreach (CheckBox button in buttons)
			{
				foreach (Seat seat in seats)
				{ 
					if (button.Name == seat.name && seat.movie == MovieSelector.Text)
					{
						if (seat.booked)
						{
							if (button.Checked) { button.Checked = false; }
							//button.BackColor = Color.Red;
							button.Enabled = false;
						}
						else
						{
							//button.BackColor = Color.White;
							button.Enabled = true;
						}
					}
				}
			}
		}
	}
}
