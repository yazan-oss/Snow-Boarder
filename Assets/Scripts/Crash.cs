using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delayAmount = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground"&& !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("LoadScene", delayAmount);
        }
    }
     void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
