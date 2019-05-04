using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection;

namespace map2
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        string keimeno="gr";
        List<Label> Labels = new List<Label>();
        List<List<string>> xores = new List<List<string>>();
        Class2 im;


        public Form1()
        {
            InitializeComponent();

            im = new Class2();
            
            Labels.Add(cont4txt);
            Labels.Add(title4txt);
            Labels.Add(cont3txt);
            Labels.Add(title3txt);
            Labels.Add(cont2txt);
            Labels.Add(title2txt);
            Labels.Add(cont1txt);
            Labels.Add(title1txt);
            Labels.Add(titletxt);




           

            for(int i = 0;i<9;i++)
            {
                Labels[i].Text = Class1.fr[i];
            }

            pic1.Image = new Bitmap(Properties.Resources.fra1);
            pic2.Image = new Bitmap(Properties.Resources.fra2);
            pic3.Image = new Bitmap(Properties.Resources.fra3);
            pic4.Image = new Bitmap(Properties.Resources.fra4);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = comboBox1.Text;//"COM8";//textBox1.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_DataReceived;
            try
            {
                myport.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            button1.Enabled = false;
        }
        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            this.Invoke(new EventHandler(dispaydata_event));

        }
        private void dispaydata_event(object sender, EventArgs e)
        {
            keimeno = myport.ReadLine();
           
            
            
            if (keimeno.Contains("gr"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.gr[i];
                }

                pic1.Image = im.gr1;
                pic2.Image = im.gr2;
                pic3.Image = im.gr3;
                pic4.Image = im.gr4;

            }
            
            if (keimeno.Contains("ger"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.ger[i];
                }

                pic1.Image = im.ger1;
                pic2.Image = im.ger2;
                pic3.Image = im.ger3;
                pic4.Image = im.ger4;
            }
            if (keimeno.Contains("it"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.it[i];
                }

                pic1.Image = im.it1;
                pic2.Image = im.it2;
                pic3.Image = im.it3;
                pic4.Image = im.it4;
            }
            if (keimeno.Contains("fra"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.fr[i];
                }

                pic1.Image = im.fr1;
                pic2.Image = im.fr2;
                pic3.Image = im.fr3;
                pic4.Image = im.fr4;
            }
            if (keimeno.Contains("sp"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.sp[i];
                }

                pic1.Image = im.sp1;
                pic2.Image = im.sp2;
                pic3.Image = im.sp3;
                pic4.Image = im.sp4;
            }
            if (keimeno.Contains("ned"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.ned[i];
                }

                pic1.Image = im.ned1;
                pic2.Image = im.ned2;
                pic3.Image = im.ned3;
                pic4.Image = im.ned4;
            }
            if (keimeno.Contains("ch"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.ch[i];
                }

                pic1.Image = im.ch1;
                pic2.Image = im.ch2;
                pic3.Image = im.ch3;
                pic4.Image = im.ch4;
            }
            if (keimeno.Contains("sw"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.sw[i];
                }

                pic1.Image = im.sw1;
                pic2.Image = im.sw2;
                pic3.Image = im.sw3;
                pic4.Image = im.sw4;
            }
            if (keimeno.Contains("rom"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.rom[i];
                }

                pic1.Image = im.rom1;
                pic2.Image = im.rom2;
                pic3.Image = im.rom3;
                pic4.Image = im.rom4;
            }
            if (keimeno.Contains("rus"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.rus[i];
                }

                pic1.Image = im.rus1;
                pic2.Image = im.rus2;
                pic3.Image = im.rus3;
                pic4.Image = im.rus4;
            }
            if (keimeno.Contains("gb"))
            {
                for (int i = 0; i < 9; i++)
                {
                    Labels[i].Text = Class1.gb[i];
                }

                pic1.Image = im.gb1;
                pic2.Image = im.gb2;
                pic3.Image = im.gb3;
                pic4.Image = im.gb4;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
