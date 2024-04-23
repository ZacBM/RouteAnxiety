using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AnxietyTest
{
    [SetUp]
    // Anxiety class instantiation
    public void SetUp()
    {
        Anxiety.reset();
    }
    [Test]
    public void check_if_anxiety_starts_at_50()
    {
        Assert.AreEqual(50, Anxiety.getAnxiety());
    }
    [Test]
    public void subtracts_50_from_anxiety_with_initial_50()
    {
        Anxiety.incrementAnxiety(-50);
        Assert.AreEqual(0, Anxiety.getAnxiety());
    }
    [Test]
    public void subtract_60_from_anxiety_with_initial_50_to_get_0()
    {
        Anxiety.incrementAnxiety(-60);
        Assert.AreEqual(0, Anxiety.getAnxiety());
    }
    [Test]
    public void adds_50_to_anxiety_with_initial_50()
    {
        Anxiety.incrementAnxiety(50);
        Assert.AreEqual(100, Anxiety.getAnxiety());
    }
    [Test]
    public void adds_60_to_anxiety_with_initial_50_to_get_100()
    {
        Anxiety.incrementAnxiety(60);
        Assert.AreEqual(100, Anxiety.getAnxiety());
    }
}
