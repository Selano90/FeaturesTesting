using System;
using System.Text.RegularExpressions;
namespace FeaturesTesting
{
    class Test : AbstractTest
    {

        public Test() : base()
        {

        }

        public Test(int id) : base(id)
        {

        }

        public override int GenerateId()
        {
            Random rnd = new Random();
            Id = rnd.Next();
            return Id;
        }

        public override string RegExResult(Regex RegTest, string str)
        {
            return RegTest.Match(str).Value;
        }
    }
}
