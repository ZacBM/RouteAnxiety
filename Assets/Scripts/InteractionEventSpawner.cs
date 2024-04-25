using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEventSpawner
{
    private List<InteractionEvent> interactions;

    public InteractionEventSpawner() { 
        interactions = new List<InteractionEvent>();
    }

    public void addInteractionEvent(InteractionEvent interaction)
    {
        interactions.Add(interaction);
    }

    public InteractionEvent selectRandomEvent()
    {
        return interactions[Random.Range(0, interactions.Count)];
    }
}
