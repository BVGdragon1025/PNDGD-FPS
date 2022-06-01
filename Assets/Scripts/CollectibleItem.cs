using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    //Private Variables
    [SerializeField] private string itemName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collided: " + itemName);
        Destroy(this.gameObject);
    }

}
