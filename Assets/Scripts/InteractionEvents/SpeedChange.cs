using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange: InteractionEvent
{
    private const float defaultAnxietyAmount = 2f;
    private int[] speedList = new int[2];
    private int currentIndex = 0;
    private InfiniteRoad road;

    private void scrollIndex()
    {
        currentIndex++;
        if(currentIndex == speedList.Length)
        {
            currentIndex = 0;
        }
    }

    public SpeedChange(StateManager stateManager, InfiniteRoad road, float anxietyAmount = defaultAnxietyAmount): base(stateManager, anxietyAmount)
    {
        this.road = road;
        this.speedList[0] = road.getSpeed(); // tries to use serialized speed
        this.speedList[1] = road.getSpeed() + 100; // adds 100 to it (arbritrary)
    }

    public override void run()
    {
        base.run();
        // do stuff here
        scrollIndex();
        road.setSpeed(this.speedList[currentIndex]);
    }
}