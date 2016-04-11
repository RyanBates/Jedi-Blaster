using UnityEngine;
using System.Collections;

public class Camera_Control : MonoBehaviour
{ 
    public Transform target;
    public float distance = 2.3f;
    public float height = 4.54f;
    public float Damping = 1;
    public bool Rotating = true;
    public bool follow = true;
    public float rDamping = 10.0f;

    void Update()
    {
        Vector3 WantedPosition;

        if (follow)
        {
            WantedPosition = target.TransformPoint(0, height, -distance);
        }
        else
        {
            WantedPosition = target.TransformPoint(0, height, distance);
        }

        transform.position = Vector3.Lerp(transform.position, WantedPosition, Time.deltaTime * Damping);

        if (Rotating)
        {
            Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rDamping);
        }
        else transform.LookAt(target, target.up);
    }

}