using System.Threading;

//Thread t  = Thread.CurrentThread;
//t.Name = "MainThred";
//Console.WriteLine(t.Name);

public class MyThread
{
    // static method
    //public static void Thread1()
    
    // non static method
    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

public class ThreadExample
{
    public static void Main()
    {
        // for static method
        //Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
        //Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));

        // for non static method
        MyThread myThread = new MyThread();
        Thread t1 = new Thread(new ThreadStart(myThread.Thread1));
        Thread t2 = new Thread(new ThreadStart(myThread.Thread1));

        t1.Start();
        t2.Start();
    }
}