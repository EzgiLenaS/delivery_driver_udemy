using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Thing to follow will be taken from serializefield. Here is the car.
    [SerializeField] GameObject car;
    // this things position (camera) should be the same as the car's position
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
