using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondo : MonoBehaviour
{
    // Sprites
    public Sprite[] fondos = new Sprite[3];

    // Start is called before the first frame update
    void Start()
    {
        // color inicial
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = fondos[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (!pato.dormir) {
            // shade
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

            // sprite
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fondos[0];
        }

        if (pato.dormir) {
            // shade
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.65f, 0.65f, 0.65f, 1f);

            // sprite
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fondos[1];
        }
    }
}
