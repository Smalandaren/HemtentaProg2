﻿using System;
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
        public List<Dish> dishes = new List<Dish>();
        public List<Dish> orderList = new List<Dish>();

        public Form1()
        {
            InitializeComponent();
            fillList();
            createButtons();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fillList()
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

        public void createButtons()
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

        private void DynamicButtonClick(object sender, EventArgs e)
        {
            // Get the button that triggered the event
            Button clickedButton = sender as Button;

            AddItem(clickedButton.Name);
            updateOrder();
        }

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

        public void updateOrder()
        {
            orderTextBox.Clear();

            int totalPrice = 0;

            foreach (Dish dish in orderList)
            {
                orderTextBox.Text += (dish.name + "  -  " + dish.price + " kr" + "\n");
                totalPrice += dish.price;
            }
            orderTextBox.Text += "\nSumma: " + totalPrice.ToString() + " kr";
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            foreach (Dish dish in orderList)
            {
                totalPrice += dish.price;
            }

            totalLabel.Text = "\nSumma: " + totalPrice.ToString() + " kr";
            orderedLabel.Visible = true;
            orderList.Clear();
            orderTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderList.Clear();
            orderTextBox.Clear();
        }
    }
}