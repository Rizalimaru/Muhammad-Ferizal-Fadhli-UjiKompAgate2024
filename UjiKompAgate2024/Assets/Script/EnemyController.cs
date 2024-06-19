using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speedAtk = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        rb.position += Vector3.right * Time.deltaTime * speedAtk;
        //transform.position += Vector3.right * Time.deltaTime * speedAtk;
    }
}
