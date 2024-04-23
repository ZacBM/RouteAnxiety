using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AnxietyTest
{
    private Anxiety anxiety;
    [SetUp]
    // Anxiety class instantiation
    public void SetUp()
    {
        anxiety = new Anxiety();
    }

    [Test]
    public void subtracts_anxiety_by_50()
    {
        anxiety.changeAnxiety(-50);
        Assert.AreEqual(0, anxiety.getAnxiety());
    }
}
