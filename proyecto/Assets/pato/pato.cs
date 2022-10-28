using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{
    int hambre;
    int cansancio;
    int aburrimiento;
    const int sufrimiento = 1;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        // Inicialización de los stats
        hambre = 100;
        cansancio = 100;
        aburrimiento = 100;
    }

    // Update is called once per frame
    void Update()
    {   
        // Contador
        time += Time.deltaTime;

        // Cada 3 segundos
        if (time > 3) { 
            // Actualización de los stats
            if (hambre > 0) hambre -= sufrimiento;
            if (cansancio > 0) cansancio -= sufrimiento;
            if (aburrimiento > 0) aburrimiento -= sufrimiento;

            // debug
            print(hambre);
            print(cansancio);
            print(aburrimiento);
            
            // Reset del contador de tiempo
            time = 0;
        }
       }
}
