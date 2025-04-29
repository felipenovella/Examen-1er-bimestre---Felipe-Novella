using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string ejercicioElegido;
    public int horasEjercicio;
    int precioSinDescuento;
    float precioConDescuento;

    void Start()
    {
        if (ejercicioElegido != "Fuerza" && ejercicioElegido != "Cardio" && ejercicioElegido != "Recreativo")
        {
            Debug.Log("Error: debe insertar un ejercicio valido. (Fuerza, Cardio, Recreativo.)");
            return;
        }
        if (horasEjercicio < 1 || horasEjercicio > 6)
        {
            Debug.Log("Error: cantidad de horas invalida. (Maximo 6 minimo 1)");
            return;
        }
        else if (ejercicioElegido == "Fuerza")
        {
            precioSinDescuento = horasEjercicio * 1500;

        } else if (ejercicioElegido == "Cardio")
        {
            precioSinDescuento = horasEjercicio * 1000;
        } else if (ejercicioElegido == "Recreativo")
        {
            precioSinDescuento = horasEjercicio * 2500;
        }
        Debug.Log("El ejercicio elegido es " + ejercicioElegido);
        Debug.Log("La cantidad de horas elegidas es de " + horasEjercicio);
        Debug.Log("El precio sin descuento es de " + precioSinDescuento);
       
        if (horasEjercicio == 6)
        {
            precioConDescuento = precioSinDescuento * 0.9f;
            Debug.Log("El precio con descuento es de " + precioConDescuento);

        }
       
    }

    
    void Update()
    {
        
    }
}
