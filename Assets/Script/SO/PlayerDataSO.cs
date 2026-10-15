using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dados do Player", menuName = "Player/Dados")]

public class PlayerDataSO : ScriptableObject
{
    //onde os dados do player serão armazenados e modificados pelos botões
    public int pontos; //onde os pontos serão salvos
    public Vector3 posicao; //onde a posição do player será salva

}
