using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novcic : MonoBehaviour
{
    private PrikazRezultata prikazRezultata;
    public int rezultatValue = 100;

    void Start()
    {
        prikazRezultata = GameObject.Find("Rezultat").GetComponent<PrikazRezultata>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Die();
        }  
    }
    void Die()
    {
        prikazRezultata.Rezultat(rezultatValue);
        Destroy(gameObject);
    }
}
