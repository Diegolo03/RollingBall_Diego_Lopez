using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiBola : MonoBehaviour
{
    Vector3 movimiento;
    [SerializeField] float fuerzaSalto =0f, fuerza=0f,maxDistancia=0.7f;
    Rigidbody rb;
    private float h, v;
    int monedas = 0, vidas = 100;
    [SerializeField] Canvas c;
   [SerializeField]TMP_Text textoMonedas, textoVida;
   [SerializeField]GameObject camara1, camara2;
    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] AudioClip monedita;
    [SerializeField] AudioManager manager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //textoVida.SetText("Vidas: " + vidas);
        //textoMonedas.SetText("Monedas: " + monedas);
    }

    // Update is called once per frame
    void Update()
    {
         h = Input.GetAxisRaw("Horizontal");
         v = Input.GetAxisRaw("Vertical");
        movimiento = new Vector3(h, 0f, v).normalized;
        movimiento = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * movimiento;
        Saltar();
        
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
            if (DetectarSuelo() == true)
            {
                rb.AddForce(0, fuerzaSalto, 0, ForceMode.Impulse);
            }


        }
    }
    bool DetectarSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), maxDistancia, queEsSuelo);
        return resultado ;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("moneda"))
        {
            manager.ReproducirSonido(monedita);
            Destroy(other.gameObject);
            monedas++;
            textoMonedas.SetText("Monedas: "+ monedas);
           

        }
        
        if (other.gameObject.CompareTag("enemigo"))
        {
            vidas -= 10;
            textoVida.SetText("Vidas: " + vidas);
            if (vidas <= 0)
            {
                Destroy(gameObject);
                
                
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("suelo"))
        {
            camara1.SetActive(true);
            camara2.SetActive(false);
        }
 
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            camara1.SetActive(false);
            camara2.SetActive(true);
        }

    }

}
