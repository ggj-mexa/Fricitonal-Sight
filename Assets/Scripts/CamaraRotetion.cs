using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraRotetion : MonoBehaviour
{
public float mouseSensitivity = 100f;
    public Transform playerbody;
    public float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        LockCursor();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);

    }

    public void ConfineCursor() { Cursor.lockState = CursorLockMode.Confined; }
    public void LockCursor() { Cursor.lockState = CursorLockMode.Locked; }
}
