using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace WindowsFormsApp1
{
	static class Program
	{
        private static int Multiply(int a, int b)
        {
            for (int i = 0; i < 3; i++)
            {
                a *= b;
            }
            return a;
        }

        private static int Add(int a, int b)
        {
            for (int i = 0; i < 3; i++)
            {
                a += b;
            }
            return a;
        }

        private static float Divide(int a, int b)
        {
            try
                {
                    float c = (float)a;
                    float d = (float)b;
                    for (int i = 0; i < 3; i++)
                    {
                        a /= b;
                    }
                }
                    catch(DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by \"0\"");
                }
            return a;
        }

        private static int Subtract(int a, int b)
        {
            for (int i = 0; i < 3; i++)
            {
                a -= b;
            }
            return a;
        }

        private static int Powerof(int a, int b)
        {
            double c = (double)a;
            double d = (double)b;
            for (int i = 0; i < 3; i++)
            {
                c = Math.Pow(c, d);
            }
            return a;
        }

        private static double Roots(int a, int b)
        {
            try
                {
                    double c = (double)a;
                    double d = (double)b;
                    for (int i = 0; i < 3; i++)
                    {
                        c = Math.Pow(c, 1/d);
                    }
                    return c;
                }
            catch(DivideByZeroException)
                {
                    double c = 1;
                    return c;
                }
        }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			string path = WindowsFormsApp1.Form1.TextBox3.Text;
            int a;
            int b;
            string operation = "";
            try
            {
                XmlReader xRead = XmlReader.Create(path);
                string temp = xRead.ToString();
                temp = temp.Replace("„", "\"");
                         
                xRead = XmlReader.Create(temp);
                XElement xEle = XElement.Load(xRead);
                Console.WriteLine(xEle);
                IEnumerable<XElement> values = xEle.Elements();
                xRead.Close();
                foreach (var value in values)
                {
                    Console.WriteLine(value);
                    a = (int)value.Attribute("a");
                    b = (int)value.Attribute("b");
                    operation = Form1.ComboBox.Text;
                    switch(operation)
                        {
                        case "Add":
                            Form1.TextBox5.Text = Add(a, b);
                            break;
                        case "Subtract":
                            Form1.TextBox5.Text = Subtract(a, b);
                            break;
                        case "Multiply":
                            Form1.TextBox5.Text = Multiply(a, b);
                            break;
                        case "Divide":
                            Form1.TextBox5.Text = Divide(a, b);
                            break;
                        case "Power of":
                            Form1.TextBox5.Text = Powerof(a, b);
                            break;
                        case "Root of":
                            Form1.TextBox5.Text = Roots(a, b);
                            break;
                        default:
                            Form1.TextBox5.Text = "First choose an operation!";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " oh no!");
            }
            Console.ReadKey();
		}
	}
}
