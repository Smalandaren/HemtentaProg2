using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HemtentaUppgift2
{
    public partial class Form1 : Form
    {

        public List<Seat> seats = new List<Seat>();
		public List<CheckBox> buttons = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
			CreateButtons();
			FillSeatList();
		}

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
                    //Console.WriteLine($"{button.Name} + {seat.name} + {MovieSelector.Text} + {seat.movie} + {button.Checked}");
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

		private void DynamicButtonClick(object sender, EventArgs e)
		{
			// Get the button that triggered the event
			Button clickedButton = sender as Button;

			
		}

		private void MovieSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChooseMovieLabel.ForeColor = Color.Black;

			foreach (CheckBox button in buttons)
			{
				foreach (Seat seat in seats)
				{ 
					//Console.WriteLine($"{button.Name} + {seat.name} + {MovieSelector.Text} + {seat.movie} + {button.Checked}");
					if (button.Name == seat.name && seat.movie == MovieSelector.Text)
					{
						if (seat.booked)
						{
							button.Enabled = false;
						}
						else
						{
							button.Enabled = true;
						}
					}
				}
			}
		}
	}
}
