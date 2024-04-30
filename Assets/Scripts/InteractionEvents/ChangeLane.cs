using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeLane : InteractionEvent
{
    private bool currentLaneIsLeft = true;
    private const float defaultAnxietyAmount = 2f;
    private Vector3 firstLane;
    private Vector3 secondLane;
    private CarController carController;

    public ChangeLane(StateManager stateManager, CarController carController, float anxietyAmount = defaultAnxietyAmount) : base(stateManager, anxietyAmount)
    {
        this.carController = carController;
        firstLane = carController.getTransform().position;
        secondLane = firstLane + new Vector3(carController.getTransform().localScale.x, 0, 0);
        secondLane = new Vector3(secondLane.x * 10, secondLane.y, secondLane.z);
    }

    public override void run()
    {
        base.run();
        // do stuff here
        currentLaneIsLeft = !currentLaneIsLeft;
        carController.lerpCarToPosition(currentLaneIsLeft ? firstLane : secondLane);
    }
}