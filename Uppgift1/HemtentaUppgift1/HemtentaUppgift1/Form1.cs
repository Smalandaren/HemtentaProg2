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
		//Beställningslistan
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

		/// <summary>
		/// Koden för Beställknappen som kör Order(). 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OrderButton_Click(object sender, EventArgs e)
		{
			Order();
		}

		private void OrderTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Tar värdena från menyerna och skapar ett nytt beställningsobjekt som läggs till i listan. Uppdaterar UI:n med UpdateOrder(). 
		/// </summary>
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

		/// <summary>
		/// Visar ett felmeddelande. 
		/// </summary>
		public void Error() 
		{
			ErrorMessage.Visible = true;
        }

		/// <summary>
		/// Uppdaterar rutan genom att tömma den och lägga in allt från beställningslistan + formattering. 
		/// </summary>
		public void UpdateOrder()
		{
			ErrorMessage.Visible = false;
			OutputBox.Items.Clear();
			foreach (OrderItem item in orderList)
			{
				string sugarStatus = (item.sugarFree) ? "zero" : "vanlig";
				OutputBox.Items.Add(item.soda + " - " + sugarStatus + " - " + item.amount + "\n");
			}
		}

		/// <summary>
		/// Tar bort den valda beställningen från listan. Uppdaterar UI:n med UpdateOrder(). 
		/// </summary>
		public void RemoveItem()
		{
			if(OutputBox.SelectedIndex != -1)
			{
                orderList.RemoveAt(OutputBox.SelectedIndex);
            }
            UpdateOrder();
		}

		/// <summary>
		/// Koden för clearknappen som tömmer beställningslistan. Uppdaterar UI:n med UpdateOrder(). 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click(object sender, EventArgs e)
		{
			orderList.Clear();
			UpdateOrder();
		}

		/// <summary>
		/// Koden för Ta Bort-knappen som kör RemoveItem(). 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveButton_Click(object sender, EventArgs e)
		{
			RemoveItem();
		}
	}
}
