using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem boardEffect;

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            boardEffect.Stop();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            boardEffect.Play();
        }
    }
}
