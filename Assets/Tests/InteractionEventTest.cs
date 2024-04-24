using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InteractionEventTest
{
    private const int winningDecisions = 50;
    private static StateManager stateManager = new(winningDecisions);

    private class BaseTest: InteractionEvent
    {
        public BaseTest(float anxietyAmount) : base(stateManager, anxietyAmount)
        {

        }
    }

    private BaseTest test;
    private const float testAmount = 2f;

    [SetUp]
    public void SetUp()
    {
        test = new BaseTest(testAmount);
    }

    [Test]
    public void can_read_anxiety_increment()
    {
        Assert.AreEqual(testAmount, test.getAnxietyIncrement());
    }

    [Test]
    public void runChangesAnxiety()
    {
        float current = stateManager.getAnxiety();
        test.run();
        Assert.AreEqual(current + testAmount, stateManager.getAnxiety());
    }
}
