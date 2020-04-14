using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadNaGranicu : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Die();
        }
    }
    void Die()
    {
        LevelManager man = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        man.LoadLevel("Win");
        Destroy(gameObject);
    }
}

