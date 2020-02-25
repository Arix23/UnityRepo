using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float speed = 50;
    // Start is called before the first frame update
    //Sucede despues de awake
    void Start()

    {
        print("START");
    }

    // Update is called once per frame
    //Usar para ;
        // - entrada de usuario
        // - desplazamiento
    void Update()
    {
        //entrada en general dos categorías
        // - polling: sondeo
        // - events / listeners
        //todo es polling
        // 2 maneras de acceder a la entrada del usuario
        // 1. directo a dispositivo
        //2. utilizando ejes

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // true si en frame anterior estaba libre y en el actual presionado
            Debug.Log("AAAAA");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("XD");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Presionado en el anterior y liberado en el actual
            Debug.Log("Minecra");
        }

        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition);
        }

        // 2 por medio de ejes. Abstracción de dispositivo de entrada
        //siempre regresan un valor flotante
        // rango: [-1,1]
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print(h);

        //Transform - clase que define al componente
        //transform - objeto prepoblado con una referencia al transform del mismo gameobject
        //velocidad basada en frames
        transform.Translate(speed*h*Time.deltaTime,0,speed * v * Time.deltaTime, Space.World);

    }

    //Sucede al inicio de la creación del componente
    //una sola vez
    void Awake()
    {
        Debug.Log("HOLA");
    }
    void LateUpdate()
    {
        
    }

    //fixed - fijo
    //update fijo : frecuencia "constante" hola uwu increible
    void FixedUpdate()
    {
        
    }

    //Para detectar colisión con motor de física
    // los involucrados tienen un collider
    // el que se mueve tiene un rigid body

    //deteccion de colisión a nivel código

    void OnCollisionEnter(Collision collision)
    {
        print("ENTRA");
        print(collision.transform.name);
        print("UN PUNTO; " + collision.contacts[0]);
    }

    void OnCollisionStay(Collision collision)
    {
        //print("QUEDA");
    }

    void OnCollisionExit(Collision collision)
    {
        print("SALE");
    }

    //triggers -
    //colliders con los que puedo chocar PERO no me afectan físicamente

    void OnTriggerEnter(Collider c)
    {
        print(c.transform.name);
    }
    void OnTriggerStay(Collider c)
    {

    }

    void OnTriggerExit(Collider c)
    {

    }

}
