/* using System;

class CustomQueue
{
    int front, rear, capacity;
    int[] queue;

    CustomQueue(int c)
    {
        front = 0;
        rear = -1;
        capacity = c;
        queue = new int[capacity];
    }

    void Enqueue(int data)
    {
        if (rear == capacity - 1)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        queue[++rear] = data;
    }

    void Dequeue()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        for (int i = 0; i < rear; i++)
        {
            queue[i] = queue[i + 1];
        }

        rear--;
    }

    void Display()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        for (int i = front; i <= rear; i++)
        {
            Console.Write(queue[i] + " <-- ");
        }
        Console.WriteLine();
    }

    void Front()
    {
        if (rear == -1)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.WriteLine("Front Element is: " + queue[front]);
    }

    public static void Main(string[] args)
    {
        CustomQueue q = new CustomQueue(4);

        q.Display();

        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);
        q.Enqueue(50);

        q.Display();

        q.Enqueue(60);

        q.Display();

        q.Dequeue();
        q.Dequeue();

        Console.WriteLine("After two node deletions");

        q.Display();

        Console.WriteLine("After one insertion");
        q.Enqueue(60);

        q.Display();

        q.Front();
    }
}

//To be honest, here i used GreekForgreek as a "assistant" */