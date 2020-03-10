using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TirePressureMonitor;

namespace TirePressureMonitor.Test.Unit
{
    class RemoveSpikesFilterUnitTest
    {


        private IFilter _uut;

        [SetUp]
        public void SetUp()
        {
            _uut= new RemoveSpikesFilter();
        }



        //WHEN: one sample is given
        //GIVEN: Filter() is called 
        //THEN: returns that exact sample 

        [Test]
        public void Filter_oneSample_returnSample()
        {
            int result = _uut.Filter(35);

            Assert.That(result, Is.EqualTo(2));
        }


        //WHEN: one sample is 5 psi higher than previous sample
        //GIVEN: Filter() is called twice 
        //THEN: returns the previous sample

        [Test]
        public void Filter_sampleHigherThanPrevoius_returnPreviousSample()
        {
            _uut.Filter(40);
            int result = _uut.Filter(46);

            Assert.That(result, Is.EqualTo(40));
        }

    }
}
