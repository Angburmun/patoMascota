using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{
    // atributos
    public static int hambre, cansancio, aburrimiento, i = 0;
    public static bool dormir;
    const int decHambre = 3;
    const int decCansancio = 2;
    const int decAburrimiento = 4;
    float time, time2;

    // sonido para el zzz
    public AudioSource source;
    public AudioClip clip;

    // sprites
    public Sprite[] patoSprites      = new Sprite[5];
    public Sprite[] dormirSprites    = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        // Sprite inicial
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = patoSprites[i++];

        // Posicion del pato
        transform.position = new Vector3(0f, -1.4f, 0f);

        // Inicializacion de los stats
        hambre       = 100;
        cansancio    = 100;
        aburrimiento = 100;
        dormir = false;
    }
    
    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.D)) {
            if (dormir) dormir = false;
            else        dormir = true;
        }

        // Contadores (ESTO ES MUY COSTOSO, HAY QUE CAMBIARLO)
        time  += Time.deltaTime;
        time2 += Time.deltaTime;

        // Cada 3 segundos
        if (time > 3) { 
            // Actualizacion de los stats
            if (hambre > 0)                 hambre       -= decHambre;
            if (cansancio < 100 &&  dormir) cansancio    += decCansancio * 2;
            if (cansancio > 0   && !dormir) cansancio    -= decCansancio;
            if (aburrimiento > 0)           aburrimiento -= decAburrimiento;

            // debug
            print("Hambre: "       + hambre);
            print("Cansancio: "    + cansancio);
            print("Aburrimiento: " + aburrimiento);
            
            // Reset del contador de tiempo
            time = 0;
        }

        // Cada segundo
        if (time2 > 1) {
            if (!dormir) {
                // posicion
                transform.position = new Vector3(0f, -1.4f, 0f);

                // reset i para que no se pase el array
                if (i > 4)
                    i = 0;

                // cambio de sprite para la animacion
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = patoSprites[i++];
            }

            if (dormir) {
                // posicion
                transform.position = new Vector3(-0.75f, -2.75f, 0f);

                // reset i para que no se pase el array
                if (i > 3)
                    i = 0;

                // ronquidos
                if (i == 0) source.PlayOneShot(clip, 0.5f);

                // cambio de sprite para la animacion
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.8f, 0.8f, 0.8f, 1f);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = dormirSprites[i++];
            }

            time2 = 0;
        }
    }
}
