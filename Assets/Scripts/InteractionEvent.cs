using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionEvent
{
    private float anxietyIncrement;

    public InteractionEvent(float anxietyIncrement)
    {
        this.anxietyIncrement = anxietyIncrement;
    }

    public virtual void run()
    {
        Anxiety.incrementAnxiety(anxietyIncrement);
    }

    public float getAnxietyIncrement()
    {
        return anxietyIncrement;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}