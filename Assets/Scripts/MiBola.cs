using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiBola : MonoBehaviour
{
    Vector3 movimiento;
    [SerializeField] float fuerzaSalto =0f, fuerza=0f;
    Rigidbody rb;
    private float h, v;
    int monedas = 0, vidas = 100;
   [SerializeField]TextMeshPro texto;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        texto=GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
         h = Input.GetAxisRaw("Horizontal");
         v = Input.GetAxisRaw("Vertical");
        movimiento = new Vector3(h, 0f, v).normalized;
        Saltar();
        texto.text = "Soccer: " + monedas;

        //transform.Translate(movimiento * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rb.AddForce(movimiento * fuerza, ForceMode.Force);

    }
    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, fuerzaSalto, 0, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("moneda"))
        {
            Destroy(other.gameObject);
            monedas++;
            Debug.Log(monedas);
        }
        if (other.gameObject.CompareTag("enemigo"))
        {
            vidas -= 10;
            Debug.Log(vidas);
            if (vidas <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
