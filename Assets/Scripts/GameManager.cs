using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float contador=5f, tiempo = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += 1 * Time.deltaTime;
        if (tiempo >= contador)
        {
            Debug.Log("Has lleagdo a 5 segundos");
            tiempo = 0f;
        }
    }
}
