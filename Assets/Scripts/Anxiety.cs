using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Anxiety
{
    private const float startingAnxiety = 50f;
    private static float anxiety = startingAnxiety;

    public static void incrementAnxiety(float incrementor)
    {
        setAnxiety(anxiety + incrementor);
    }

    public static float getAnxiety()
    {
        return anxiety;
    }
    
    public static void setAnxiety(float newAnxiety)
    {
        anxiety = Mathf.Clamp(newAnxiety, 0f, 100f);
    }

    public static void reset()
    {
        anxiety = startingAnxiety;
    }
}
