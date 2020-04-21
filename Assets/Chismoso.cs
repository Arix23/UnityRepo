using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chismoso : MonoBehaviour
{
    public Transform objetivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objetivo);
        transform.Translate(
            transform.forward * 2 * Time.deltaTime, Space.World);
    }
}
