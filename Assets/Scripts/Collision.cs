using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject SwordPickup;
    public GameObject SwordText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == SwordPickup)
        {
            Destroy(SwordPickup);
            SwordText.SetActive(true);
        }
    }
}