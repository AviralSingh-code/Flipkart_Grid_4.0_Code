using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suit_Buyer_Trigger : MonoBehaviour
{
    public GameObject Item;    
    public void OnTriggerEnter(Collider other)
    {
        Item.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Item.SetActive(false);
    }
}
