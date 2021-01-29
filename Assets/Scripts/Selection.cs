using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{

    Camera cam;
    GameObject selectedObj;
    RaycastHit hit;
    public int i = 0;



    bool selected = false;


    RaycastHit Hit;

    public ScrVoiceOverLogic scrVoiceOverLogic;




    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        selected = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSelection()
    {

        if (Input.GetMouseButtonDown(0) && selected == false)
        {

            //If it is only an item then the player can grab it and then rotate it.
            //Then the object returns to it's original position because the value of it was save in another variable. 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(" Entro"); 
            if (Physics.Raycast(ray, out hit, 8) && hit.transform.tag == "KeySound")
            {


                selected = true;
            }
        }
    }
}
