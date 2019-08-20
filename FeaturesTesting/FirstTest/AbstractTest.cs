using System.Text.RegularExpressions;

namespace FeaturesTesting
{
    abstract class AbstractTest : ITest
    {
        ///<summary>
        ///default constructor
        ///</summary>
        public AbstractTest()
        {

        }

        ///<summary>
        ///init constructor
        ///</summary>
        public AbstractTest(int id)
        {
            Id = id;
        }

        ///<summary>
        ///Test ID
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        ///Generate a test Id
        ///</summary>
        public abstract int GenerateId();

        ///<summary>
        ///Execute a given regular expression on a given string
        ///</summary>
        public abstract string RegExResult(Regex RegTest, string str);
    }
}
