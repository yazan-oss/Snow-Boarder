using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayAmount = 1f;
    [SerializeField] ParticleSystem finishLine;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishLine.Play();
            GetComponent<AudioSource>().Play();
            Invoke("LoadScene", delayAmount);
            
        }
    }
    

    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
