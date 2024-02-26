using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBox { get; private set; }

    public UnityEvent<PlayerInventory> OnBoxCollected;

    public void BoxCollected()
    {
        NumberOfBox++;
        OnBoxCollected.Invoke(this);
        
    }

    /*public void BoxEmptied()
    {
        NumberOfBox = 0;
    }*/
}