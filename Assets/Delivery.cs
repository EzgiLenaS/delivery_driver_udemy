using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch :)");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package")
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
        }

        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
        }       
    }
}
