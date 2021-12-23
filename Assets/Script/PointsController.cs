using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PointsController : MonoBehaviour
{
    [SerializeField] public float Points;
    private int TotalPoints;
    public static event Action onPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeOut();
        if (Points >= 3)
        {
            Point();
            TotalPoints++;
            Points = 0;
        }
        if (TotalPoints == 10)
        {
            onPoint();
        }
        
    }

    private void Point()
    {
        Gamemanager.instance.AddScore();
    }

    private void TimeOut()
    {
        Points += Time.deltaTime;
    }
}
