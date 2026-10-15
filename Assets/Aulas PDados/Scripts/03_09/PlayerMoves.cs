using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public int itens = 0;
    Rigidbody rb;

    public PlayerSO[] playerData;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

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
