using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesInstantiate : MonoBehaviour
{

    [SerializeField] GameObject Pipe;
    [SerializeField] int RangeYPipe;
    [SerializeField] Transform RayCast;
    
    void Start()
    {
        InstantiatePipe();
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(RayCast.position, Vector2.left); //Raycast to the left of the transform

        if (hit.collider != null) //if it its something
        {
            float distance = Mathf.Abs(hit.distance); //distance of the hit object
            if (distance >= 5) //if the distance is more than 5 we instantiate another pipe
            {
                InstantiatePipe();
            }
        }
    }

    public void InstantiatePipe()
    {
        Instantiate(Pipe, new Vector2(12, Random.Range(-RangeYPipe, RangeYPipe)), Quaternion.identity); //Instantiate un pipe a droite de l'ecran
    }
}
