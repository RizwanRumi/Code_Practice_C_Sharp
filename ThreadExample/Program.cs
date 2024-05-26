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
        lock (this)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }

        //Naming thread
        //Thread t = Thread.CurrentThread;
        //Console.WriteLine(t.Name + " is running");
    }

    //public void Thread1()
    //{
    //    Console.WriteLine("Task one");
    //}
    //public void Thread2()
    //{
    //    Console.WriteLine("Task two");
    //}
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
        Thread t3 = new Thread(new ThreadStart(myThread.Thread1));

        //t1.Name = "Player 1";
        //t2.Name = "Player 2";
        //t3.Name = "Player 3";

        //t3.Priority = ThreadPriority.Highest;
        //t2.Priority = ThreadPriority.Normal;
        //t1.Priority = ThreadPriority.Lowest;

        t1.Start();
        //t1.Join();
        t2.Start();
        t3.Start();

        //try
        //{
        //    t1.Abort();
        //    t2.Abort();
        //}
        //catch (ThreadAbortException tae)
        //{
        //    Console.WriteLine(tae.ToString());
        //}

        //Console.WriteLine("End of Main");
    }
}