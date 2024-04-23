using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Anxiety
{
    private static float anxiety = 50f;

    public static void incrementAnxiety(float incrementor)
    {
        anxiety += incrementor;
        anxiety = Mathf.Clamp(anxiety, 0f, 100f);
        
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
        anxiety = 50f;
    }
}
