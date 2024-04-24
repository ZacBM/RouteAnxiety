using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager
{
    private const float defaultAnxiety = 0f;
    private float anxiety = 0f;
    private readonly uint winningDecisions;
    private uint decisions;

    public StateManager(uint winningDecisions)
    {
        this.winningDecisions = winningDecisions;
    }

    public bool won()
    {
        return anxiety > 0f && anxiety < 100f && decisions >= winningDecisions;
    }

    public bool lost()
    {
        return anxiety == 0f || anxiety == 100f;
    }

    public void addDecision()
    {
        decisions++;
    }
    
    private void changeAnxiety(float anxiety)
    {
        this.anxiety = Mathf.Clamp(anxiety, 0f, 100f);
    }

    public void processDecision(float anxietyIncrement)
    {
        incrementAnxiety(anxietyIncrement);
        addDecision();
    }

    public float getAnxiety()
    {
        return anxiety;
    }

    public void incrementAnxiety(float anxietyIncrement)
    {
        changeAnxiety(getAnxiety() + anxietyIncrement);
    }
}