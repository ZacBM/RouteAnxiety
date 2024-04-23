using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anxiety : MonoBehaviour
{
    private float anxiety = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeAnxiety(float change)
    {
        anxiety -= change;
    }

    public float getAnxiety()
    {
        return anxiety;
    }
}
