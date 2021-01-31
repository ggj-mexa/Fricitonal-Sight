﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Camera fpv;
    RaycastHit hitInfo;
    public string thisTag;
    public Receiver receiver;

    public bool disableOther;
    public GameObject KeySound;
    public GameObject KeySound2;
    public GameObject KeySound3;
    public GameObject KeySound4;
    public GameObject KeySound5;
    public GameObject KeySound6;
    public GameObject KeySound7;
    public GameObject KeySound8;
    
    public GameObject moveToHere; //Agregado por Ruisu

    private GameObject consolePlace;

    public bool flag = false;
    public bool secret = false; 
    public VoiceOverCatalog index; 
    public ScrVoiceOverLogic scrVoiceOverLogic;


    private string hitName;
    // Update is called once per frame
    void Update()
    {
        consolePlace = RayFeedback();

        LeftMouse();
        RightMouse();
    }

    private GameObject RayFeedback()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo, 15)) { return hitInfo.transform.gameObject; }
        else { return null; }
    }

    void LeftMouse()
    {
        Ray ray = fpv.ScreenPointToRay(Input.mousePosition);

        if (consolePlace.tag == "Narrator")
        {

            if (Input.GetMouseButtonDown(0))
            {
                scrVoiceOverLogic.ReproduceVoiceOver(hitInfo.transform.gameObject.GetComponent<VoiceOverTrigger>().voiceOverIndex);

                if (Input.GetMouseButtonDown(0))
                {
                    flag = true;
                }
            }
        }
        if (Physics.Raycast(ray, out hitInfo, 15) && hitInfo.transform.tag == "Memory")
        {
                //moveToHere = hitInfo.transform.gameObject.GetComponent<MemoryController>().consolePlace;
                
                // var x = hitInfo.transform.gameObject.GetComponentInParent<Transform>().localPosition.x;
                //var y = GetComponentInParent<Transform>().position.y;
                //var z = hitInfo.transform.gameObject.GetComponentInParent<Transform>().localPosition.z;
                var x = moveToHere.transform.position.x; //Agregado por Ruisu
                var y = moveToHere.transform.position.y; //Agregado por Ruisu
                var z = moveToHere.transform.position.z; //Agregado por Ruisu

                Vector3 moveTo = new Vector3(x, y, z);


            if (Input.GetMouseButtonDown(0))
            {
                //GetComponentInParent<Transform>().position = moveTo;
                transform.position = moveTo; //Agregado por Ruisu

                hitInfo.transform.gameObject.GetComponentInParent<MemoryController>().console.enabled = true;
                Cursor.lockState = CursorLockMode.Confined;
                GetComponentInParent<PlayerController>().enabled = false;
            }
        }
    }

    void RightMouse()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hitSelect;
            Ray ray = fpv.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitSelect, 15))
            {
                thisTag = hitSelect.transform.tag;
                switch (thisTag)
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
                            KeySound.SetActive(false);
                            receiver.RecieveOrders(thisTag);



                        }

                        break;

                    case "KeySound3":
                        {
                            KeySound4.SetActive(false);
                            receiver.RecieveOrders(thisTag);

                        }
                        break;

                    case "KeySound4":
                        {
                            KeySound3.SetActive(false);
                            receiver.RecieveOrders(thisTag);

                        }
                        break;

                    case "KeySound5":
                        {
                            KeySound6.SetActive(false);
                            receiver.RecieveOrders(thisTag);
                        }
                        break;

                    case "KeySound6":
                        {
                            KeySound5.SetActive(false);
                            receiver.RecieveOrders(thisTag);
                        }
                        break;

                    case "KeySound7":
                        {
                            KeySound8.SetActive(false);
                            receiver.RecieveOrders(thisTag);
                        }
                        break;

                    case "KeySound8":
                        {
                            KeySound7.SetActive(false);
                            receiver.RecieveOrders(thisTag);
                        }
                        break;

                    case "Secret":
                        {
                            Debug.Log("Si entro");
                           receiver.RecieveOrders(thisTag);
                           
                        }
                        break; 
                }
            }
        }
    }

}
