using System;

namespace FeaturesTesting.DelegatesEventsActions
{
    class Publisher
    {
        public class CameraConnectedEventArgs : EventArgs
        {
            public CameraConnectedEventArgs(Camera cam)
            {
                Camera = cam;
            }
            public Camera Camera { get; set; }
        }

        public Camera Camera { get; set; }
        public event EventHandler<CameraConnectedEventArgs> CameraConnected;

        public Publisher(Camera cam)
        {
            Camera = cam;
        }

        public void Connect()
        {
            Camera.Connect();
            onCameraConnected(Camera);
        }

        public void onCameraConnected(Camera camera)
        {
            if (CameraConnected != null)
                CameraConnected(this, new CameraConnectedEventArgs(camera));
        }


    }
}
