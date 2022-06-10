using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rbBird;
    [SerializeField] int jumpHeight;

    // Start is called before the first frame update
    void Start()
    {

        rbBird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if (gameObject != null && collision.gameObject.tag == "Pipe")
             Destroy(gameObject);
        
    }

    void Jump()
    {

        rbBird.velocity = new Vector2 (rbBird.velocity.x, jumpHeight);

    }
}
