using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnxietyBar : MonoBehaviour
{
    public float anxietyValue;
    public Slider anxietySlider;
    public StateManager stateManager;
    public GameObject firstCall;


    // Update is called once per frame
    private void Start()
    {
        stateManager = firstCall.GetComponent<First>().stateManager;
    }


    void Update()
    {
        
        anxietyValue = stateManager.getAnxiety();
        anxietySlider.value = anxietyValue;
    }
}

