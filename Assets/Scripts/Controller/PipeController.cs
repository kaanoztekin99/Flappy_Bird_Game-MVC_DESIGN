using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeController : MonoBehaviour
{
    
    public float maxTime = 2; //the time we have to wait for a new pipe
    private float timer = 0; //for counting time is passing
    public float height; //evaluating exact height to spawn pipe
    public GameObject pipe;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }


    // Update is called once per frame
    void Update()
    {
        
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

}