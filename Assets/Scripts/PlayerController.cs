using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public CharacterController controller;
    private float speed = 5f;
    private Vector3 move;

    private void Awake()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = 0;

        move = transform.right * x + transform.up * y + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

    }
}
