using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cukraszda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form2 form2 = new Form2();

        private void fáljBeolvasásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("sutemenyek.txt");
            List<Sutemeny> sutik = new List<Sutemeny>();
            foreach (var item in beolvas)
            {
                Sutemeny suti = new Sutemeny(item);
                sutik.Add(suti);
            }
            süteményekToolStripMenuItem.Enabled = true;

            Font arlistaFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            for (int i = 0; i < sutik.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(12, 71 + i * 40);
                checkBox.Text = sutik[i].Nev + " (" + sutik[i].Ar + " Ft)";
                checkBox.Font = arlistaFont;
                checkBox.AutoSize = true;
                form2.Controls.Add(checkBox);

                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new Point(507, 71 + i * 40);
                numericUpDown.Size = new Size(54, 20);
                numericUpDown.Minimum = 0;
                numericUpDown.Font = arlistaFont;
                form2.Controls.Add(numericUpDown);

                Label label = new Label();
                label.Font = arlistaFont;
                label.AutoSize = true;
                label.Location = new Point(567, 71 + i * 40);
                label.Text = "adag";
                form2.Controls.Add(label);
            }

            Button button = new Button();
            button.Font = arlistaFont;
            button.Text = "Rendel";
            button.Location = new Point(250, 100 + sutik.Count * 40);
            button.AutoSize = true;
            button.Click += new EventHandler(rendeles);
            form2.Controls.Add(button);


            form2.ShowDialog();
        }

        private void rendeles(object sender, EventArgs e)
        {
            foreach (var item in form2.Controls)
            {
                if(item.GetType() == typeof(CheckBox) && ((CheckBox)item).Checked)
                {
                    MessageBox.Show(((CheckBox)item).Text);
                }
            }
        }

        private void süteményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
