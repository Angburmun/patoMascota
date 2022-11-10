using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraVida : MonoBehaviour
{
    float time;

    // Sprites
    public Sprite[] vidaSprites    = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        // Posicion de la barra
        transform.position = new Vector3(2f, 4f, 5f);

        // Sprite inicial
        this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        // Contadores (ESTO ES MUY COSTOSO, HAY QUE CAMBIARLO)
        time  += Time.deltaTime;

        // Cada 3 segundos. Hago esto para bajar el gasto computacional.
        if (time > 3) { 
            // Actualizacion de los sprites
            if (pato.cansancio > 60    && pato.cansancio <= 100)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaSprites[0];
                
            if (pato.cansancio > 20    && pato.cansancio <= 60)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaSprites[1];

            if (pato.cansancio > 5     && pato.cansancio <= 20)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaSprites[2];

            if (pato.cansancio <= 5)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaSprites[3];
            
            // Reset del contador de tiempo
            time = 0;
        }
    }
}
