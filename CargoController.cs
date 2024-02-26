using UnityEngine;

public class CargoController : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cargo")// coin is the tag name
            Destroy(collision.gameObject);//means the object
        if (collision.gameObject.name == "Truck_Skin02")
            Destroy(this.gameObject);//this refer the player
    }
}