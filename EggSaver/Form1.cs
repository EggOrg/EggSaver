using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggSaver
{
    public partial class Form1 : Form
    {
        public string s1 = "The E E G is coming...";
        public string s2 = "What does it say?";
        public string s3 = "The E E G speaks of love and forgiveness of humankind.";
        public string s4 = "E E G is fren...";
        public Form1()
        {
            InitializeComponent();
        }
        public async void Init(object sender, EventArgs e)
        {
            await Typewrite(s1);
            await Typewrite(s2);
            await Typewrite(s3);
            await Typewrite(s4);
            while (textBox1.Text != string.Empty)
            {
                await Task.Delay(10);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            PrintEgg();
        }
        public async void PrintEgg()
        {
            while(true)
            {
                await Task.Delay(10000);
                textBox1.ForeColor = Egg.BuildColors()[new Random().Next(0, Egg.BuildColors().Length)];
                textBox1.Text += "E E G -- 🥚 ";
            }
        }
        public void Indent()
        {
            textBox1.Text += "\n";
        }
        public async Task Typewrite(string ttp)
        {
            foreach (char c in ttp)
            {
                await Task.Delay(10);
                textBox1.Text += c;
            }
            await Task.Delay(2000);
            Indent();
        }
    }
    class Egg
    {
        public static string[] BuildEgge()
        {
            List<string> egge = new List<string>();
            egge.Add(" ********   ********     ******** ");
            egge.Add("/**/////   /**/////     **//////**");
            egge.Add("/**        /**         **      // ");
            egge.Add("/*******   /*******   /**         ");
            egge.Add("/**////    /**////    /**    *****");
            egge.Add("/**        /**        //**  ////**");
            egge.Add("/********  /********   //******** ");
            egge.Add("////////   ////////     ////////  ");
            return egge.ToArray();
        }
        public static Color[] BuildColors()
        {
            List<Color> tocl = new List<Color>();
            tocl.Add(Color.Red);
            tocl.Add(Color.Blue);
            tocl.Add(Color.Yellow);
            tocl.Add(Color.White);
            tocl.Add(Color.Cyan);
            tocl.Add(Color.HotPink);
            tocl.Add(Color.Aqua);
            tocl.Add(Color.Chocolate);
            tocl.Add(Color.Orange);
            tocl.Add(Color.Purple);
            return tocl.ToArray();
        }
    }
}
