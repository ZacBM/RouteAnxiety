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

    [SerializeField]
    private CarController carController;
    [SerializeField]
    private ButtonInteraction buttonInteraction;

    private InfiniteRoad road;
    private StateManager stateManager = new StateManager(winningDecisions); // instantiate early before Start() runs
    private InteractionEventSpawner interactionEventSpawner;

    void Start()
    {
        road = new InfiniteRoad(speed, roadPieces, length);
        road.Start();
        interactionEventSpawner = new InteractionEventSpawner(); // ALL HARD CODED 2f for now
        ChangeMusic changeMusic = new ChangeMusic(stateManager, 2f);
        ChangeLane changeLane = new ChangeLane(stateManager, carController, 2f);
        SpeedChange speedChange = new SpeedChange(stateManager, road, 2f);
        WindowChange windowChange = new WindowChange(stateManager, 2f);
        interactionEventSpawner.addInteractionEvent(changeMusic);
        interactionEventSpawner.addInteractionEvent(changeLane);
        interactionEventSpawner.addInteractionEvent(speedChange);
        interactionEventSpawner.addInteractionEvent(windowChange);
        buttonInteraction.InitManager(stateManager);
        buttonInteraction.Init(changeMusic, windowChange, changeLane, speedChange);
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
