using System.Threading;

namespace FeaturesTesting.DelegatesEventsActions
{
    class Camera
    {
        public string name { get; set; }

        public void Connect()
        {
            System.Console.WriteLine("Connecting...");
            Thread.Sleep(3000);
        }

        public Camera(string name)
        {
            this.name = name;
        }
    }
}
