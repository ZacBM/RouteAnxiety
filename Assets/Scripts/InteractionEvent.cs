using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionEvent
{
    private StateManager stateManager;
    private float anxietyIncrement;

    public InteractionEvent(StateManager stateManager, float anxietyIncrement = 0f)
    {
        this.stateManager = stateManager;
        this.anxietyIncrement = anxietyIncrement;
    }

    public virtual void run()
    {
        stateManager.processDecision(anxietyIncrement);
    }

    public float getAnxietyIncrement()
    {
        return anxietyIncrement;
    }
}