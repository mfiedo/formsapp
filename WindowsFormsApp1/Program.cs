using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            for (int i = 0; i < 3; i++)
            {
                a = Math.Pow(a, b);
            }
            return a;
        }

        private static int Rootof(int a, int b)
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
                    c = 1;
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
			string path = Form1.TextBox3.Text;
            int a;
            int b;
            string operation = "";
            try
            {
                XmlReader xRead = XmlReader.Create(path);
                /*string temp = xRead.ToString();
                temp = temp.Replace("„", "\"");
                         
                xRead = XmlReader.Create(temp);*/
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
                            Console.WriteLine(Add(a, b));
                            break;
                        case "Subtract":
                            Console.WriteLine(Subtract(a, b));
                            break;
                        case "Multiply":
                            Console.WriteLine(Multiply(a, b));
                            break;
                        case "Divide":
                            Console.WriteLine(Divide(a, b));
                            break;
                        case "Power of":
                            Console.WriteLine(Powerof(a, b));
                            break;
                        case "Root of":
                            Console.WriteLine(Rootof(a, b));
                            break;
                        default:
                            Console.WriteLine("First choose an operation!");
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
