using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiBola : MonoBehaviour
{
    Vector3 movimiento;
    [SerializeField] float fuerzaSalto =0f, fuerza;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        movimiento = new Vector3(h, 0f, v);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, fuerzaSalto, 0, ForceMode.Impulse);
        }
        rb.AddForce(movimiento*fuerza, ForceMode.Force);


        //transform.Translate(movimiento * Time.deltaTime);
    }
}
