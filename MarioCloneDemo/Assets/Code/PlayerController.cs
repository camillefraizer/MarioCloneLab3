using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float runSpeed = 5.0f;
    [SerializeField] private float jumpForce = 5.0f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
     move();
     jump();  
    }

    private void jump() {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void move() {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * Vector2.right * runSpeed * Time.deltaTime);
    }
}
