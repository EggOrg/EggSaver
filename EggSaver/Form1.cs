using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async void Eoeoeooee(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            richTextBox1.Size = this.Size;
            await Typewrite("The all-seeing E E G is coming... What do you do?\n");
            await Typewrite("> Run   > Become Fren\n");
            await Replace("> Become Fren");
            await Task.Delay(500);
            await Remove();
            await Typewrite("You have chosen correctly. E E G is fren!\n");
            await Typewrite("The E E G means no harm.\n");
            await Typewrite("E E G offers: +1\n");
            await Typewrite("> Accepp   > Rejecc\n");
            await Replace("> Accepp");
            await Task.Delay(500);
            await Remove();
            await Typewrite("The E E G thanks you for your time.\n");
            await Typewrite("> Show colors   > Exit screensaver");
            await Replace("> Show colors");
            await Task.Delay(500);
            await Remove();
            await Typewrite("Wait, but this can't be the end!\n");
            await Typewrite("E E G must always be fren!\n");
            await Typewrite("> Befriend E E G forever   > Leave E E G\n");
            await Replace("> Befriend E E G forever");
            await Task.Delay(500);
            await Remove();
            while (true)
            {
                await Task.Delay(500);
                await Typewrite("E E G is fren forever. ");
                richTextBox1.ForeColor = BuildCl()[new Random().Next(0, BuildCl().ToArray().Length)];
            }
        }
        public async Task Typewrite(string str)
        {
            foreach (char cr in str)
            {
                await Task.Delay(10);
                richTextBox1.Text += cr;
            }
        }
        public async Task Remove()
        {
            foreach (char cr in richTextBox1.Text)
            {
                await Task.Delay(5);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
        }
        public async Task Replace(string txt)
        {
            await Task.Delay(1000);
            richTextBox1.Text = richTextBox1.Text.Replace($"{txt}", $"[{txt}]");
        }
        public List<Color> BuildCl()
        {
            List<Color> cls = new List<Color>();
            cls.Add(Color.Red);
            cls.Add(Color.Blue);
            cls.Add(Color.Yellow);
            cls.Add(Color.Orange);
            cls.Add(Color.Aqua);
            cls.Add(Color.Purple);
            cls.Add(Color.Green);
            return cls;
        }
    }
}
