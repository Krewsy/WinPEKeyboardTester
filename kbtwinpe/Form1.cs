using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace kbtwinpe
{
    public class keyboard
    {
        Point location;
        string name;
        Size size;
        string text;
        public keyboard(Point location, string name, Size size, string text)
        {
            this.name = name;
            this.location = location;
            this.size = size;
            this.text = text;
        }
        public Point getLocation
        {
            get { return location; }
        }
        public string getName
        {
            get { return name; }
        }
        public Size getSize
        {
            get { return size; }
        }
        public string getText
        {
            get { return text; }
        }
    }
    
    public partial class Form1 : Form
    {
        public static Point GetPoint(int x, int y)
        {
            Point index = new Point(x, y);
            return index;
        }
        public static Size GetSize(int x, int y)
        {
            Size index = new Size(x, y);
            return index;
        }

        List<keyboard> board = new List<keyboard>
        {
            new keyboard(GetPoint(12, 12), "Escape", GetSize(39, 40), "ESC"),
            new keyboard(GetPoint(12, 66), "Oemtilde", GetSize(39, 40), "`"),
            new keyboard(GetPoint(12, 158), "Capital", GetSize(84, 40), "Caps"),
            new keyboard(GetPoint(12, 112), "Tab", GetSize(63, 40), "TAB"),
            new keyboard(GetPoint(12, 204), "ShiftKey", GetSize(98, 40), "Shift"),
            new keyboard(GetPoint(57, 66), "D1", GetSize(39, 40), "1"),
            new keyboard(GetPoint(102, 66), "D2", GetSize(39, 40), "2"),
            new keyboard(GetPoint(237, 12), "F4", GetSize(39, 40), "F4"),
            new keyboard(GetPoint(282, 12), "F5", GetSize(39, 40), "F5"),
            new keyboard(GetPoint(147, 12), "F2", GetSize(39, 40), "F2"),
            new keyboard(GetPoint(192, 12), "F3", GetSize(39, 40), "F3"),
            new keyboard(GetPoint(102, 12), "F1", GetSize(39, 40), "F1"),
            new keyboard(GetPoint(147, 66), "D3", GetSize(39, 40), "3"),
            new keyboard(GetPoint(183, 250), "Space", GetSize(263, 40), "Space"),
            new keyboard(GetPoint(183, 250), "ShiftkEY", GetSize(108, 40), "Shift"),
            new keyboard(GetPoint(621, 112), "Oem5", GetSize(53, 40), "\\"),
            new keyboard(GetPoint(597, 158), "Return", GetSize(77, 40), "Enter"),
            new keyboard(GetPoint(597, 66), "Back", GetSize(77, 40), "Backspace"),
            new keyboard(GetPoint(678, 112), "Delete", GetSize(39, 40), "Del"),
            new keyboard(GetPoint(723, 112), "End", GetSize(39, 40), "End"),
            new keyboard(GetPoint(723, 66), "Home", GetSize(39, 40), "Home"),
            new keyboard(GetPoint(768, 66), "PageUp", GetSize(39, 40), "Page Up"),
            new keyboard(GetPoint(678, 66), "Insert", GetSize(39, 40), "Ins"),
            new keyboard(GetPoint(768, 112), "Next", GetSize(39, 40), "Page Down"),
            new keyboard(GetPoint(768, 250), "Right", GetSize(39, 40), "Right"),
            new keyboard(GetPoint(678, 250), "Left", GetSize(39, 40), "Left"),
            new keyboard(GetPoint(723, 250), "Down", GetSize(39, 40), "Down"),
            new keyboard(GetPoint(723, 204), "Up", GetSize(39, 40), "Up"),
            new keyboard(GetPoint(948, 204), "Return", GetSize(39, 86), "Ent"),
            new keyboard(GetPoint(948, 112), "Add", GetSize(39, 86), "+"),
            new keyboard(GetPoint(948, 66), "Subtract", GetSize(39, 40), "-"),
            new keyboard(GetPoint(903, 204), "NumPad3", GetSize(39, 40), "3"),
            new keyboard(GetPoint(858, 204), "NumPad2", GetSize(39, 40), "2"),
            new keyboard(GetPoint(903, 250), "Decimal", GetSize(39, 40), "."),
            new keyboard(GetPoint(903, 112), "NumPad9", GetSize(39, 40), "9"),
            new keyboard(GetPoint(903, 158), "NumPad6", GetSize(39, 40), "6"),
            new keyboard(GetPoint(903, 66), "Multiply", GetSize(39, 40), "*"),
            new keyboard(GetPoint(858, 112), "NumPad8", GetSize(39, 40), "8"),
            new keyboard(GetPoint(858, 158), "NumPad5", GetSize(39, 40), "5"),
            new keyboard(GetPoint(858, 66), "Divide", GetSize(39, 40), "/"),
            new keyboard(GetPoint(813, 204), "NumPad1", GetSize(39, 40), "1"),
            new keyboard(GetPoint(813, 250), "NumPad0", GetSize(84, 40), "0"),
            new keyboard(GetPoint(813, 112), "NumPad7", GetSize(39, 40), "7"),
            new keyboard(GetPoint(813, 158), "NumPad4", GetSize(39, 40), "4"),
            new keyboard(GetPoint(813, 66), "NumLock", GetSize(39, 40), "Num"),
            new keyboard(GetPoint(509, 250), "checkBox25", GetSize(51, 40), "Fn"),
            new keyboard(GetPoint(452, 250), "Menu", GetSize(51, 40), "Alt"),
            new keyboard(GetPoint(126, 250), "Menu", GetSize(51, 40), "Alt"),
            new keyboard(GetPoint(12, 250), "ControlKey", GetSize(51, 40), "Ctrl"),
            new keyboard(GetPoint(69, 250), "LWin", GetSize(51, 40), "Win"),
            new keyboard(GetPoint(566, 250), "Apps", GetSize(51, 40), ""),
            new keyboard(GetPoint(621, 250), "ControlKey", GetSize(51, 40), "Ctrl"),
            new keyboard(GetPoint(462, 12), "F9", GetSize(39, 40), "F9"),
            new keyboard(GetPoint(507, 12), "F10", GetSize(39, 40), "F10"),
            new keyboard(GetPoint(372, 12), "F7", GetSize(39, 40), "F7"),
            new keyboard(GetPoint(417, 12), "F8", GetSize(39, 40), "F3"),
            new keyboard(GetPoint(327, 12), "F6", GetSize(39, 40), "F6"),
            new keyboard(GetPoint(552, 12), "F11", GetSize(39, 40), "F11"),
            new keyboard(GetPoint(597, 12), "F12", GetSize(39, 40), "F12"),
            new keyboard(GetPoint(282, 66), "D6", GetSize(39, 40), "6"),
            new keyboard(GetPoint(237, 66), "D5", GetSize(39, 40), "5"),
            new keyboard(GetPoint(417, 66), "D9", GetSize(39, 40), "9"),
            new keyboard(GetPoint(372, 66), "D8", GetSize(39, 40), "8"),
            new keyboard(GetPoint(327, 66), "D7", GetSize(39, 40), "7"),
            new keyboard(GetPoint(552, 66), "Oemplus", GetSize(39, 40), "="),
            new keyboard(GetPoint(507, 66), "OemMinus", GetSize(39, 40), "-"),
            new keyboard(GetPoint(462, 66), "D0", GetSize(39, 40), "0"),
            new keyboard(GetPoint(192, 66), "D4", GetSize(39, 40), "4"),
            new keyboard(GetPoint(126, 112), "W", GetSize(39, 40), "W"),
            new keyboard(GetPoint(81, 112), "Q", GetSize(39, 40), "Q"),
            new keyboard(GetPoint(171, 112), "E", GetSize(39, 40), "E"),
            new keyboard(GetPoint(216, 112), "R", GetSize(39, 40), "R"),
            new keyboard(GetPoint(351, 112), "U", GetSize(39, 40), "U"),
            new keyboard(GetPoint(306, 112), "Y", GetSize(39, 40), "Y"),
            new keyboard(GetPoint(261, 112), "T", GetSize(39, 40), "T"),
            new keyboard(GetPoint(486, 112), "P", GetSize(39, 40), "P"),
            new keyboard(GetPoint(532, 112), "OemOpenBrackets", GetSize(39, 40), "["),
            new keyboard(GetPoint(576, 112), "Oem6", GetSize(39, 40), "]"),
            new keyboard(GetPoint(441, 112), "O", GetSize(39, 40), "O"),
            new keyboard(GetPoint(396, 112), "I", GetSize(39, 40), "I"),
            new keyboard(GetPoint(462, 158), "L", GetSize(39, 40), "L"),
            new keyboard(GetPoint(507, 158), "Oem1", GetSize(39, 40), ";"),
            new keyboard(GetPoint(552, 158), "Oem7", GetSize(39, 40), "'"),
            new keyboard(GetPoint(417, 158), "K", GetSize(39, 40), "K"),
            new keyboard(GetPoint(372, 158), "J", GetSize(39, 40), "J"),
            new keyboard(GetPoint(327, 158), "H", GetSize(39, 40), "H"),
            new keyboard(GetPoint(282, 158), "G", GetSize(39, 40), "G"),
            new keyboard(GetPoint(237, 158), "F", GetSize(39, 40), "F"),
            new keyboard(GetPoint(192, 158), "D", GetSize(39, 40), "D"),
            new keyboard(GetPoint(147, 158), "S", GetSize(39, 40), "S"),
            new keyboard(GetPoint(102, 158), "A", GetSize(39, 40), "A"),
            new keyboard(GetPoint(552, 158), "\\", GetSize(39, 40), "\\"),
            new keyboard(GetPoint(431, 204), "Oemcomma", GetSize(39, 40), ","),
            new keyboard(GetPoint(386, 204), "M", GetSize(39, 40), "M"),
            new keyboard(GetPoint(341, 204), "N", GetSize(39, 40), "N"),
            new keyboard(GetPoint(296, 204), "B", GetSize(39, 40), "B"),
            new keyboard(GetPoint(251, 204), "V", GetSize(39, 40), "V"),
            new keyboard(GetPoint(206, 204), "C", GetSize(39, 40), "C"),
            new keyboard(GetPoint(161, 204), "X", GetSize(39, 40), "X"),
            new keyboard(GetPoint(116, 204), "Z", GetSize(39, 40), "Z"),
            new keyboard(GetPoint(521, 204), "OemQuestion", GetSize(39, 40), "/"),
            new keyboard(GetPoint(476, 204), "OemPeriod", GetSize(39, 40), "."),

        };

        List<Keys> keys = new List<Keys>();
        List<Keys> Foundkeys = new List<Keys>();
        List<Keys> NotFoundkeys = new List<Keys>();
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
            keys.ForEach(i => {
                foreach(keyboard key in board){
                    if (key.getName == i.ToString())
                    {
                        Console.WriteLine(i.ToString());

                        Label lbl = new Label();
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.BackColor = Color.LightGray;
                        lbl.Location = key.getLocation;
                        lbl.Size = key.getSize;
                        lbl.Text = key.getText;

                        this.Controls.Add(lbl);

                        if (!keylabel.ContainsKey(i))
                            keylabel.Add(i, lbl);
                        Foundkeys.Add(i);
                        break;
                    }
                }
            });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            if (Foundkeys.Contains(key))
            {
                keylabel[key].BackColor = Color.Gray;
                pressedKeys.Add(key);
            }
            else {
                string message = "you pressed " + key + " but that is not found on this table";
                string title = "Key Missing";
                MessageBox.Show(message, title);
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
