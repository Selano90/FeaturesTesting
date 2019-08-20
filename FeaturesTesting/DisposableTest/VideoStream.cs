using System;

namespace FeaturesTesting.DisposableTest
{
    class VideoStream : IDisposable
    {
        private bool disposed = false;

        // Konstruktor
        public VideoStream()
        {
        }

        // Destruktor
        ~VideoStream()
        {
            Dispose(false);
        }

        // Implementierung der Schnittstelle IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }
    }
}
