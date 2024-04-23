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
    public void check_if_anxiety_starts_at_50()
    {
        Assert.AreEqual(0, anxiety.getAnxiety());
    }
    [Test]
    public void subtracts_anxiety_from_50_from_initial_50()
    {
        anxiety.changeAnxiety(-50);
        Assert.AreEqual(0, anxiety.getAnxiety());
    }
    [Test]
    public void adds_anxiety_to_50_from_initial_50()
    {
        anxiety.changeAnxiety(50);
        Assert.AreEqual(0, anxiety.getAnxiety());
    }
}
