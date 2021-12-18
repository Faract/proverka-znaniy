using System;
					
public class Program
{
    public static void Main()
    {

        string s = Console.ReadLine();
        string[] list =  s.Split(' ');
        string sn1 = list[0];
        string sn2 = list[1];
        string ch = list[2];
        
        if (!long.TryParse(sn1, out var n1))
        {
            Console.WriteLine("Ошибка. Первый аргумент не является числом");
            return;
        }

        if (!long.TryParse(sn2, out var n2))
        {
            Console.WriteLine("Ошибка. Второй аргумент не является числом");
            return;
        }

        if (n2 == 0 && ch == "/")
        {
            Console.WriteLine("Ошибка. Попытка деления на ноль");
        }
        else {
            if ("+-*/".Contains(ch))
            {
                switch(ch){
                    case "+":
                        Console.WriteLine(n1 + n2);
                        break;
		    
                    case "-":
                        Console.WriteLine(n1 - n2);
                        break;
		    
                    case "*":
                        Console.WriteLine(n1 * n2);
                        break;
		    
                    case "/":
                        Decimal d = n1;
                        Decimal dd = n2;
                        Console.WriteLine(Decimal.Divide(d, dd));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Используйте корректную операцию");
            }
            
        }
    }
}