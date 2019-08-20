using System.Threading;

namespace FeaturesTesting.Threads
{
    class ThreadHandler
    {
        public Thread Thread { get; set; }

        public ThreadHandler()
        {
            Thread = new Thread(SomeMethod);
        }

        private void SomeMethod()
        {
            System.Console.WriteLine("In Thread : {0}", Thread.CurrentThread.Name);
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i + Thread.CurrentThread.Name);
            }
        }
    }
}
