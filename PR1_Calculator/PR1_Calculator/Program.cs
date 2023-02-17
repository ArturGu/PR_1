using System;

namespace PR1_Calculator
{
    public delegate int Delegat(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.Write("Введiть дiю (+,-,*,/): ");
            string a = Console.ReadLine();
            Console.Write("Перше число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Друге число:");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    Delegat DelegatAdd = (c, b) => { return c + b; };
                    int add = DelegatAdd(x, y);
                    Console.WriteLine("Вiдповiдь:{0}", add);
                    break;
                case "-":
                    Delegat DelegatSub = (c, b) => { return c - b; };
                    int sub = DelegatSub(x, y);
                    Console.WriteLine("Вiдповiдь:{0}", sub);
                    break;
                case "*":
                    Delegat DelegatMul = (c, b) => { return c * b; };
                    int mul = DelegatMul(x, y);
                    Console.WriteLine("Вiдповiдь:{0}", mul);
                    break;
                case "/":
                    Delegat DelegatDiv = (c, b) => { return c / b; };
                    int div = DelegatDiv(x, y);
                    Console.WriteLine("Вiдповiдь:{0}", div);
                    break;
                default:
                    Console.WriteLine("Вкажіть вірну дію: (+,-,*,/)");
                    break;
            }

            Console.ReadKey();

        }
    }
}