using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{
    // barras
    public static int hambre, cansancio, aburrimiento, i = 0;
    const int sufrimiento = 10;
    float time, time2;

    // sprites
    public Sprite[] patoSprites      = new Sprite[5];
    public Sprite[] felicidadSprites = new Sprite[4];
    public Sprite[] vidaSprites      = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        // Sprite inicial
        this.gameObject.GetComponent<SpriteRenderer>().sprite = patoSprites[i++];

        // Posicion del pato
        transform.position = new Vector3(0f, -1.4f, 0f);

        // Inicializacion de los stats
        hambre       = 100;
        cansancio    = 100;
        aburrimiento = 100;

    }
    
    // Update is called once per frame
    void Update()
    {   
        // Contadores (ESTO ES MUY COSTOSO, HAY QUE CAMBIARLO)
        time  += Time.deltaTime;
        time2 += Time.deltaTime;

        // Cada 3 segundos
        if (time > 3) { 
            // Actualizacion de los stats
            if (hambre > 0)       hambre       -= sufrimiento;
            if (cansancio > 0)    cansancio    -= sufrimiento;
            if (aburrimiento > 0) aburrimiento -= sufrimiento;

            // debug
            print("Hambre: "       + hambre);
            print("Cansancio: "    + cansancio);
            print("Aburrimiento: " + aburrimiento);
            
            // Reset del contador de tiempo
            time = 0;
        }

        // Cada segundo
        if (time2 > 1) {
            // reset i para que no se pase el array
            if (i == 5)
                i = 0;
                
            // cambio de sprite para la animacion
            this.gameObject.GetComponent<SpriteRenderer>().sprite = patoSprites[i++];

            time2 = 0;
        }
    }
}
