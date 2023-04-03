using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RecursiveVersionOfBinarySearch
{
    [TestFixture]
    public class NUnit
    {

        [TestCase(new int[] { 2, 4, 4, 6 }, 1, -1, 'l')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 2, -1, 'r')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 3, 0, 'l')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 4, 0, 'r')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 5, 2, 'l')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 6, 2, 'r')]
        [TestCase(new int[0], 1, -1, 'l')]
        [TestCase(new int[] { 2, 4, 4, 6 }, 7, 3, 'r')]
        
        public void Tests(int[] array, int value, int result, char border)
        {
            Assert.AreEqual(result, Program.FindBorder(array, value, border));
        } 
    }
}
