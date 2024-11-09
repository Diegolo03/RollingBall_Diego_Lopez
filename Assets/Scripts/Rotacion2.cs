using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion2 : MonoBehaviour
{
    [SerializeField] Vector3 direccion, movY;
    [SerializeField] int boostR = 1, boostT = 1;
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
        transform.Rotate(direccion.normalized * boostR * Time.deltaTime);
        transform.Translate(movY.normalized * boostT * Time.deltaTime, Space.World);
        tiempo += 1 * Time.deltaTime;
    }
}
