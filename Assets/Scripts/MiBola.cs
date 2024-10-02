using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiBola : MonoBehaviour
{
    Vector3 movimiento;
    [SerializeField] float velocidad =0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical") ;
        movimiento=new Vector3 (h, 0f, v )* velocidad;
        transform.Translate(movimiento * Time.deltaTime);
    }
}
