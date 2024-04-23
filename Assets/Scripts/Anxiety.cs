using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anxiety
{
    private float anxiety = 50f;
    // Start is called before the first frame update

    public void changeAnxiety(float change)
    {
        anxiety += change;
    }

    public float getAnxiety()
    {
        return anxiety;
    }
}
