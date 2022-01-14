using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{
    public Transform target; // The object to rotate around
    public int speed; // The speed of rotation

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    void Update()
    {
        // Rotates around the target on y axis with a given speed
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
