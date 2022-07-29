using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recharge_Collider : MonoBehaviour
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
