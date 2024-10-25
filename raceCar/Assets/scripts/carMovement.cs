using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    private bool finish;
    public float maxSpeed;
    public float speed;
    public float acc;
    public float brk;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        acceleration();
        myRigidBody.velocity = new Vector2(speed, 0);
        if (finish == true)
        {
            breaking();
        }

    }

    public void acceleration()
    {
        if (speed < maxSpeed && finish == false)
        {
            speed += acc;
        }

    }

    public void breaking()
    {
        if (speed > 0)
        {
            speed -= brk;

        }
        else
        {
            speed = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
            finish = true;
    }

}