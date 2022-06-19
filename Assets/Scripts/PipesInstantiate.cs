using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesInstantiate : MonoBehaviour
{

    [SerializeField] GameObject Pipe;
    [SerializeField] int RangeYPipe;
    
    void Start()
    {
        for (int i = 0; i < 10; i = i+2)
        {
            Invoke("InstantiatePipe", i);
        } 
    }

    
    void Update()
    {
        
    }

    public void InstantiatePipe()
    {
        Instantiate(Pipe, new Vector2(12, Random.Range(-RangeYPipe, RangeYPipe)), Quaternion.identity); //Instantiate un pipe a droite de l'ecran
    }
}
