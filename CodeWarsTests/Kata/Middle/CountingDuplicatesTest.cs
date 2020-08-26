﻿using CodeWars.Kata.Middle;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTests.Kata.Middle
{
    internal class CountingDuplicatesTest : BaseTest
    {
        public object DuplicateCount { get; private set; }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}
