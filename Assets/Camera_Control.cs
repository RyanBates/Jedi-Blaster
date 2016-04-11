using UnityEngine;
using System.Collections;

public class Camera_Control : MonoBehaviour
{
    public Transform target;
    public int Distance = 5;
    public int height = 10;
    public bool follow = true;

    void Update()
    {
        Vector3 WantedPosition;

        if (follow == true)
            WantedPosition = new Vector3(0,height, -Distance);
        
        else
            WantedPosition = new Vector3(0, height, Distance);
       
    }
}