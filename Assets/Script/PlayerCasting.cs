// this script is used to get the distance from the player to the target object in front of them using raycasting. 
// The distance is stored in a static variable that can be accessed by other scripts.

using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    [SerializeField] float toTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            toTarget = Hit.distance;
            distanceFromTarget = toTarget;
        }

    }
}
