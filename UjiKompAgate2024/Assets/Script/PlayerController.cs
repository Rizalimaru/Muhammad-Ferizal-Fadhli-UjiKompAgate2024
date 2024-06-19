using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private CharacterController characterController;
    private Animator animator;
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator =  GetComponent<Animator>();
    }

    void Update()
    {   
        Vector3 move = new Vector3(0,0,Input.GetAxis("Horizontal"));
        characterController.Move(move * Time.deltaTime * playerSpeed);

        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("LeftSrafe",true);
        }else if(Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("LeftSrafe",false);
        }
        
        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("RightSrafe",true);
        }else if(Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("RightSrafe",false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Fire");
        }
    }
}
