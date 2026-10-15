using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itens : MonoBehaviour
{
    public ItemDataSO itemData; //puxa os dados do SO
    public int pontos; //onde vamos salvar os pontos do item, que serão puxados do scriptable object
    

    //passar as informações dos scriptable objects para os itens que aparecerão na cena
    public void ConfigurarItens(ItemDataSO dados)
    {
        //aqui vai pegar os dados dos scriptable objects que criamos e adicionar aos itens da cena
        itemData = dados;
        pontos = itemData.pontos;
        GetComponent<Renderer>().material.color = itemData.cor;//muda a cor do item  de acordo com o que for definido no scriptable object através do renderer
    }

}
