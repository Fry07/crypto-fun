﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }

        }
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(new Item("BTC", 1));
            comboBox1.Items.Add(new Item("BCC", 1));
            comboBox1.Items.Add(new Item("ZEC", 1));
            comboBox1.Items.Add(new Item("ZEN", 1));
            comboBox1.Items.Add(new Item("ETH", 1));
            comboBox1.Items.Add(new Item("DASH", 1));
            comboBox1.Items.Add(new Item("DGB", 1));
            comboBox1.Items.Add(new Item("XEM", 1));
            comboBox1.Items.Add(new Item("CVC", 1));
            comboBox1.Items.Add(new Item("SYS", 1));
            comboBox1.Items.Add(new Item("Other", 2));
            comboBox1.SelectedIndex = 0;            
        }

        private void pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pause(2000);
            pictureBox1.Visible = false;

            Random rand = new Random();
            int temp;
            temp = rand.Next(100);

            Generate generate = new Generate();
            richTextBox1.Text = generate.generate(comboBox1.SelectedItem.ToString(), temp, textBox1.Text.ToString());
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Other")
            {
                textBox1.Visible = true;
                button1.Width = 75;
                button1.Left = 197;
            }
            else
            {
                textBox1.Visible = false;
                button1.Width = 132;
                button1.Left = 140;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
