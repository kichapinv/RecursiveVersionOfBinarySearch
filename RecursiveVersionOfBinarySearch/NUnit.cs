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

        [TestCase(new long[] { 2, 4, 4, 6 }, 1, -1)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 2, -1)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 3, 0)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 4, 0)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 5, 2)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 6, 2)]
        [TestCase(new long[0], 1, -1)]
        [TestCase(new long[] { 2, 4, 4, 6 }, 7, 3)]
        
        public void Tests(long[] array, long value, long result)
        {
            Assert.AreEqual(result, Program.FindLeftBorder(array, value));
        } 
    }
}
