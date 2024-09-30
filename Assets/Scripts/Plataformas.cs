using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] int boost=1;
    [SerializeField] float contador = 5f, tiempo = 0f;
    int sentido = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo >= contador)
        {
            direccion *= sentido;
            tiempo = 0f;
        }
        transform.Translate(direccion.normalized * boost * Time.deltaTime);
        tiempo += 1 * Time.deltaTime;
        

    }
}
