using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSalto : MonoBehaviour
{
    public float fuerzaSalto;
    private Rigidbody2D myRigidBody;

    private void Awake()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Saltar();
        }
    }

    public void Saltar()
    {
        myRigidBody.AddForce(new Vector2(0f,fuerzaSalto));
    }
}
