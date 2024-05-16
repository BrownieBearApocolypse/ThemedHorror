using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MOnster : MonoBehaviour
{
    public Transform Player;

    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;

    public void Start()
    {

    }

    public void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Like anything?
            }

        }
    }
}




