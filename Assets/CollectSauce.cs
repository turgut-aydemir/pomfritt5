using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SauceCollector : MonoBehaviour
{
    /*
    int ketchup = 0;
    int mayo = 0;
    int pommes = 0:
    */
    int points = 0;

    [SerializeField] TextMeshProUGUI sauceText;

    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sauce"))
        {
            Destroy(other.gameObject);
            points++;
            sauceText.text = "Points: " + points;
            collectionSound.Play();
        }
    }
}