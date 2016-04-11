using UnityEngine;

public class Tank_Movement : MonoBehaviour
{
    public float TopSpeed = 4;

    void Update()
    {
        float v = Input.GetAxis("Vertical") * TopSpeed;
        float h = Input.GetAxis("Horizontal") * TopSpeed;

        gameObject.transform.position += transform.forward * (v * (.9f * Time.deltaTime));
        
        gameObject.transform.localPosition = new Vector3(transform.localPosition.x,0f,transform.localPosition.z);
    }
}
