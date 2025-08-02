public class MyStack {
    private Queue<int> firstQueue;
    public MyStack() {
        firstQueue = new Queue<int>();  
    }
    
    public void Push(int x) {
         var queueCount = firstQueue.Count;
        firstQueue.Enqueue(x);
       while (firstQueue.Count > 0 && queueCount != 0)
 {
     var temp = firstQueue.Dequeue();
     firstQueue.Enqueue(temp);
     queueCount--;
 }
    }
    
   public int Pop()
    => firstQueue.Dequeue();

public int Top()
{
    return firstQueue.Peek();
}

public bool Empty()
{
    return !firstQueue.Any();
}
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */