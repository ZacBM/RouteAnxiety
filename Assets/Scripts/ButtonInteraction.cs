using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    public bool windowUp = true;
    public int whichLane = 1;
    public bool goFast = false;

    private StateManager stateManager;
    private ChangeMusic changeMusic;
    private WindowChange windowChange;
    private ChangeLane changeLane;
    private SpeedChange speedChange;

    public void InitManager(StateManager stateManager)
    {
        this.stateManager = stateManager;
    }

    public void Init(ChangeMusic changeMusic, WindowChange windowChange, ChangeLane changeLane, SpeedChange speedChange)
    {
        this.changeMusic = changeMusic;
        this.windowChange = windowChange;
        this.changeLane = changeLane;
        this.speedChange = speedChange;
        // not very pretty arguments but it will have to do for now
    }

    public void Start()
    { 
        
    }

    public void MusicChange()
    {
        changeMusic.run();
        Debug.Log("Music Changed");
    }

    public void SpeedChange ()
    {
        //ChangeLanes();
        speedChange.run();
        if (goFast == true)
        {
            Debug.Log("Go Slow!");
            goFast = false;
        }
        else if (goFast == false)
        {
            Debug.Log("Go Fast!");
            goFast = true;
        }
    }

    public void WindowChange()
    {
        windowChange.run();
        if (windowUp == true)
        {
            Debug.Log("Window Down");
            windowUp = false;
        }
        else if(windowUp == false)
        {
            Debug.Log("Window Up");
            windowUp = true;
        }
    }

    public void ChangeLanes()
    {
        changeLane.run();
        Debug.Log("No Turn Signal");
    }
}
