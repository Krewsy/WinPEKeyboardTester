using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kbtwinpe
{
    public partial class Form1 : Form
    {
        List<Keys> keys = new List<Keys>();
        Dictionary<Keys, Label> keylabel = new Dictionary<Keys, Label>();
        List<Keys> pressedKeys = new List<Keys>();
        public Form1()
        {
            InitializeComponent();
            keys.AddRange((Keys[])Enum.GetValues(typeof(Keys)));

            InitializeKeyButtons();

        }

        private void InitializeKeyButtons()
        {
            int x = 10;
            int y = 10;
            int count = 0;
            Size lblSize = new Size(100, 30);
            keys.ForEach(i => {
                Console.WriteLine(i.ToString());

                Label lbl = new Label();
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.BackColor = Color.LightGray;
                lbl.Location = new Point(x, y);
                lbl.Size = lblSize;
                lbl.Text = i.ToString();

                this.Controls.Add(lbl);

                if (!keylabel.ContainsKey(i))
                    keylabel.Add(i, lbl);


                x += lblSize.Width;
                count++;
                if (count % 13 == 0)
                {
                    x = 10;
                    y += lblSize.Height;
                }
            });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            keylabel[key].BackColor = Color.Gray;
            pressedKeys.Add(key);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (pressedKeys.Contains(key))
            {
                keylabel[key].BackColor = Color.Green;
                pressedKeys.Remove(key);
            }
        }
    }
}
