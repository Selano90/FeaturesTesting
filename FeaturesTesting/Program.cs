using System;
using System.Threading;

namespace FeaturesTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            ////TEST FIRSTTEST
            //string str = "Hallo";
            //Test test = new Test();
            //Regex RegTest = new Regex("allo");
            //str = test.RegExResult(RegTest, str);
            //Console.WriteLine(test.GenerateId());
            //Console.WriteLine(str);
            //Console.WriteLine(test.Id);
            //Console.Read();

            ////TEST IENUMERABLE
            //EnumerableTest.VideoClient[] clients = new EnumerableTest.VideoClient[3]
            //{
            //    new EnumerableTest.VideoClient("video1", 1),
            //    new EnumerableTest.VideoClient("video2", 2),
            //    new EnumerableTest.VideoClient("video3", 3),
            //};

            //EnumerableTest.VideoClients videos = new EnumerableTest.VideoClients(clients);
            //foreach (EnumerableTest.VideoClient vc in videos)
            //    Console.WriteLine(vc.Name + " " + vc.Id);

            ////TEST ICOMPARABLE
            //ComparableEqualsTest.Video video = new ComparableEqualsTest.Video(50);
            //ComparableEqualsTest.Video video2 = new ComparableEqualsTest.Video(50);

            //Console.WriteLine(video.CompareTo(video2));
            //Console.WriteLine(video.Equals(video2));

            //ComparableEqualsTest.Video[] videoz = new ComparableEqualsTest.Video[3]
            //{ new ComparableEqualsTest.Video(500), new ComparableEqualsTest.Video(600), new ComparableEqualsTest.Video(400) };


            //foreach (ComparableEqualsTest.Video v in videoz)
            //    Console.WriteLine(v.FramesPerSecond);

            //Array.Sort(videoz);

            //foreach (ComparableEqualsTest.Video v1 in videoz)
            //    Console.WriteLine(v1.FramesPerSecond);

            //ComparableEqualsTest.Video compareVid = new ComparableEqualsTest.Video(600);
            //int index = Array.BinarySearch(videoz, compareVid);

            //Console.WriteLine(index);

            ////TEST IDISPOSABLE
            //using (VideoStream vs = new VideoStream())
            //{
            //    //Stuff
            //}

            //VideoStream vs2 = new VideoStream();
            //vs2.Dispose();

            ////TEST ACTION AND FUNC DELEGATES
            //DelegatesEventsActions.ActionFuncTest actionTest = new DelegatesEventsActions.ActionFuncTest();
            //actionTest.Action = actionTest.PrintAction;
            //actionTest.Action(1);

            //actionTest.Function = actionTest.AuCarre;
            //double powertwo = actionTest.Function(5);
            //Console.WriteLine(powertwo);

            ////EVENTS
            //DelegatesEventsActions.Camera cam = new DelegatesEventsActions.Camera("Camera 1");
            //DelegatesEventsActions.Publisher pub = new DelegatesEventsActions.Publisher(cam);
            //DelegatesEventsActions.Subscriber sub = new DelegatesEventsActions.Subscriber();

            //pub.CameraConnected += sub.onCameraConnected;
            //pub.Connect();

            //var a = TaskTest.MyMethodAsync(); //Task started for Execution and immediately goes to Line 19 of the code. Cursor will come back as soon as await operator is met		
            //Console.WriteLine("Cursor Moved to Next Line Without Waiting for MyMethodAsync() completion");
            //Console.WriteLine("Now Waiting for Task to be Finished");
            ////Task.WaitAll(a); //Now Waiting		
            ////Console.WriteLine("Exiting CommandLine");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine("Started");
            //string path = @"C:\Users\sbenh\Downloads\abstract-1-sharon-cummings.jpg";
            //path = path.Replace(@"\\", @"\");
            //Task<byte[]> b = Tasks.ImageDemo.BlackAndWhiteImage(path);
            //Console.WriteLine(b);
            //Task.WaitAll(b);
            //Tasks.ImageDemo.SaveImage(b.Result, path);
            //Task.WaitAny();
            //Console.WriteLine("Exit");

            //// use an Action delegate and named method
            //Task task1 = new Task(new Action(printMessage));
            //// use an anonymous delegate
            //Task task2 = new Task(delegate { printMessage(); });
            //// use a lambda expression and a named method
            //Task task3 = new Task(() => printMessage());
            //// use a lambda expression and an anonymous method
            //Task task4 = new Task(() => { printMessage(); });

            //task1.Start();
            ////task1.Wait();
            //task2.Start();
            ////task2.Wait();
            //task3.Start();
            ////task3.Wait();
            //task4.Start();
            ////task4.Wait();
            //Console.WriteLine("Main method complete. Press <enter> to finish.");

            Threads.ThreadHandler th = new Threads.ThreadHandler();
            Threads.ThreadHandler th2 = new Threads.ThreadHandler();

            Thread.CurrentThread.Priority = ThreadPriority.Lowest;

            th2.Thread.Name = "Thread 2";
            th2.Thread.Priority = System.Threading.ThreadPriority.Highest;

            th.Thread.Name = "Thread 1";
            th.Thread.Priority = System.Threading.ThreadPriority.Normal;

            th.Thread.Start();
            th2.Thread.Start();
            //th.Thread.Join();
            //th2.Thread.Join();


            Console.WriteLine("Press Enter to Terminate");
            Console.ReadLine();

        }

        private static void printMessage()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}