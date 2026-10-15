using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "Novo Item", menuName = "Obj/Item")]
public class ItemSO : ScriptableObject
{
    public int pontos;
    public Color cor;
    public float tamanho;

}
