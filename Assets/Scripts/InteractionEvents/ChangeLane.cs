using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLane : InteractionEvent
{
    private const float defaultAnxietyAmount = 2f;

    public ChangeLane(StateManager stateManager, float anxietyAmount = defaultAnxietyAmount) : base(stateManager, anxietyAmount)
    {

    }

    public override void run()
    {
        base.run();
        // do stuff here
    }
}