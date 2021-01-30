using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public bool stay = false;
    // Update is called once per frame
    void Update()
    {

        Arrange();
     //   TurnOff();
       
    }


    void Arrange()
    {
        if (Input.GetMouseButtonDown(1) )
        {
            Debug.Log("Aqui estoy");
            stay = false; 
            
        }
       
    }

    public void RecieveOrders(string tag)
    {
        Debug.Log(tag + "Recibi tag"); 
        
      
    }

   // void TurnOff()
    //{
      //  if(this.gameObject.GetComponent<VoiceOverTrigger>().v)
   // }
}
