using System;

namespace ListCLass
{
    public class Queue
    {
        static readonly int MAX = 1000;

        int Inicio = 0;
        int Fim = -1;
        int[] queue = new int[MAX];

        public bool IsEmpty()
        {
            return (Fim < Inicio);
        }

        public bool Enqueue(int data)
        {
            if (Fim >= MAX - 1)
            {
                Console.WriteLine("Queue Overflow");
                return false;
            }
            Fim += 1;
            queue[Fim] = data;
            return true;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return 0;
            }

            int value = queue[Inicio];
            Inicio += 1;

            return value;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine($"O elemento na frente da fila é: {queue[Inicio]}");
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine("Itens da fila");
            for (int i = Inicio; i <= Fim; i++)
            {
                string texto = $"Queue[{queue[i]}]";
                Console.WriteLine(texto);
            }
        }
    }
}
