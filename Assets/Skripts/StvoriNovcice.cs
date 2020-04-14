﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StvoriNovcice : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject coin;

    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
        }
    }
}
