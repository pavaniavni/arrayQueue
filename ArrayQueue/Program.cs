using System;

public class QueueArrays
{
    public static void Main(string[] args)
    {
        int size = 2;
        Queue queue = new Queue(size);

        int q1 = int.Parse(Console.ReadLine());
        int q2 = int.Parse(Console.ReadLine());

        queue.Enqueue(q1);
        queue.Enqueue(q2);

        q1 = queue.UnEnqueue();
        q2 = queue.UnEnqueue();

        Console.WriteLine(q1);
        Console.WriteLine(q2);
    }
}

public class Queue
{
    private int[] queue;
    private int position;

    public Queue(int size)
    {
        position = -1;
        queue = new int[size];
    }

    public void Enqueue(int value)
    {
        position++;
        queue[position] = value;
    }

    public int UnEnqueue()
    {
        int aux = queue[0];

        for (int i = 0; i < position; i++)
        {
            queue[i] = queue[i + 1];
        }

        queue[position] = aux;
        position--;

        return queue[position + 1];
    }
}