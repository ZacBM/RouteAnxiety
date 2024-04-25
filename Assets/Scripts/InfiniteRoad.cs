using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoad
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private List<GameObject> roads;
    [SerializeField]
    private int objectLength;

    private float index;

    // Start is called before the first frame update
    void Start()
    {
        int objectCount = roads.Count;
        index = (float)(objectCount) / 2 - (objectCount);
        foreach (GameObject road in roads)
        {
            Vector3 newRoadPosition = road.transform.position;
            newRoadPosition.z = index * objectLength/2;
            road.transform.position = newRoadPosition;
            index += 1;
        }
        index = (float)(objectCount) / 2 - (objectCount);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject road in roads)
        {
            Vector3 newRoadPosition = road.transform.position;
            newRoadPosition.z -= speed * Time.deltaTime;
            if (newRoadPosition.z < (float)index * (objectLength*.5))
            {
                newRoadPosition.z += objectLength * roads.Count / 2;
            }
            road.transform.position = newRoadPosition;
        }
    }
}
