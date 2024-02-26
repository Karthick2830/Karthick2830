using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
/*
        playerInventory.BoxEmptied();*/
    }
}