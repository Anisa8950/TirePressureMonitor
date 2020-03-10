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
    public class EvaluateSampleUnitTest
    {

        private EvaluateSample _uut;
        private Tire tire1;
        private FakeWarning fakeWarning;


        [SetUp]

        public void SetUp()
        {
            tire1 = new Tire();
            fakeWarning = new FakeWarning();

            _uut = new EvaluateSample(fakeWarning);
           

        }


        
        //WHEN: pressure is lower than 30
        //GIVEN: Evaluate() is called 
        //THEN: alarmOn is called

        [Test]
        public void Evaluate_LowPressure_AlarmOnIsCalled()
        {
            tire1.pressure_ = 25;
            
            _uut.Evaluate(tire1.pressure_);

            Assert.That(fakeWarning.alarmOnCounter,Is.EqualTo(1));
        }


        //WHEN: pressure is higher than 30 and less than 40
        //GIVEN: Evaluate() is called 
        //THEN: alarmOff is called

        [Test]
        public void Evaluate_PressureOK_AlarmOffIsCalled()
        {
            tire1.pressure_ = 35;

            _uut.Evaluate(tire1.pressure_);

            Assert.That(fakeWarning.alarmOffCounter, Is.EqualTo(1));
        }

        ////WHEN: pressure is out of range
        ////GIVEN: Evaluate() is called 
        ////THEN: exception was thown 

        //[Test]
        //public void Evaluate_PressureOutOfRange_ConsoleText()
        //{
        //    tire1.pressure_ = 60;

        //    _uut.Evaluate();

        //}



    }
}
