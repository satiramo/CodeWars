using NUnit.Framework;
using System;
using System.Linq;

//Kata "Counting sheep..."
//https://www.codewars.com/kata/54edbc7200b811e956000556

namespace CountingSheep
{
    public static class Counter
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Where(x => x == true).Count();
        }
    }

    [TestFixture]
    public class CountSheepsTests
    {

        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Counter.CountSheeps(sheeps));
        }
    }
}