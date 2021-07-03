using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScore : MonoBehaviour
{
    public static int SCORE = 0;
    void Start()
    {
        SCORE = 0;
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = SCORE.ToString();
    }

}
