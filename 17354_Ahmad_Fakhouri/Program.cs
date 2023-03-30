using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17354_Ahmad_Fakhouri
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("__________");
            Console.WriteLine("1.Additon");
            Console.WriteLine("2.subtract");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("5.modulus");
        }

        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("_________");
            Console.WriteLine("1.Calculator");
            Console.WriteLine("2.Metric conversation");
            Console.WriteLine("3.Mathmatical formula");
            Console.WriteLine("4.Exit");
            Console.Write("Please enter your choice [ ]\b\b");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 4) 
            { Environment.Exit(0);}
            if (choice > 4) { Console.WriteLine("Please choose between 1 and 4");}

            if (choice == 1)
            {
                Console.Clear();

                Console.WriteLine("Menu");
                Console.WriteLine("__________");
                Console.WriteLine("1.Additon");
                Console.WriteLine("2.subtract");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");
                Console.WriteLine("5.modulus");
                int a;
                Console.Write("Please enter your choice [ ]\b\b");
                a = Convert.ToInt32(Console.ReadLine());

                if(a > 0 && a < 5);
                {


                    int n1, n2, result = 0;
                    Console.WriteLine("Please enter the first number: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the secound number: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1: result = n1 + n2; break;
                        case 2: result = n1 - n2; break;
                        case 3: result = n1 * n2; break;
                        case 4: result = n1 / n2; break;
                        case 5: result = n1 % n2; break;
                        default:result = ' '; break;
                            


                    }
                    Console.WriteLine("your answer is {0}", result);

                }
            }





            
            else if (choice == 2)
            {
                Console.Clear();
                int z;
                Double res = 1;

                Console.WriteLine("1.Inches to Centimetres");
                Console.WriteLine("2.Centimetres to Inches");
                Console.WriteLine("3.Feet to Centimetres");
                Console.WriteLine("4.Centimetres to Feet");
                Console.WriteLine("5.Yards to Metres");
                Console.WriteLine("6.Metres to Yards");
                Console.WriteLine("7.Miles to Kilometres");
                Console.WriteLine("Kilometres to Miles");
                Console.WriteLine("Please choose");
                z = Convert.ToInt32(Console.ReadLine());
                if (z < 7)
                {
                    double n;
                    Console.WriteLine("Please enter the number");
                    n = Convert.ToDouble(Console.ReadLine());
                    if (z == 1) { res = n * 2.54; }
                    else if (z == 2) { res = n / 2.54; }
                    else if (z == 3) { res = n * 30; }
                    else if (z == 4) { res = n / 30.48; }
                    else if (z == 5) { res = n * 0.91; }
                    else if (z == 6) { res = n * 1.09; }
                    else if (z == 7) { res = n * 1.6; }
                    else if (z == 8) { res = n / 1.6; }
                    Console.WriteLine("Your answer {0}", res);

                }
                
                
            }
            else if (choice==3)
            {
                Console.Clear();
                int k;
                Console.WriteLine("1.power");
                Console.WriteLine("2.permutation");
                Console.WriteLine("3.combination");
                Console.WriteLine("Please choose");
                k = Convert.ToInt32(Console.ReadLine());
                if(k==1)
                {
                    int a, b, power = 1;
                    Console.WriteLine("Please enter the number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= b; i++)
                    {
                        power *= a;
                    }
                    Console.WriteLine(power);
                }
                if (k==2)
                {
                    int a, n, fn = 1, fr = 1, rea = 0;
                    Console.Write("Please enter the number");
                    a=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the secound number");
                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i = a;i>0;i++)
                    {
                        fn *= i;
                    }
                    
                    for(int i = n;i>0;i++)
                    {
                        fr *= i;
                    }
                    rea = fn / fn - fr;
                    Console.WriteLine("The answer is {0}", rea);
                }
                if(k==3)
                {
                    int d, f, ff = 1, fe = 1, ress = 0;
                    Console.WriteLine("Please enter the first number");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the secound");
                    f = Convert.ToInt32(Console.ReadLine());
                    for(int i = d;i>0;i++)
                    {
                        ff *= i;
                    }
                    for(int i = f;i>0;i++)
                    {
                        fe *= i;
                    }
                    ress = ff / fe * ff - fe;
                    Console.WriteLine("Your answer{0}", ress);

                }


            }




            }
        }
    }

