using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Itens/Dados")]
public class ItemDataSO : ScriptableObject
{
    //aqui é onde criamos os dados do item e modificamos no inspector do unity
    public int pontos;//quantos pontos o item vai valer
    public Color cor; //cor que ele vai receber
}
