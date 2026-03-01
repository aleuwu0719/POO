using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipamiento
{

    private string objeto;
    private int cantidad;
    private float precio;

    public Equipamiento(string objetos, int cantidades, float precios)
    {
        this.objeto = objetos;
        this.cantidad = cantidades;
        this.precio = precios;
    }

    public string GetNombre()
    {
        return objeto;
    }

    public int GetCantidad()
    {
        cantidad = cantidad - 1;
        return cantidad;
    }

    public float GetPrecio()
    {
        return precio;
    }

    public bool Disponible()

    {
        return cantidad > 0;
    }

    public void SeAcabo()
    {
        if (Disponible())
        {
            Debug.Log(objeto + " vendido, quedan " + GetCantidad());
        }
        else
        {
            Debug.Log(objeto + " se agotó");
        }
    }

}
