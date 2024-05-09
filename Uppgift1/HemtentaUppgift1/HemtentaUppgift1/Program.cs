using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemtentaUppgift1
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}


	public class OrderItem
	{
		public string soda;
		public int amount;
		public bool sugarFree;

		public OrderItem(string Soda, int Amount, bool SugarFree) 
		{
			soda = Soda;
			amount = Amount;
			sugarFree = SugarFree;
		}

	}


}
