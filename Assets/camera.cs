using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform target;
    public float smoothing;

    public Vector2 minimumBoundary;
    public Vector2 maximumBoundary;

    // Update is called once per frame





    void LateUpdate()
    {
        if (transform.position != target.position)
        {

            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPos.x = Mathf.Clamp(targetPos.x, minimumBoundary.x, maximumBoundary.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minimumBoundary.y, maximumBoundary.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }

    }
}
