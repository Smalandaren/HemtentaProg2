using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemtentaUppgift1
{
	public partial class Form1 : Form
	{
		public List<OrderItem> orderList = new List<OrderItem>();
		public Form1()
		{
			InitializeComponent();
			SodaDropDown.SelectedIndex = 0;
			AmountDropDown.SelectedIndex = 0;
			BackgroundImage = Properties.Resources.soda;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void SodaDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SugarFreeCheck_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void AmountDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void OrderButton_Click(object sender, EventArgs e)
		{
			Order();
		}

		private void OrderTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		public void Order()
		{
			if (SodaDropDown.SelectedIndex != 0 && AmountDropDown.SelectedIndex != 0)
			{
				string soda = SodaDropDown.SelectedItem.ToString();
				bool sugarFree = SugarFreeCheck.Checked;
				string amount = AmountDropDown.SelectedItem.ToString();

				
				orderList.Add(new OrderItem(soda, amount, sugarFree));
				UpdateOrder();

			} else {Error();}
		}

		public void Error() 
		{
			ErrorMessage.Visible = true;
        }

		public void UpdateOrder()
		{
			ErrorMessage.Visible = false;
			OrderTextBox.Clear();
			foreach (OrderItem item in orderList)
			{
				string sugarStatus = (item.sugarFree) ? "zero" : "vanlig";
				OrderTextBox.Text += (item.soda + " - " + sugarStatus + " - " + item.amount + "\n");
			}
		}
	}
}
