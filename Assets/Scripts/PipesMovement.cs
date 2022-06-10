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
        if (rbPipe != null) //si pipe existe
        {
            rbPipe.velocity = new Vector2(-vitessePipe, rbPipe.velocity.y); //pipe bouge vers la gauche

            if (rbPipe.position.x < -distanceHorsChampPipe) //si pipe en dehors de l'écran
            {
                destroyPipe();
            }
        }
       
    }

    void destroyPipe()
    {
        Destroy(gameObject); //détruire Pipe
        FindObjectOfType<PipesInstantiate>().InstantiatePipe();
    }

}
