using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CheckedListBox_Demo
{
    public partial class Form1 : Form
    {
        private List<ProgrammingLanguage> Languages { get; set; } = new List<ProgrammingLanguage>();
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(new[] { "apple", "cherry", "coffe" });

            Languages.AddRange(new[]
            {
                new ProgrammingLanguage
                {
                    Name = "C#",
                    Popularity = 8
                },
                new ProgrammingLanguage
                {
                    Name = "Python",
                    Popularity = 9
                }
            });

            RefreshDataSource();

            hScrollBar1.Maximum = imageList1.Images.Count - 1;
            hScrollBar1.SmallChange = hScrollBar1.LargeChange = toolStripProgressBar1.Step = 1;
            pictureBox1.Image = imageList1.Images[0];
            toolStripProgressBar1.Maximum = hScrollBar1.Maximum;
        }

        private void RefreshDataSource()
        {
            listBoxPrLang.DataSource = null;
            listBoxPrLang.DataSource = Languages;
            listBoxPrLang.DisplayMember = "Name"; // те, що відображається в лістбоксі
            listBoxPrLang.ValueMember = "Popularity"; // те, що буде міститись у властивості SelectedValue
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "";

            foreach (var item in checkedListBox1.CheckedItems)
            {
                message += item + ", ";
            }

            toolStripLabel1.Text = message;
        }

        private void listBoxPrLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPrLang.SelectedIndex == -1)
            {
                return;
            }

            Text = listBoxPrLang.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorProvider.SetError(tbName, "Name cannot be empty!");

                return;
            }

            var language = new ProgrammingLanguage
            {
                Name = tbName.Text,
                Popularity = Convert.ToInt32(popularity.Value)
            };

            Languages.Add(language);
            RefreshDataSource();
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            splitContainer2.Panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[hScrollBar1.Value];
            toolStripProgressBar1.Value = hScrollBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
                return;
            }

            progressBar1.Value += 10;  // Increment(10);  // не можна використовувати для Marquee
        }
    }
}
