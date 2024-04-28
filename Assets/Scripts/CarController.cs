using Codice.CM.Common.Tree.Partial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private GameObject car;
    [SerializeField]
    private float lerpIncrement = 0.01f; // this doesn't work at thousandth places so be careful
    private Vector3 towardsBuffer;
    private float percentageBuffer;
    private bool lerping = false;

    public GameObject getCar()
    {
        return car;
    }

    public Transform getTransform()
    {
        return car.transform;
    }

    public bool lerpCarToPosition(Vector3 position)
    {
        if (!lerping)
        {
            lerping = true;
            towardsBuffer = position;
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        percentageBuffer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerping && percentageBuffer < 1)
        {
            car.transform.position = Vector3.Lerp(car.transform.position, towardsBuffer, percentageBuffer);
            percentageBuffer += lerpIncrement;
        } else if (lerping && percentageBuffer >= 1)
        {
            car.transform.position = towardsBuffer;
            lerping = false;
            percentageBuffer = 0f;
        }
    }
}
