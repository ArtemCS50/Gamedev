using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persone : MonoBehaviour
{

    //Ox
    public int xVelocity = 5;
    // Oy
    public int yVelocity = 8;

    //
    private Rigidbody2D rigidBody;
    //========================================
    private void Start()
    {
        //
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {
        //
        float moveInput = Input.GetAxis("Horizontal");
        //
        float jumpInput = Input.GetAxis("Jump");
        if (moveInput < 0)
        { //
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
        }
        else if (moveInput > 0)
        { //
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
        }
        if (jumpInput > 0)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
        }
    }


//=======
// Start is called before the first frame update
/*
private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
*/

}
