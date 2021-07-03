using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_Script
{
    public float _jumpForce; //jump force for our bird
    public float _turnForce; //turn rate of our bird

    public int _score; // general score

    public float _maxTime = 2; //the time we have to wait for a new pipe
    public float _timer = 0; //for counting time is passing
    public float _height; //evaluating exact height to spawn pipe

    public float _speed; //to move objects left

    public float _yAxis; //-6.25 - 8.45 internals to spawn our clouds

    public bool isJump; //to check our bird jumped or not
    public bool isGetPoint; //to check did player get the point
    public bool isCollide; //to check any collision with bird
    public bool isAlive; //to check game continues or bird fell down

}
