using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemtentaUppgift3
{
    
    public partial class Form1 : Form
    {
        //Lista över alla rätter
        public List<Dish> dishes = new List<Dish>();

        //Lista över alla beställningar
        public List<Dish> orderList = new List<Dish>();

        public Form1()
        {
            InitializeComponent();
            FillList();
            CreateButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Skapar alla rätter och lägger in dem i en lista
        /// </summary>
        public void FillList()
        {
            dishes.Add(new Dish("Pizza", 75, "Main"));
            dishes.Add(new Dish("Biff", 165, "Main"));
            dishes.Add(new Dish("Vegetarisk biff", 100, "Main"));
            dishes.Add(new Dish("Soppa", 60, "Main"));

            dishes.Add(new Dish("Paj", 65, "Dessert"));
            dishes.Add(new Dish("Glass", 55, "Dessert"));
            dishes.Add(new Dish("Choklad", 30, "Dessert"));
            dishes.Add(new Dish("Tårta", 65, "Dessert"));

            dishes.Add(new Dish("Vatten", 45, "Drink"));
            dishes.Add(new Dish("Coca-Cola", 55, "Drink"));
            dishes.Add(new Dish("Öl", 95, "Drink"));
            dishes.Add(new Dish("Vin", 100, "Drink"));
        }

        /// <summary>
        /// Skapar knappar för alla rätter genom att loopa genom listan över rätter. Bytar rad beroende på typen av rätt (huvudrätt, efterrätt, dricka). 
        /// </summary>
        public void CreateButtons()
        {
            string previousdish = "Main";

            int x = -70;
            int y = 100;
            foreach (Dish dish in dishes)
            {

                if (!(previousdish.Equals(dish.type)))
                {
                    y += 100;
                    x = 30;
                }
                else { x += 100; }

                Button button = new Button();
                button.Left = x;
                button.Top = y;
                button.Text = dish.name;
                button.Name = dish.name;
                this.Controls.Add(button);
                button.Click += DynamicButtonClick;

                previousdish = dish.type;

            }
        }

        /// <summary>
        /// Metoden för knapparna för de olika rätterna. 
        /// Kör AddItem() med den motsvarande rätten. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DynamicButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            AddItem(clickedButton.Name);
            UpdateOrder();
        }

        /// <summary>
        /// Lägger till den inskickade rätten i beställningslistan
        /// </summary>
        /// <param name="name"></param>
        public void AddItem(string name)
        {
            Dish dish = new Dish("fel", 0, "fel");

            foreach (Dish i in dishes)
            {
                if (i.name.Equals(name))
                {
                    dish = i;
                    break;
                } 
            }
            orderList.Add(dish);
        }

        /// <summary>
        /// Uppdaterar orderboxen (UI) genom att rensa den och sätta innehållet till allt i orderlist + räkna ut och lägga till summan
        /// </summary>
        public void UpdateOrder()
        {
            orderBox.Items.Clear();

            int totalPrice = 0;

            foreach (Dish dish in orderList)
            {
                orderBox.Items.Add(String.Format("{0,-22} {1,10:C2}", dish.name, dish.price + " kr"));
                totalPrice += dish.price;
            }
            orderBox.Items.Add("");
            orderBox.Items.Add("Summa: " + totalPrice.ToString() + " kr");
        }

        /// <summary>
        /// Metoden för beställningsknappen. 
        /// Räknar ut totalpriset, visar att man beställt samt tömmer beställningslistan. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderButton_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            foreach (Dish dish in orderList)
            {
                totalPrice += dish.price;
            }

            totalLabel.Text = "Summa: " + totalPrice.ToString() + " kr";
            orderedLabel.Visible = true;
            funLabel.Visible = true;
            orderList.Clear();
        }

        /// <summary>
        /// Tömmer beställningslistan och orderboxen (UI)
        /// </summary>
        public void ClearOrder()
        {
            orderList.Clear();
            orderBox.Items.Clear();
        }

        /// <summary>
        /// Metoden för clearknappen. 
        /// Kör ClearOrder(). 
        /// Döljer beställningstexterna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
            orderedLabel.Visible = false;
            funLabel.Visible = false;
            totalLabel.Text = "";
        }

        /// <summary>
        /// Metoden för Ta Bort-knappen. 
        /// Tar bort den nu valda rätten från beställningslistan och orderboxen (UI). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = orderBox.SelectedIndex;
            if(index < orderList.Count())
            {
                if (orderBox.SelectedIndex != -1)
                {
                    orderList.RemoveAt(index);
                    UpdateOrder();
                }
            }
        }

		private void orderBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
