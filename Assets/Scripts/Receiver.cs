using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; 

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
        

    }


    void Arrange()
    {
        if (Input.GetMouseButtonDown(1))
        {
   
            stay = false;

        }

    }

    public void RecieveOrders(string tag)
    {
    
        switch (tag)
        {
            case "KeySound":
                {

                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    Debug.Log("Fuck this shit im out");
                    Video1.SetActive(false);

                    VideoA.GetComponent<VideoPlayer>().Play();
    

                }
                break;

            case "KeySound2":
                {
                    Debug.Log("Fuck this shit"); 
                    //Si es este quiero que tome el tag, y se lo mande a receiver, para poder diferenciar 
                    //entre los distintos objetos
                    VideoA.SetActive(false);
                    Video1.GetComponent<VideoPlayer>().Play();

                }

                break;

            case "KeySound3":
                {
                    VideoB.SetActive(false);
                    Video2.GetComponent<VideoPlayer>().Play();

                }
                break;

            case "KeySound4":
                {
                    Video2.SetActive(false);
                    VideoB.GetComponent<VideoPlayer>().Play();
                }
                break;

            case "KeySound5":
                {
                    VideoC.SetActive(false);
                    Video3.GetComponent<VideoPlayer>().Play();
                }
                break;

            case "KeySound6":
                {
                    Video3.SetActive(false);
                    VideoC.GetComponent<VideoPlayer>().Play();
                }
                break;

            case "KeySound7":
                {
                    VideoD.SetActive(false);
                    Video4.GetComponent<VideoPlayer>().Play();

                }
                break;

            case "KeySound8":
                {
                    Video4.SetActive(false);
                    VideoD.GetComponent<VideoPlayer>().Play();
                }
                break;


        }

    }
}
