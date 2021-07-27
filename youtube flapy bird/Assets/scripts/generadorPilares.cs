using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorPilares : MonoBehaviour
{
    public float tiempoDeEspera;
    public GameObject[] pilares;

    public float velocidadPilares;
    void Start()
    {
        colocarVelocidad();
        generar();
    }
    public void colocarVelocidad()
    {
        for (int i = 0; i < pilares.Length; i++)
        {
            pilares[i].GetComponent<PilaresMover>().velocidad = velocidadPilares;
        }
    }
    public void generar()
    {
        int random = Random.Range(0,pilares.Length);
        Instantiate(pilares[random], transform.position, Quaternion.identity);
        Invoke("generar", tiempoDeEspera);
    }
}