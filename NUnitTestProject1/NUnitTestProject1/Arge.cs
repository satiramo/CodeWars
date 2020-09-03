using NUnit.Framework;
using System;

namespace GrowthOfAPopulation
{
    //Kata "Growth of a Population"
    //https://www.codewars.com/kata/563b662a59afc2b5120000c6/train/csharp
    class Arge
    {
        /// <summary>
        /// ������� ���������� ��������� ������� ����� ���, ���� ����� � ��������� ���������
        /// p0 ������ ����������� p
        /// </summary>
        /// <param name="p0">��������� ��������� ������.</param>
        /// <param name="percent">������� ������������� ��������(�������� ����� �����).</param>
        /// <param name="aug">����������� � ��� �����.</param>
        /// <param name="p">�����������, ������� ����� �������.</param>
        /// <returns></returns>
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            if (p0 >= p)
                return 0;
            int populationToTheEndOfThePeriod = (int)(p0 + p0 * percent / 100 + aug);
            return 1 + NbYear(populationToTheEndOfThePeriod, percent, aug, p);
        }
    }
    [TestFixture]
    public static class ArgeTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing NbYear");
            testing(Arge.NbYear(1500, 5, 100, 5000), 15);
            testing(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}