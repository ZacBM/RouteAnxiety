using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anxiety
{
    private float anxiety = 50f;
    // Start is called before the first frame update

    public void incrementAnxiety(float incrementor)
    {
        anxiety += incrementor;
        if (anxiety < 0)
        {
            anxiety = 0;
        }
        else if (anxiety > 100){
            anxiety = 100;
        }
    }

    public float getAnxiety()
    {
        return anxiety;
    }
    
    public void setAnxiety(float newAnxiety)
    {
        anxiety = newAnxiety;
    }
}
