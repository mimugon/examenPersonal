using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examenPersonal : MonoBehaviour
{
    public string tipoServicio;
    public int tiempoServicio;
    int precioHora;
    float precioTotal;
    float precioTotalDecuento;
    float descuento;
    // Start is called before the first frame update
    void Start()
    {
        if (tipoServicio != "cardio" && tipoServicio != "fuerza" && tipoServicio != "recreativo")
        {
            Debug.Log("Codigo no valido");
            return;
        }
        if (tiempoServicio > 6)
        {
            Debug.Log("No se puede reservar más de 6 horas semanales");
            return;
        }
        if (tiempoServicio < 0)
        {
            Debug.Log("La cantidad de horas ingresadas no es válida");
            return;
        }
        if (tipoServicio == "cardio")
        {
            precioHora = 1000;
        }
        if (tipoServicio == "fuerza")
        {
            precioHora = 1500;
        }
        if (tipoServicio == "recreativo")
        {
            precioHora = 2500;
        }
        if (tiempoServicio == 6)
        {
            precioTotal = precioHora * tiempoServicio;
            precioTotalDecuento = precioTotal -  precioTotal /10;
            Debug.Log("El tipo de entrenamiento es " + tipoServicio + ", las horas reservadas son " + tiempoServicio + ", el precio sin descuento es " + precioTotal + " y el precio con el descuento aplicado es " + precioTotalDecuento);
            return;
        }

        precioTotal = precioHora * tiempoServicio;
        Debug.Log("El tipo de entrenamiento es " + tipoServicio + ", las horas reservadas son " + tiempoServicio + " y el precio total sin descuento es " + precioTotal);
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
