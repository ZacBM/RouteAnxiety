using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager
{
    private const float defaultAnxiety = 50f;
    private float anxiety = 50f;
    private readonly int winningDecisions;
    private int decisions;

    public StateManager(int winningDecisions)
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
    
    public void changeAnxiety(float anxiety)
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

    public float getDefaultAnxiety()
    {
        return defaultAnxiety;
    }

    public void incrementAnxiety(float anxietyIncrement)
    {
        changeAnxiety(getAnxiety() + anxietyIncrement);
    }

    public void resetAnxiety()
    {
        anxiety = defaultAnxiety;
    }

    public void reset()
    {
        resetAnxiety();
        decisions = 0;
    }
    
    public void switchIfWonOrLost()
    {
        if (won())
        {
            reset();
            SceneControl.switchToWin();
        }
        else if (lost())
        {
            reset();
            SceneControl.switchToLost();
        }
    }
}