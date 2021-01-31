using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accept : MonoBehaviour
{
    public GameObject cam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.gameObject.GetComponentInParent<MemoryController>().console.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
            cam.GetComponent<PlayerController>().enabled = true;
            //GetComponentInParent<PlayerController>().enabled = true;
        }
    }
}
