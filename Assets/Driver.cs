using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // from -1 to 1 for each frame
        // Time.deltaTime makes the frame rate independent
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
