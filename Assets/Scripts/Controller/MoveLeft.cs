using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed; //to move objects left

    // Update is called once per frame
    void Update()
    {
        MoveLeftObject();
    }

    public void MoveLeftObject()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
