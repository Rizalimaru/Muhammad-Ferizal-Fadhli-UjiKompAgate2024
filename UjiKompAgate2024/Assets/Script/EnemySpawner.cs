using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    public GameObject sapi;
    public GameObject anjing;
    public GameObject kuda;
    public GameObject rusa;
    private float nilaimundur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float waktuSpawn = Time.deltaTime;
        if(transform.position.z >=25)
        {
            nilaimundur = -5f;
        }else if(transform.position.z <= -25)
        {
            nilaimundur = 5f;
        }
        transform.position += new Vector3(0,0,nilaimundur) *Time.deltaTime * 10f;

        // if(transform.position.z <= 10 )
        // {
        //     Instantiate(sapi, transform.position, Quaternion.Euler(0,90f,0));
        // }
        
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     if(other.CompareTag("BatasKiri"))
    //     {   
    //         Debug.Log("bersentuhan dengan bats kiri");
    //         transform.position += Vector3.back *Time.deltaTime * 10f;
    //     }

    //     if(other.CompareTag("BatasKanan"))
    //     {   
    //         Debug.Log("bersentuhan dengan bats kanan");
    //         transform.position += Vector3.forward *Time.deltaTime * 10f;
    //     }
    // }
}
