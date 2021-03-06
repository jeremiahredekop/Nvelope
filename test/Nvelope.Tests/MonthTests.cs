﻿using NUnit.Framework;

namespace Nvelope.Tests
{
    [TestFixture]
    public class MonthTests
    {
        [Test]
        public void CastToInt()
        {
            Assert.AreEqual(1, (int)Month.January);            
        }

        [Test]
        public void ConvertToInt()
        {
            Assert.AreEqual(1, Month.January.ConvertTo<int>());
        }

        [Test]
        public void FromInt()
        {
            Assert.AreEqual(Month.January, 1.ConvertTo<Month>());            
        }

        [Test]
        public void FromString()
        {
            Assert.AreEqual(Month.January, "January".ConvertTo<Month>());
            Assert.AreEqual(Month.April, "April".ConvertTo<Month>());
        }

        [Test]
        public void FromAbbreviation()
        {
            Assert.AreEqual(Month.January, "Jan".ConvertTo<Month>());
            Assert.AreEqual(Month.April, "Apr".ConvertTo<Month>());
        }
    }
}
