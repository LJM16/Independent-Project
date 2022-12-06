using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody2DMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float  jumpForce = 10;

    public bool isOnGround;

    private Rigidbody2D _myRB;
    private Collider2D _myCollider;

    // Start is called before the first frame update
    void Start()
    {
       _myRB = GetComponent<Rigidbody2D>(); 
       _myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerMovement();

        PlayerJump();
        
    }

    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        _myRB.velocity = new Vector2(horizontalInput * moveSpeed, _myRB.velocity.y);
    }

    void PlayerJump()
    {
        if(_myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            isOnGround = true;
        }
        else{
            isOnGround = false;
        }

        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            _myRB.velocity = new Vector2(_myRB.velocity.x, jumpForce);
        }
    }
    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(_myRigidBody.velocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(_myRigidbody.velocity.x), 1f);
        }
    }
}
