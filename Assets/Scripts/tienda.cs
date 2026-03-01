using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienda
{

    private List<Equipamiento> cosa;
    
    public tienda (List<Equipamiento> cosas)
    {
        this.cosa = cosas;
    }

    public string Comprar(int indice, billetera dinero)
    {
        Equipamiento producto = cosa[indice];

        //dinero.RestarDinero(producto.GetPrecio());

        producto.SeAcabo();

        if (!producto.Disponible())
        {
            return producto.GetNombre() + " agotado";
        }

        if (!dinero.RestarDinero(producto.GetPrecio()))
        {
            return "No alcanza";
        }

        return "Quedan $" + dinero.DarBalance();
    }

}
