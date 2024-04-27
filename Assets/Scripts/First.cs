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

    [SerializeField]
    private int speed = 10;
    [SerializeField]
    private List<GameObject> roadPieces;
    [SerializeField]
    private int length = 20;

    private InfiniteRoad road;
    private StateManager stateManager = new StateManager(winningDecisions); // instantiate early before Start() runs
    private InteractionEventSpawner interactionEventSpawner;

    void Start()
    {
        interactionEventSpawner = new InteractionEventSpawner();
        interactionEventSpawner.addInteractionEvent(new ChangeMusic(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new ChangeLane(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new SpeedChange(stateManager, 2f)); // HARD CODED 2f for now
        interactionEventSpawner.addInteractionEvent(new WindowChange(stateManager, 2f)); // HARD CODED 2f for now
        road = new InfiniteRoad(speed, roadPieces, length);
        road.Start();
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
        road.Update();
    }
}
