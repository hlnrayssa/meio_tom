using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int itens = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Moves();
    }

    void Moves()
    {
        float velX, velZ;
        velX = Input.GetAxis("Horizontal");
        velZ = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(velX, rb.linearVelocity.y, velZ) * 5F;
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*IColidivel colidivel = collision.gameObject.GetComponent<IColidivel>();
        if (colidivel != null)
        {
            itens += colidivel.Colidiu();
        }*/
    }
}


        
