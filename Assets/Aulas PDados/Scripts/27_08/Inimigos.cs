using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour, IColidivel
{
    public int dano;
    public Atributos atributos;
    // Start is called before the first frame update
   public int  Colidiu()
    {
        Debug.Log("Hahaahah");
        return -dano;
    }
}


