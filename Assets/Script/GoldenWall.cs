using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoldenWall : MonoBehaviour
{
    public static event Action onTouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            onTouch();
        }
    }
}
