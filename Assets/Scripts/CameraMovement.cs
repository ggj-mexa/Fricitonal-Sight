using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cameraMovement;

    public float h, v;
    public float horizontalSpeed, verticalSpeed; 

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v  = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        cameraMovement.transform.Rotate(-v, 0, 0);
    }
}
