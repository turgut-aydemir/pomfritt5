using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;

    bool dead = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BlackHole"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }

    public void Die()
    {
        Invoke(nameof(ReloadLevel), 1.4f);
        dead = true;
        deathSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < -5f && !dead)
       {
           Die();
       } 
    }
}
