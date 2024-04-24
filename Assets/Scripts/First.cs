using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class First : MonoBehaviour
{
    [SerializeField]
    private const uint winningDecisions = 50; // default set here

    private StateManager stateManager;
    

    private void Awake()
    {
        stateManager = new StateManager(winningDecisions);
    }
    
    public StateManager getManager()
    {
        return stateManager;
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
