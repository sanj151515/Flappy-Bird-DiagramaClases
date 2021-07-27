using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaresMover : MonoBehaviour
{
    public float velocidad;
    
    void Update()
    {
        mover();
    }
    public void mover()
    {
        transform.Translate(new Vector3(-velocidad,0f,0f)*Time.deltaTime);
    }
}
