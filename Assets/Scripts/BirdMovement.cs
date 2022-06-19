using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MilkShake;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rbBird;
    [SerializeField] int jumpHeight;
    [SerializeField] Camera Camera;
    public Shaker myshaker;
    public ShakePreset ShakePreset;

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
        if (gameObject != null && collision.gameObject.tag == "Pipe")
        {
            PlayerDeath();
        }
    }

    void Jump()
    {

        rbBird.velocity = new Vector2 (rbBird.velocity.x, jumpHeight);

    }

    private void OnBecameInvisible()
    {
        PlayerDeath();
    }

    void PlayerDeath()
    {
        Destroy(gameObject);
        myshaker.Shake(ShakePreset);
    }
}
