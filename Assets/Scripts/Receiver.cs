using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public bool stay = false;
    public GameObject Video1;
    public GameObject Video2;
    public GameObject Video3;
    public GameObject Video4;
    public GameObject VideoA;
    public GameObject VideoB;
    public GameObject VideoC;
    public GameObject VideoD;




    // Update is called once per frame
    void Update()
    {

        Arrange();
        //   TurnOff();

    }


    void Arrange()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Aqui estoy");
            stay = false;

        }

    }

    public void RecieveOrders(string tag)
    {
        Debug.Log(tag + "Recibi tag");
        switch (tag)
        {
            case "KeySound1":
                {

                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    Video2.SetActive(false);
                    Debug.Log("Entre al KeySound, elimino el 2");


                }
                break;

            case "KeySound2":
                {

                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    Video1.SetActive(false);
                    Debug.Log("Entre al KeySound 2, elimino 1");




                }

                break;

            case "KeySound3":
                {
                    Video4.SetActive(false);
                    Debug.Log("Entre al KeySound 3, elimino 4");


                }
                break;

            case "KeySound4":
                {
                    Video3.SetActive(false);
                    Debug.Log("Entre al KeySound 4, elimino 3");


                }
                break;

            case "KeySound5":
                {
                    VideoB.SetActive(false);
                    Debug.Log("Entre al KeySound 6, elimino 6");

                }
                break;

            case "KeySound6":
                {
                    VideoA.SetActive(false);
                    Debug.Log("Entre al KeySound 5, elimino 5");

                }
                break;

            case "KeySound7":
                {
                    VideoD.SetActive(false);
                    Debug.Log("Entre al KeySound 7, elimino 8");

                }
                break;

            case "KeySound8":
                {
                    VideoC.SetActive(false);
                    Debug.Log("Entre al KeySound 7, elimino 8");

                }
                break;


        }

        // void TurnOff()
        //{
        //  if(this.gameObject.GetComponent<VoiceOverTrigger>().v)
        // }
    }
}
