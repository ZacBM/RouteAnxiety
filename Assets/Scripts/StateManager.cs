using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager
{
    private const float defaultAnxiety = 0f;
    private float anxiety = 0f;

    public StateManager(float anxiety = defaultAnxiety)
    {
        this.anxiety = anxiety;
    }

    public void changeAnxiety(float anxiety)
    {
        this.anxiety = Mathf.Clamp(anxiety, 0f, 100f);
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