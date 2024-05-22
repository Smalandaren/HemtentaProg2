using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemtentaUppgift3
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

    public class Dish
    {
        public string name;
        public int price;
        public string type;
        public Dish(string name, int price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}
