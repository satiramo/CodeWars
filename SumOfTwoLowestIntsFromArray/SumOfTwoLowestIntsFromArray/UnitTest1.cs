using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SumOfTwoLowestIntsFromArray
{
    public static class Calculator
    {   
    /// <summary>
    /// ����� ���������� ����� ���� ���������� ����� �������.
    /// �� ������� ������ � CodeWars �������������, ��� ������ �������� ������� 4 ��������
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }
    }

    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void Test1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Calculator.sumTwoSmallestNumbers(numbers));
        }
    }
}