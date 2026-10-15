using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPool : MonoBehaviour
{
    public GameObject item; //pega o item que será instanciado
    public int tamanhoPool = 10; //quantidade de itens que serão instanciados no pool

    private Queue<GameObject> pool = new Queue<GameObject>(); 
    //cria uma fila vazia para armazenar os itens instanciados, para que eles possam ser reutilizados e reduzir a necessidade de instanciar novos itens toda hora


    //awake para ser chamado antes de qualquer start de outros scripts
    void Awake()
    {
        for (int i = 0; i < tamanhoPool; i++)
        {
            GameObject novoItem = Instantiate(item); //instancia o item
            novoItem.SetActive(false); //desativa o item
            pool.Enqueue(novoItem); //adiciona o item na fila
        }
    }

    public GameObject PegarItem(Vector3 posicao, Quaternion rotacao)
    {
        GameObject novoItem = pool.Count > 0 ? pool.Dequeue():Instantiate(item); 
        //se a contagem do pool for maior que zero, pega um item da fila e o reaproveita (Dequeue) ou instancia um novo se a fila estiver vazia
        novoItem.transform.SetPositionAndRotation(posicao, rotacao); 
        //reposiciona o item em um lugar novo
        novoItem.SetActive(true); //ativa o item para que ele fique visível
        return novoItem; //retorna o item
    }

    public void DevolverItem(GameObject itemUsado)
    {
        itemUsado.SetActive(false); //desativa o item para que ele não fique visível na cena
        pool.Enqueue(itemUsado); //adiciona o item no fim da fila
    }
}

