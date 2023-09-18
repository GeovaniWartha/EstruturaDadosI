using System;

namespace StackClass
{
    public class Stack
    {
        static readonly int MAX = 1000;

        int top = -1;
        string[] stack = new string[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(string data) 
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            stack[top] = data;
            return true;
        }

        public string Pop() 
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return null; 
            }

            string value = stack[top];
            top -= 1;

            return value;
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}");
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha");
            for (int i = top; i > -1; i--)
            {
                string text = $"Stack[{stack[i]}";
                Console.WriteLine(text);
            }
        }
    }
}
