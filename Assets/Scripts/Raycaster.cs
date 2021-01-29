using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public LayerMask mask;
    public Camera fpv;
    public GameObject ui;
    RaycastHit hitInfo;
    public bool selected; 
    public ScrVoiceOverLogic scrVoiceOverLogic;


    private string hitName;
    // Update is called once per frame
    void Update()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {


            if (Physics.Raycast(ray, out hitInfo, 15) && hitInfo.transform.tag == "KeySound")
            {

                scrVoiceOverLogic.ReproduceVoiceOver(hitInfo.transform.gameObject.GetComponent<VoiceOverTrigger>().voiceOverIndex);
                 
              
                Debug.DrawRay(ray.origin, ray.direction, Color.green);


                //hitName = hitInfo.collider.gameObject.GetComponent<objectManager>().itemName;
                //ui.GetComponent<UIText>().DisplayName(hitName);

                //if (Input.GetMouseButtonDown(0)) { hitInfo.transform.gameObject.GetComponent<objectManager>().Interaction(); }
            }
          
        }
        else if (Input.GetMouseButtonDown(1))
        {
            selected = true;
            if (selected == true)
            {
                    

            }

        }
    }
}
