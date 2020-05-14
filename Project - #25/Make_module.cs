using System;
using System.Collections.Generic;

namespace ConsoleApplication1 {
    class Program
    {
        static void Main()
        {
            var MyStack = new Stack<char>();
            MyStack.Push('A');
            MyStack.Push('B');
            MyStack.Push('C');
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Содержимое стека: ");
            foreach (char S in MyStack)
                Console.Write(S);
            Console.WriteLine("\n");
            while (MyStack.Count > 0) {
                Console.WriteLine(MyStack.Pop());
            }
            if (MyStack.Count == 0)
                Console.WriteLine(“Стек пуст!”);
        }
    }
}