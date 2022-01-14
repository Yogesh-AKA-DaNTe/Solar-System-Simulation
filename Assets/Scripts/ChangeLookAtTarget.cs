using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour
{
    public GameObject target; // The target that the camera should look at

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
        }
    }

    // Called when MouseDown event occurs on this gameObject
    void OnMouseDown()
    {
        // Change the target of the LookAtTarget script to be this gameobject
        LookAtTarget.target = target;
        // Change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(30 * target.transform.localScale.x, 1, 100);
    }
}
