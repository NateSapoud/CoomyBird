using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] Transform tBird;
    [SerializeField] Rigidbody2D rbBird;
    [SerializeField] int jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        tBird = GetComponent<Transform>();
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


    void Jump()
    {

        rbBird.velocity = new Vector2 (rbBird.velocity.x, jumpHeight);

    }
}
