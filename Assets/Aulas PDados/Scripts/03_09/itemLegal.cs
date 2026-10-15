using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLegal : MonoBehaviour
{
    public ItemSO dadosItem;//recebe os dados do item que foi criado no scriptable object

  
    void Start()
    {
        transform.localScale *= dadosItem.tamanho;
        GetComponent<Renderer>().material.color = dadosItem.cor;

    }
}
