using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class StateManagerTest
{
    private StateManager manager;
    [SetUp]
    public void SetUp()
    {
        manager = new StateManager(10);
    }
    [Test]
    public void check_starting_anxiety_equals_default_anxiety()
    {
        Assert.AreEqual(manager.getDefaultAnxiety(), manager.getAnxiety());
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
    [Test]
    public void check_if_lose_condition_works_after_incrementing_twice()
    {
        manager.changeAnxiety(49);
        for (int i = 0; i < 2; i++)
        {
            manager.incrementAnxiety(50);
        }
        Assert.IsTrue(manager.lost());
    }
    [Test]
    public void check_if_lose_condition_works_after_decrementing_twice()
    {
        manager.changeAnxiety(51);
        for (int i = 0; i < 2; i++)
        {
            manager.incrementAnxiety(-50);
        }
        Assert.IsTrue(manager.lost());
    }
    [Test]
    public void check_if_win_condition_works_after_10_decisions()
    {
        manager.changeAnxiety(50);
        for (int i = 0; i < 10;i++)
        {
            manager.addDecision();
        }
        Assert.IsTrue(manager.won());
    }
    [Test]
    public void check_if_reset_changes_anxiety_to_default()
    {
        manager.resetAnxiety();
        Assert.AreEqual(manager.getDefaultAnxiety(), manager.getAnxiety());
    }
}
