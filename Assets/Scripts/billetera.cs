using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billetera
{
    private float elBalance;
    private float ultimaTransferencia;

    public billetera(float balance)

    {
        if (balance > 0)
        {
            this.elBalance = balance;
            this.ultimaTransferencia = balance;
        }
        else
        {
            this.elBalance = 0;
        }
        Debug.Log("Balance de " + this.elBalance);
    }

    public float DarBalance()
    {
        return this.elBalance;
    }

    public void DarDinero(float dinero)
    {
        if (dinero >= 0)
        {
            this.elBalance += dinero;
        }
        else
        {
            Debug.Log("Inválido");
        }
    }

    public bool RestarDinero(float cants)
    {
        if (cants > 0 && cants <= this.elBalance)
        {
            this.elBalance -= cants;
            Debug.Log("Comprado, queda " + this.elBalance + " en la billetera");
            return true;
        }
        else
        {
            Debug.Log("Compra no hecha");
            return false;
        }
    }

}
