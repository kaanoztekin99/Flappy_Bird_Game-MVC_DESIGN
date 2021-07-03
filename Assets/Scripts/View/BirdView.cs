using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdView : MonoBehaviour
{
    public event System.Action makeItFly;
    public event System.Action imFalling;


    // everytime we pressed left mouse button we are going to call our jump function
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            makeItFly?.Invoke();
        }
        else
        {
            imFalling?.Invoke();
        }
    }
}
