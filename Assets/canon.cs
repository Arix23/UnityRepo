using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject original;
    public Transform referencia;
    private IEnumerator enumerador,
                        disparo;
    private Coroutine corutina;
    // Start is called before the first frame update
    void Start()
    {
        //original = GameObject.Find("Bala");
        this.enumerador = pseudoHilo();
        this.corutina = StartCoroutine(enumerador);
        StartCoroutine("corutina2");
        this.disparo = Disparar();
    }

    // Update is called once per frame 
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * -5 * Time.deltaTime, 0, 0);

        float v = Input.GetAxis("Vertical");
        transform.Rotate(30 * v * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(this.disparo);
            //disparar
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(this.disparo);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            StopAllCoroutines();
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            StopCoroutine("corutina2");
        }
    }
    //corutinas
    //mecanismo para pseudoconcurrencia
    IEnumerator pseudoHilo()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            print("Hola Amiguitos");
        }

    }
    IEnumerator corutina2()
    {
        while (true)
        {
            print("Adios");
            yield return new WaitForSeconds(0.3f);
        }
    }
    IEnumerator Disparar()
    {
        while (true)
        {
            Instantiate(original,
                        referencia.position,
                        referencia.rotation);

            yield return new WaitForSeconds(0.2f);
        }
    }
}
