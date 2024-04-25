using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic: InteractionEvent
{
    public ChangeMusic(StateManager stateManager, float anxietyAmount): base(stateManager, anxietyAmount)
    {
        
    }

    public override void run()
    {
        base.run();
        // do stuff here
    }
}