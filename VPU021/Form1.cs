using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CarLibrary;
using Newtonsoft.Json;

namespace VPU021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Clear();

            // Reflection - ?
            // LINQ
            var colors = typeof(Color)  // get Type
                .GetProperties()  // отрмуємо список всіх властивостей в типі Color
                .Select(x => x.Name);  // обираємо тільки імена

            var car = new Car
            {
                Brand = "BMW",
                Name = "X6",
                Engine = "3.0",
                Year = 2019
            };

            var carManager = new CarManager();
            carManager.Add(car);
            carManager.Add(new Car
            {
                Brand = "Mazda",
                Name = "6",
                Year = 2016,
                Engine = "2.5"
            });
            
            comboBox1.Items.AddRange(colors
                .Take(colors.Count() - 9)  // візьми к-сть кольорів крім 9 останніх
                .ToArray());
            comboBox1.SelectedIndex = 0;

            listBox1.Items.AddRange(carManager.GetCars().ToArray());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked)
            {
                (rb.Parent as GroupBox).BackColor = Color.FromName(rb.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            var parent = cb.Parent as GroupBox;

            string message = "";

            foreach (Control item in parent.Controls)
            {
                if (item is CheckBox && (item as CheckBox).Checked)
                {
                    message += item.Text + "\n";
                }
            }

            label1.Text = message;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tbItem.Text);

            tbItem.Clear();
        }

        private void multicolumn_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = multicolumn.Checked;
        }

        private void one_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = (SelectionMode)Enum.Parse(typeof(SelectionMode), (sender as RadioButton).Text);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }

            RemoveItems();
        }

        private void RemoveItems()
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.FromName(comboBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;

            if (item is Car)
            {
                this.Text = (item as Car).Brand;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var hero = new Hero
            //{
            //    birth_year = "2020",
            //    height = "120"
            //};

            //var json = JsonConvert.SerializeObject(hero, Formatting.Indented);
            //File.WriteAllText("hero.json", json);

            var json = File.ReadAllText("hero.json");
            var hero = JsonConvert.DeserializeObject<Hero>(json);
        }
    }
}
