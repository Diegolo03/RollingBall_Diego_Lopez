using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murocubos : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    [SerializeField] private float bolita;
   
    private float timer = 0f;
    private bool Cuenta = false;

    
    void Update()
    {
       if (Cuenta)
       {
            timer += 1 * Time.unscaledDeltaTime;
            if (timer >= 2f )
            {
                Time.timeScale = 1f;
                for ( int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
            }
       }
    }
     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("Player"))
         {
             Time.timeScale = bolita;
             Cuenta=true;

         }
     }
}
