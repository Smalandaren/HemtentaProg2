using System;

namespace HemtentaUppgift2
{

	public class Seat
	{
		public string name;
		public string movie;
		public bool booked;

		public Seat(string name, string movie, bool booked)
		{
			this.name = name;
			this.movie = movie;
			this.booked = booked;
		}
	}
}
