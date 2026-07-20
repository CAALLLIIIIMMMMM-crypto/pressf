using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpStr = 5f;

    private Rigidbody2D rb;
    private bool isGrounded = true;//ВКЛючена

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
        
    }

    void Move()
    {
        Vector2 move = new Vector2(0, 0);
        
        if (Keyboard.current.aKey.isPressed)
        {
            move += new Vector2(-1,0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            move += new Vector2(1, 0);
        }
        if (Keyboard.current.wKey.isPressed)
        {
            move += new Vector2(0, 1);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            move += new Vector2(0, -1);
        }
        rb.linearVelocity = move * speed;

        
       
    }



}