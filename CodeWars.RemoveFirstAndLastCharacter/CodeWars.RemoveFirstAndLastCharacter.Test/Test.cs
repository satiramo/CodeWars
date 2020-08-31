using NUnit.Framework;

namespace CodeWars.RemoveFirstAndLastCharacter.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", Program.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", Program.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", Program.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", Program.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", Program.Remove_char("ok"));
        }
    }
    
}