using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    //-6.25 - 8.45 intervals
    private float yAxis;


    void Start()
    {
        yAxis = Random.Range(0.0f, 0.5f);
    }

    void Update()
    {
        if(transform.position.x <= -6.25f)
        {
            transform.position = new Vector3(8.45f, yAxis,transform.position.z);
        }
    }

    public void MoveClouds()
    {
        transform.Translate(-0.2f * Time.deltaTime, 0, 0);
    }
}
