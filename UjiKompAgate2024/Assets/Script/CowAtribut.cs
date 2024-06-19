using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CowAtribut : MonoBehaviour
{   
    private float CowHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(CowHP <= 0)
            {
                Destroy(this.gameObject);
            }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pizza"))
        {   
            Debug.Log("Bersentuhan dengan pizza");
            CowHP -= 25;
            
        }
    }


}
