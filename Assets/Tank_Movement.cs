using UnityEngine;

public class Tank_Movement : MonoBehaviour
{
    public float TopSpeed = 8;

    void Update()
    {
        float v = Input.GetAxis("Vertical") * TopSpeed;
        float h = Input.GetAxis("Horizontal") * TopSpeed;

        gameObject.transform.position += transform.forward * (v * (2 * Time.deltaTime));
        
        gameObject.transform.localEulerAngles =
            new Vector3(0f, transform.localEulerAngles.y + ((h * TopSpeed) * Time.deltaTime), 0f);

        transform.Rotate(Vector3.forward, (TopSpeed * h) * Time.deltaTime);
    }
}