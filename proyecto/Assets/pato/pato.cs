using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{
    public double hambre;
    public double cansancio;
    public double aburrimiento;
    public double sufrimiento;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        hambre = 100;
        cansancio = 100;
        aburrimiento = 100;
        sufrimiento = 1;
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime;

        if (x > 3) { 
        if (hambre > 0) {hambre -= sufrimiento;}
            
        print(hambre);

        if (cansancio > 0) { cansancio -= sufrimiento;}

        print(cansancio);

        if (aburrimiento > 0) { aburrimiento -= sufrimiento; }

        print(aburrimiento);
            x = 0;
        }
       }
}
