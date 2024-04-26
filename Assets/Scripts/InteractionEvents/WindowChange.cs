using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowChange : InteractionEvent
{
    private const float defaultAnxietyAmount = 2f;

    public WindowChange(StateManager stateManager, float anxietyAmount = defaultAnxietyAmount) : base(stateManager, anxietyAmount)
    {

    }

    public override void run()
    {
        base.run();
        // do stuff here
    }
}