using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{

    [SerializeField] int vitessePipe;
    [SerializeField] int distanceHorsChampsPipe;
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

            if (rbPipe.position.x < -distanceHorsChampsPipe)
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
