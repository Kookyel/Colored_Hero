﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;
    [SerializeField]
    public float speedUp;
    public float speedDown;
    private float speed;
    [SerializeField]
    private Transform childTransform;
    [SerializeField]
    private Transform transformB;


    void Start()
    {
        posB = transformB.localPosition;
        posA = childTransform.localPosition;
        nextPos = posB;

    }
 


        void Update()
    {
        ChangeSpeed();
        Move();
    }

    private void Move()
    {

        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);
        if (Vector3.Distance(childTransform.localPosition, nextPos) <= 0.1)
        {
           
            ChangeDestination();
        }


    }

    private void ChangeDestination()
    {
        nextPos = nextPos != posA ? posA : posB;
    }

    private void ChangeSpeed()
    {
        if (nextPos == posB)
        {
            speed = speedDown;
        }
        else if (nextPos == posA)
        {
            speed = speedUp;
        }
    }


}
