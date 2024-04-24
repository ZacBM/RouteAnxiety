using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class StateManagerTest
{
    private StateManager manager;
    [SetUp]
    public void SetUp()
    {
        manager = new StateManager();
    }
    [Test]
    public void check_default_anxiety_equals_0()
    {
        Assert.AreEqual(0, manager.getAnxiety());
    }
    [Test]
    public void set_anxiety_to_50()
    {
        manager.changeAnxiety(50);
        Assert.AreEqual(50, manager.getAnxiety());
    }
    [Test]
    public void set_anxiety_to_value_above_100()
    {
        manager.changeAnxiety(200);
        Assert.AreEqual(100, manager.getAnxiety());
    }
    [Test]
    public void set_anxiety_to_value_below_0()
    {
        manager.changeAnxiety(-100);
        Assert.AreEqual(0, manager.getAnxiety());
    }
    [Test]
    public void increment_anxiety_by_5_after_setting_to_20()
    {
        manager.changeAnxiety(20);
        manager.incrementAnxiety(5);
        Assert.AreEqual(25, manager.getAnxiety());
    }
    [Test]
    public void decrement_anxiety_by_5_after_setting_to_20()
    {
        manager.changeAnxiety(20);
        manager.incrementAnxiety(-5);
        Assert.AreEqual(15, manager.getAnxiety());
    }
    [Test]
    public void increment_anxiety_beyond_100()
    {
        manager.changeAnxiety(20);
        manager.incrementAnxiety(90);
        Assert.AreEqual(100, manager.getAnxiety());
    }
    [Test]
    public void decrement_anxiety_below_0()
    {
        manager.changeAnxiety(20);
        manager.incrementAnxiety(-30);
        Assert.AreEqual(0, manager.getAnxiety());
    }
}
