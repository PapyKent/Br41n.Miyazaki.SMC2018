using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private int extraJumps;
    public int extraJumpsValue;

    private Rigidbody2D rb;

    private bool isFacingRight = true;

    private bool isOnTheGround = true;
    private bool isAgainstWall = false;

    public Transform groundCheck;
    public Transform leftCheck;
    public Transform rightCheck;
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
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            Debug.Log("air jump");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isOnTheGround == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            Debug.Log("jump");
        }

    }
    void FixedUpdate()
    {

        isOnTheGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if((Physics2D.OverlapCircle(leftCheck.position, checkRadius, whatIsGround) || Physics2D.OverlapCircle(rightCheck.position, checkRadius, whatIsGround)) && !isOnTheGround)
        {
            isAgainstWall = true;
        }
        else
            isAgainstWall = false;

        moveInput = Input.GetAxis("Horizontal");
        if(!isAgainstWall)
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (isFacingRight == false && moveInput > 0)
            Flip();
        else if (isFacingRight == true && moveInput < 0)
            Flip();
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
