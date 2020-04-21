 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    //recuperar una referencia a un rigidbody
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //código para obtener referencia
        //puede regresar null!
        rb = GetComponent<Rigidbody>();

        Rigidbody[] rbs = GetComponents<Rigidbody>();
        rb.AddForce(transform.up * 20,ForceMode.Impulse);
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
