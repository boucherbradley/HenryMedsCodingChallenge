using System.ComponentModel;

namespace CodingChallengeBusinessLayer
{
    public class Enum
    {
        public enum Sex
        {
            [Description("Male")]
            M,
            [Description("Female")]
            F,
            [Description("Non-Binary")]
            NonBinary,
            [Description("Other")]
            Other
        }
    }
}
