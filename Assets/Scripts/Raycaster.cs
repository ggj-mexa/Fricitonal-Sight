using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public LayerMask mask;
    public Camera fpv;
    public GameObject ui;
    RaycastHit hitInfo;
    public string thisTag;
    public Receiver receiver;
    public bool disableOther;
    public GameObject KeySound1;
    public GameObject KeySound2;
    public GameObject KeySound3;
    public GameObject KeySound4;
    public GameObject KeySound5;
    public GameObject KeySound6;
    public GameObject KeySound7;
    public GameObject KeySound8;

    public bool flag = false;
    public VoiceOverCatalog index; 
    public ScrVoiceOverLogic scrVoiceOverLogic;


    private string hitName;
    // Update is called once per frame
    void Update()
    {
        
        LeftMouse();
        RightMouse(); 


    }


    void LeftMouse()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo, 15) && hitInfo.transform.tag == "Narrator")
            {

                scrVoiceOverLogic.ReproduceVoiceOver(hitInfo.transform.gameObject.GetComponent<VoiceOverTrigger>().voiceOverIndex);
                Debug.Log("Error");

                if (Input.GetMouseButtonDown(0))
                {
                    flag = true;
                }

                //hitName = hitInfo.collider.gameObject.GetComponent<objectManager>().itemName;
                //ui.GetComponent<UIText>().DisplayName(hitName);

                //if (Input.GetMouseButtonDown(0)) { hitInfo.transform.gameObject.GetComponent<objectManager>().Interaction(); }
            }
        }
    }

    void RightMouse()
    {
        thisTag = hitInfo.transform.tag;
        Debug.Log(thisTag); 
            switch(thisTag)
            {
            case "KeySound":
                {
            
                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    KeySound2.SetActive(false);
                    receiver.RecieveOrders(thisTag);



                }
            break;

            case "KeySound2":
                {
     
                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    KeySound1.SetActive(false);
                    receiver.RecieveOrders(thisTag);
   


                }

                break;
            }


            if (Input.GetMouseButtonDown(1) && hitInfo.collider.tag == "KeySound")
            {

                index = hitInfo.transform.gameObject.GetComponent<VoiceOverTrigger>().voiceOverIndex;
           

            }
            else
            {

            }

            if (GameObject.Find("GoOverLogic").GetComponent<ScrVoiceOverLogic>().omit == true)
            {
                flag = false;
            }
           

        
    }

}
