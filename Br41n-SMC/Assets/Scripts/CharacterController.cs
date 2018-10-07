using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

  
    private float moveInput;
    private bool isOnTheGround = true;
    private Rigidbody2D rb;
   // private int PlayerLevel = 3;
    private int airjump = 0;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (isOnTheGround)
        {
            airjump = 0;
        }


        if (Input.GetKey("right"))
        {
            transform.position += transform.right * 0.1f;
            Debug.Log("right");
        }
        else if (Input.GetKey("left"))
        {
            transform.position += transform.right * -0.1f;
            Debug.Log("left");
        }
        else if (Input.GetKey("up") && isOnTheGround)
        {
            {
                    isOnTheGround = !isOnTheGround;
                transform.position += transform.up * 0.5f;
                Debug.Log("up");
            }
        }
      
    }


    void FixedUpdate()
    {
        isOnTheGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        Debug.Log(isOnTheGround);
    }
    
    void Flip()
    {
    }
}
