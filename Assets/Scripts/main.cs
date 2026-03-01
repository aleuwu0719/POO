using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class main : MonoBehaviour
{
    private tienda tiendita;
    private billetera laBilletera;

    public float plata = 15000f;

    private void Start()
    {
        Equipamiento espada = new Equipamiento("Espada", 6, 1500f);
        Equipamiento escudo = new Equipamiento("Escudo", 4, 3000f);
        Equipamiento arco = new Equipamiento("Arco", 3, 1000f);

        List<Equipamiento> cosas = new List<Equipamiento> { espada, escudo, arco };

        tiendita = new tienda(cosas);

        laBilletera = new billetera(plata);

        Debug.Log("Presiona 1, 2 o 3 para comprar algo");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(tiendita.Comprar(0, laBilletera));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(tiendita.Comprar(1, laBilletera));
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(tiendita.Comprar(2, laBilletera));
        }
    }

}
