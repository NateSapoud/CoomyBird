using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MilkShake;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rbBird;
    [SerializeField] int jumpHeight;
    [SerializeField] Camera Camera;
    [SerializeField] GameObject DeathSound;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Shaker myshaker;
    [SerializeField] ShakePreset ShakePreset;
    int points = 0;
    bool risingEdge = false;

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

        text.text = "Points: " + points.ToString();

    }

    private void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(rbBird.position, Vector2.up);
        float distance = Mathf.Abs(hit.distance);

        if (hit.collider != null && distance <= 3/*&& !risingEdge*/)
        {
            points++;
            risingEdge = true;
        }

       /* if (hit.collider == null)
        {
            risingEdge = false;
        }*/
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
        Instantiate(DeathSound, new Vector2(0, 0), Quaternion.identity);
        
    }
}
