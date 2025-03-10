﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadPlatforme : MonoBehaviour
{
    public float fallDelay = 1f;
    private Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        rb2d.isKinematic = false;
    }
}
