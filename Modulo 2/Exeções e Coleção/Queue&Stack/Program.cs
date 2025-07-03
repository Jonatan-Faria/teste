Queue<int> queue = new Queue<int>();
 queue.Enqueue(2); queue.Enqueue(4); queue.Enqueue(6); queue.Enqueue(8); queue.Enqueue(10);

foreach (int item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item:  {queue.Dequeue()}");

foreach (int item in queue)
{
    Console.WriteLine(item);
}

Stack<int> stack = new Stack<int>();
 stack.Push(2); stack.Push(4); stack.Push(6); stack.Push(8); stack.Push(10);

foreach (int item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item:  {stack.Pop()}");

foreach (int item in stack)
{
    Console.WriteLine(item);
}


