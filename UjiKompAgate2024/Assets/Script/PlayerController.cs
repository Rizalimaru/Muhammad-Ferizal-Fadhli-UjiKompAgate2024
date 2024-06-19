using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private CharacterController characterController;
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(0,0,Input.GetAxis("Horizontal"));
        characterController.Move(move * Time.deltaTime * playerSpeed);

    }
}
