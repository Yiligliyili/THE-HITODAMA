using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public Vector2 maxPose;
    public Vector2 minPose;

    private void FixedUpdate()
    {
        if (transform.position !=  target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y,transform.position.z);
            
            targetPos.x = Mathf.Clamp(targetPos.y, maxPose.y, minPose.y);
            targetPos.x = Mathf.Clamp(targetPos.x, maxPose.x, minPose.x);

            transform.position = Vector3.Lerp(targetPos, target.position, smoothing);



        }

    }
}
