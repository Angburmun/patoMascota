using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraHambre : MonoBehaviour
{
    float time;

    // Sprites
    public Sprite[] hambreSprites    = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        // Posicion de la barra
        transform.position = new Vector3(-2f, 4f, 5f);

        // Sprite inicial
        this.gameObject.GetComponent<SpriteRenderer>().sprite = hambreSprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        // Contadores (ESTO ES MUY COSTOSO, HAY QUE CAMBIARLO)
        time  += Time.deltaTime;

        // Cada 3 segundos. Hago esto para bajar el gasto computacional.
        if (time > 3) { 
            // Actualizacion de los sprites
            if (pato.hambre > 60    && pato.hambre <= 100)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hambreSprites[0];
                
            if (pato.hambre > 20    && pato.hambre <= 60)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hambreSprites[1];

            if (pato.hambre > 5     && pato.hambre <= 20)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hambreSprites[2];

            if (pato.hambre <= 5)    
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hambreSprites[3];
            
            // Reset del contador de tiempo
            time = 0;
        }
    }
}
