using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Calculator
{


    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                int a = r.Next(0, 100);
                int b = r.Next(0, 100);
                int c = r.Next(0, 100);
                string[] e = { "+", "-", "*", "/" };
                char f, h;
                Random g = new Random();
                int ran = g.Next(0, 3);
                int re = g.Next(0, 3);
                f = char.Parse(e[ran % 4]);
                h = char.Parse(e[re % 4]);
                switch (f)
                {
                    case '+':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "+" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "+" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "+" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "+" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '-':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "-" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "-" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "-" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "-" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '*':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "*" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "*" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "*" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "*" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case '/':
                        switch (h)
                        {
                            case '+':
                                Console.WriteLine(a + "/" + b + "+" + c + "=");
                                Console.ReadKey();
                                break;
                            case '-':
                                Console.WriteLine(a + "/" + b + "-" + c + "=");
                                Console.ReadKey();
                                break;
                            case '*':
                                Console.WriteLine(a + "/" + b + "*" + c + "=");
                                Console.ReadKey();
                                break;
                            case '/':
                                Console.WriteLine(a + "/" + b + "/" + c + "=");
                                Console.ReadKey();
                                break;
                        }
                        break;
                }

            }

        }





    }
}





