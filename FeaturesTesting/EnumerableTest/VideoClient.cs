namespace FeaturesTesting.EnumerableTest
{
    class VideoClient
    {
        public VideoClient()
        {
            Name = null;
            Id = null;
        }

        public VideoClient(string name, int? id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int? Id { get; set; }

    }
}
