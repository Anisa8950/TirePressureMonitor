using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using TirePressureMonitor;


namespace TirePressureMonitor.Test.Unit
{
    class EvenFilterUnitTest
    {
        private IFilter _uut;
        private int Sample;

        [SetUp]
        public void SetUp()
        {
            _uut = new EvenFilter();
        }


        //WHEN: list consists of numbers that are the same
        //GIVEN: Filter() is called 
        //THEN: average is excatly that number 

        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(789, 789)]
        public void tester(int input, int expectedResult)
        {

            int result = _uut.Filter(Sample);

            Assert.That(result,Is.EqualTo(expectedResult));
        }







    }
}
