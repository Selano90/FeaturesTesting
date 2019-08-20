using System;

namespace FeaturesTesting.ComparableEqualsTest
{
    class Video : IComparable, IEquatable<Video>
    {
        public Video(int fps)
        {
            FramesPerSecond = fps;
        }
        public int FramesPerSecond { get; set; }

        //Way1:
        //IComparable.CompareTo
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Video otherVideo = obj as Video;
            if (obj != null)
                return this.FramesPerSecond.CompareTo(otherVideo.FramesPerSecond);
            else
                throw new ArgumentException("Object is not a Video");
        }

        //Way2
        //IEquatable<>.Equals
        public bool Equals(Video other)
        {
            if (other == null)
                return false;

            if (this.FramesPerSecond == other.FramesPerSecond)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Video video = obj as Video;
            if (video == null)
                return false;
            else
                return Equals(video);
        }

        public override int GetHashCode()
        {
            return 642343962 + FramesPerSecond.GetHashCode();
        }
    }
}