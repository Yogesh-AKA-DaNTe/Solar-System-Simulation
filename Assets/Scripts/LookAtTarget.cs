using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{
    static public GameObject target; // The target that the camera should look at

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("LookAtTarget target not specified. Defaulting to parent GameObject");
        }
    }

    void Update()
    {
        if (target)
        {
            // Looks at the position of target
            transform.LookAt(target.transform);
        }
    }
}
