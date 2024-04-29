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
    private int speed = 70;
    [SerializeField]
    private List<GameObject> roadPieces;
    [SerializeField]
    private int length = 95;

    [SerializeField]
    private CarController carController;
    [SerializeField]
    private ButtonInteraction buttonInteraction;

    [SerializeField]
    private AudioSource musicSource;
    [SerializeField]
    private AudioSource drivingSource;
    [SerializeField]
    private List<AudioClip> tracks;
    [SerializeField]
    private float staticVolume = 1f;

    private BackgroundAudio audio;
    private InfiniteRoad road;
    public StateManager stateManager = new StateManager(winningDecisions); // instantiate early before Start() runs
    private InteractionEventSpawner interactionEventSpawner;

    void Start()
    {
        road = new InfiniteRoad(speed, roadPieces, length);
        road.Start();

        audio = new BackgroundAudio(musicSource, drivingSource, tracks, staticVolume);
        audio.Start();

        interactionEventSpawner = new InteractionEventSpawner(); // ALL HARD CODED 2f for now
        ChangeMusic changeMusic = new ChangeMusic(stateManager, audio, -10f);
        ChangeLane changeLane = new ChangeLane(stateManager, carController, 10f);
        SpeedChange speedChange = new SpeedChange(stateManager, road, 10f);
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
