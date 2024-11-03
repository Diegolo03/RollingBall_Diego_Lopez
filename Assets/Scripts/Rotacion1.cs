using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion1 : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] int boostR = 1;
    Rigidbody rb;
  
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccion * boostR, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(direccion.normalized * boostR * Time.deltaTime);
       
        
    }
}
