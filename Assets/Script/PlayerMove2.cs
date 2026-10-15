using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove2 : MonoBehaviour
{
    
    public PlayerDataSO playerData;
    //onde vamos puxar os dados do scriptable object que contem os dados do player
    public ItemPool itemPool; //pega o script do pool de itens para poder devolver os itens que o player pegar
    public int totalPontos;//os pontos do player ao pegar os itens
    Rigidbody rb; //rigidbody do player para movimentação

    private float velX; //eixo x da movimentação, teclas A/D
    private float velZ; //eixo z da movimentação, teclas W/S


    void Start()
    {
        rb = GetComponent<Rigidbody>();//pega o rigidbody do player
        rb.freezeRotation = true; //freeze rotation para impedir que a capsula fiquei tombando
        transform.position = playerData.posicao; //pega a posição salva no SO
        totalPontos = playerData.pontos; //pega os pontos salvos no SO
    }

 
    void Update()
    {
        Mover(); //sempre chamar a função Mover no update

        //atalho na tecla espaço para salvar os dados do player no scriptable object
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SalvarTudo();
            Debug.Log("Dados salvos. Pontos: " + playerData.pontos + " Posição: " + playerData.posicao);
        }
    }

    void Mover()
    {
        velX = Input.GetAxis("Horizontal"); //teclas A/D
        velZ = Input.GetAxis("Vertical"); //teclas W/S
        rb.linearVelocity = new Vector3(velX, 0, velZ) * 5F; //rb velocity pq a movimentação é pelo rigidbody, não pelo transform e 0 no eixo y pra ele não pular

    }

    //função para checar se o collider do player colidiu com o collider de algum outro collider
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item")) //checa a colisão com os itens e verifica se tem a tag "Item" para poder continuar
        {
            totalPontos += collision.gameObject.GetComponent<Itens>().pontos; 
            //ao colidir com um item,pega os pontos dele e adiciona aos pontos do player
            itemPool.DevolverItem(collision.gameObject); 
            //devolve o item para o pool, desativando ele e adicionando ele na fila do pool
            
            Debug.Log("Total de pontos: " + totalPontos);
        }
    }

    public void SalvarTudo()
    {
        //salva os pontos e a posição no scriptable object
        playerData.pontos = totalPontos;
        playerData.posicao = transform.position;
    }
}

