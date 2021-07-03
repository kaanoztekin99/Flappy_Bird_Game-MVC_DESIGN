using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    public GameController gameController;
    public Model_Script model;
    public BirdView view;

    /*public BirdController(BirdView view)
    {
        model = new Model_Script();

        this.view = view;
    }*/


    // we are going to add force our bird to fly and turn a little bit
    public float jumpSpeed;
    public float turnRate;

    public Text scoreTxt;
    public int SCORE = 0;
    public Text highScoreTxt;

    // we are going to take our bird's rigidbody and add force them to make it fly higher.    
    private Rigidbody2D rb;

    //we called awake function because we wanted to check bird's rigidbody immediately.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        highScoreTxt.text = "High Score: " + PlayerPrefs.GetInt("highscore", 0).ToString();

    }

    // everytime we pressed left mouse button we are going to call our jump function
    void Update(){
       if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
       {
           makeItFly();
       }
       else
       {
           imFalling();
       }
    }

    //our jump function apply forces (like repeatable) and provides our bird to jump just 1 time every mouse left button pressed.
    public void makeItFly()
    {
        rb.velocity = Vector2.up * jumpSpeed;

        //this code block makes bird fly more reality with euler angles
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 20.0f);
    }

    //we want that if player doesn't touch the screen, our bird is gonna fall down  with decreasing euler with turn rate
    public void imFalling()
    {
        transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, turnRate);
    }

    // this code block is going to work if our bird is fell down
    public void DontMove()
    {
        rb.velocity = Vector2.zero;
    }

    //we should take these code blocks (OnTriggerEnter and OnCollisionEnter functions) to the BirdView.cs 
    //Our View scripts should check the user - game interaction

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            SCORE++;
            scoreTxt.text = "Score: " + SCORE.ToString();

            if (SCORE > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", SCORE);
                highScoreTxt.text = "High Score: " + SCORE.ToString();
            }
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            gameController.GameOver();
        }
    }
}