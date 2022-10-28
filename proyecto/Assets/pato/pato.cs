using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{
    public double hambre;

    // Start is called before the first frame update
    void Start()
    {
        hambre = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (hambre > 0) {hambre -= 0.3;}
            
        print(hambre);
    }
}
