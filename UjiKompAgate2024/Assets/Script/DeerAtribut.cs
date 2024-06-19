using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerAtribut : MonoBehaviour
{
    private float CowHP = 200f; // Inisialisasi nilai awal CowHP
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CowHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {   
            Debug.Log("Bersentuhan dengan pizza");
            CowHP -= 25;

            // Optional: Hancurkan objek pizza jika ingin
            Destroy(other.gameObject);
        }
    }
}
