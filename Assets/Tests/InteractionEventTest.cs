using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InteractionEventTest
{
    private class BaseTest: InteractionEvent
    {
        public BaseTest(float anxietyAmount) : base(anxietyAmount)
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
        float current = Anxiety.getAnxiety();
        test.run();
        Assert.AreEqual(current + testAmount, Anxiety.getAnxiety());
    }
}
