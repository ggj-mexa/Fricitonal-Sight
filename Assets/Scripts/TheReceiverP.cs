using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TheReceiverP : MonoBehaviour
{
    public GameObject Video7;
    public GameObject Video8;
    public GameObject Video9;
    public GameObject Video10;

    public GameObject secret;


    public void Update()
    {
        if (GameObject.Find("ControllerVoiceLogic").GetComponent<Receiver>().secret == true)
        {
            Debug.Log("SuperEntro"); 
            Video7.SetActive(true);
            Video8.SetActive(true);
            Video9.SetActive(true);
            Video10.SetActive(true);
            Debug.Log("nice");
        }

    }
}
