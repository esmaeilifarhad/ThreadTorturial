// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




using ThreadTorturial;


/*
 ترد ساده
SimpleThread SimpleThread = new SimpleThread();

var thread1 = new Thread(SimpleThread.Thread1Job);
var thread2 = new Thread(SimpleThread.Thread2Job);
var thread3 = new Thread(SimpleThread.Thread3Job);

thread1.Start();
thread2.Start();
thread3.Start();
*/

/*
 شرایط مسابقه
MatchBetweenThreads matchBetweenThreads = new MatchBetweenThreads();
matchBetweenThreads.CreateThreadAndCallThem(); 
*/

/*
 بن بست
 */
object obj1=new object();
object obj2 = new object();

DeadLock deadLock = new DeadLock(obj1,obj2);

Thread t1 = new Thread(new ThreadStart(deadLock.DeadLock1));
Thread t2 = new Thread(new ThreadStart(deadLock.DeadLock2));

t1.Start();
t2.Start();
