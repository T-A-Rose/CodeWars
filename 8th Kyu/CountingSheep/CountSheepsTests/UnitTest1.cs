using System;
using NUnit.Framework;

[TestFixture]
public class CountSheepsTests
{

    [Test]
    public void SampleTest()
    {
        var sheeps = new bool[] { true, false, true };

        Assert.AreEqual(2, Kata.CountSheeps(sheeps));
    }
}