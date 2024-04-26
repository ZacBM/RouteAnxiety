using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class First : MonoBehaviour
{
    [SerializeField]
    private float secondsUntilSpawn = 2f;
    private float timeCount;

    [SerializeField]
    private const int winningDecisions = 50; // default set here

    private StateManager stateManager;
    private InteractionEventSpawner interactionEventSpawner;

    void Start()
    {
        stateManager = new StateManager(winningDecisions);
        interactionEventSpawner = new InteractionEventSpawner();
        interactionEventSpawner.addInteractionEvent(new ChangeMusic(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new ChangeLane(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new SpeedChange(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new WindowChange(stateManager, 2f)); // HARD CODED 2f for now
    }

    public StateManager getManager()
    {
        return stateManager;
    }

    public InteractionEventSpawner getInteractionEventSpawner()
    {
        return interactionEventSpawner;
    }

    // Update is called once per frame
    void Update()
    {
        float now = Time.deltaTime;
        if (timeCount >= secondsUntilSpawn)
        {
            timeCount = 0;
            // start spawning a random event
        } else
        {
            timeCount += now;
        }
    }
}
