using UnityEngine;

public class Collusion : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch :)");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What was that??");        
    }
}
