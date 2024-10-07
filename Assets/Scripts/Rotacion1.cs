using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion1 : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] int boostR = 1;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(direccion.normalized * boostR * Time.deltaTime);
       
        
    }
}
