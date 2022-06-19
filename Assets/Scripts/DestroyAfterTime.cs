using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{

    [SerializeField] int timeToDestroy;

    void Start()
    {
        Invoke("Destroy", timeToDestroy);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
