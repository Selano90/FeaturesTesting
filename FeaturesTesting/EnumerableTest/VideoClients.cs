using System;
using System.Collections;

namespace FeaturesTesting.EnumerableTest
{
    class VideoClients : IEnumerable
    {
        private VideoClient[] _videoClients;

        public VideoClients(VideoClient[] videoclient)
        {
            _videoClients = new VideoClient[videoclient.Length];

            for (int i = 0; i < videoclient.Length; i++)
            {
                _videoClients[i] = videoclient[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public VideoClientEnum GetEnumerator()
        {
            return new VideoClientEnum(_videoClients);
        }
    }

    class VideoClientEnum : IEnumerator
    {
        public VideoClient[] _videoclients;
        int position = -1;

        public VideoClientEnum(VideoClient[] list)
        {
            _videoclients = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _videoclients.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public VideoClient Current
        {
            get
            {
                try
                {
                    return _videoclients[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
