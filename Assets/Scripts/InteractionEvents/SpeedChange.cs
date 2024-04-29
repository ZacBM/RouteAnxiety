using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChange: InteractionEvent
{
    private const float defaultAnxietyAmount = 2f;
    private int[] speedList = new int[3];
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
        this.speedList[0] = road.getSpeed() - 30;
        this.speedList[1] = road.getSpeed();
        this.speedList[2] = road.getSpeed() + 30;
    }

    public override void run()
    {
        base.run();
        // do stuff here
        scrollIndex();
        road.setSpeed(this.speedList[currentIndex]);
    }
}