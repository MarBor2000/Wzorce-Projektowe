using System;

namespace Interpreter
{
    internal class Program
    {
        public static void Main()
        {
            Expresion number1 = new Terminal(1);
            Expresion number2 = new Terminal(3);

            Expresion or = new Or(number1,number2);
            
            Expresion number3 = new Terminal(4);
            Expresion number4 = new Terminal(5);
            
            Console.WriteLine($"{or.interpret(1)}");
            Console.WriteLine($"{or.interpret(3)}");
            Console.WriteLine($"{or.interpret(2)}");
            
            
        }
    }
}