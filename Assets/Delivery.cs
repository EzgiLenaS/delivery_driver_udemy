using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 5f;

    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch :)");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // "!hasPackage" is for 1 package at a time
        if(collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
        }       
    }
}
