using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionEvent : MonoBehaviour
{
    private float anxietyIncrement;

    public InteractionEvent(float anxietyIncrement)
    {
        this.anxietyIncrement = anxietyIncrement;
    }

    protected virtual void run()
    {
        Anxiety.incrementAnxiety(anxietyIncrement);
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
