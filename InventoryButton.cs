using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject Inventory;

    public void OpenInventory()
    {
        if(Inventory != null)
        {
            bool isActive = Inventory.activeSelf;

            Inventory.SetActive(!isActive);
        }
    }
}
