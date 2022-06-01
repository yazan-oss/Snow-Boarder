using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float baseSpeed = 30;

    Rigidbody2D rb2d;
    public bool canMove=true;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.centerOfMass = Vector2.zero;
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            ActivateBoost();
        }
    }

    //--------------------------

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    //---------------------------

    void ActivateBoost()
    {
        var speed = (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) ? boostSpeed : baseSpeed;
        surfaceEffector2D.speed = speed;
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //{
        //    surfaceEffector2D.speed = boostSpeed;
        //}
        //else
        //{
        //    surfaceEffector2D.speed = baseSpeed;
        //}
    }
    //------------------------------

   public void DisableControls()
    {
        canMove = false;
    }
}
