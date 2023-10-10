using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerAndScore : MonoBehaviour
{
    public GameObject TimerAndScoreText;
    public int numKetchup;
    public int numMayo;
    public int numPommes;
    public int totalScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        //collectSound.play();
        totalScore = numMayo + numKetchup + numPommes;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
