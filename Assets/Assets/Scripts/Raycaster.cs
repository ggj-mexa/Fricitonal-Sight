using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public LayerMask mask;
    public Camera fpv;
    public GameObject ui;

    private string hitName;
    // Update is called once per frame
    void Update()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, 5))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.green);
            //hitName = hitInfo.collider.gameObject.GetComponent<objectManager>().itemName;
            //ui.GetComponent<UIText>().DisplayName(hitName);

            //if (Input.GetMouseButtonDown(0)) { hitInfo.transform.gameObject.GetComponent<objectManager>().Interaction(); }
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red);
            //hitName = "";
            //ui.GetComponent<UIText>().DisplayName(hitName);
        }
    }
}
