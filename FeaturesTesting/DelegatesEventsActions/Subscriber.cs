namespace FeaturesTesting.DelegatesEventsActions
{
    class Subscriber
    {
        public void onCameraConnected(object source, Publisher.CameraConnectedEventArgs args)
        {
            System.Console.WriteLine("Subscriber: Event received - {0} Connected", args.Camera.name);
        }
    }
}
