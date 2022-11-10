using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraFelicidad : MonoBehaviour
{
    float time;

    // Sprites
    public Sprite[] felicidadSprites    = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        // Posicion de la barra
        transform.position = new Vector3(0f, 4f, 5f);

        // Sprite inicial
        this.gameObject.GetComponent<SpriteRenderer>().sprite = felicidadSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        // Contadores (ESTO ES MUY COSTOSO, HAY QUE CAMBIARLO)
        time  += Time.deltaTime;

        // Cada 3 segundos. Hago esto para bajar el gasto computacional.
        if (time > 3) { 
            // Actualizacion de los sprites
            if (pato.aburrimiento > 60    && pato.aburrimiento <= 100)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = felicidadSprites[0];
                
            if (pato.aburrimiento > 20    && pato.aburrimiento <= 60)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = felicidadSprites[1];

            if (pato.aburrimiento > 5     && pato.aburrimiento <= 20)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = felicidadSprites[2];

            if (pato.aburrimiento <= 5)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = felicidadSprites[3];
            
            // Reset del contador de tiempo
            time = 0;
        }
    }
}
