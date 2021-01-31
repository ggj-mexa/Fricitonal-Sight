using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NarratorComplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(myFunction());
    }

    IEnumerator myFunction()
    {

        
  


        yield return new WaitForSeconds(103);

        //The scene changes to the credits. 

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        yield return null;

    }
}
