using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{

    [SerializeField] int vitessePipe;
    [SerializeField] int distanceHorsChampPipe;
    Rigidbody2D rbPipe;
    
    void Start()
    {
        rbPipe = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (rbPipe != null)
        {
            rbPipe.velocity = new Vector2(-vitessePipe, rbPipe.velocity.y);

            if (rbPipe.position.x < -distanceHorsChampPipe)
            {
                destroyPipe();
            }
        }
       
    }

    void destroyPipe()
    {
        Destroy(gameObject);
    }
}
