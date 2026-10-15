using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI2 : MonoBehaviour
{
    public PlayerDataSO playerData;//onde vamos guardar e puxar os dados de pontos e posição do player do scriptable object
    public TMP_Text textoPontos;//texto de pontos na tela que vai mostrar os pontos

    //uma variavel para poder chamar cada botão
    public Button buttonSalvarPontos;
    public Button buttonSalvarPosicao;
    public Button buttonZerar;

    [SerializeField] PlayerMove2 playerMove; //puxar os dados atualizados do player pelo script PlayerMove, que é atualizado constantemente, diferente do playerData que só é atualizado quando os dados são salvos

    
    void Start()
    {
        //fazer os botões serem "escutados" para chamarem as funções e funcionarem
        buttonSalvarPontos.onClick.AddListener(OnSalvarPontosClicked); 
        buttonSalvarPosicao.onClick.AddListener(OnSalvarPosicaoClicked);
        buttonZerar.onClick.AddListener(OnZerarClicked);
    }

    void Update()
    {
        //atualiza o texto na tela a partir do playerMove, que é atualizado constantemente pq se for o playerData s� atualizado quando os dados forem salvos
        textoPontos.text = "Pontos: " + playerMove.totalPontos; 
    }

    //ação para o botão de salvar pontos
    public void OnSalvarPontosClicked()
    {
        playerData.pontos = playerMove.totalPontos; //pega os pontos atuais do player e salva no scriptable object
        Debug.Log("Pontos salvos: " + playerData.pontos);
    }

    //ação para o botão de salvar posição
    public void OnSalvarPosicaoClicked()
    {
        //pega a posição atual do player e salva no scriptable object
        playerData.posicao = playerMove.transform.position;
        Debug.Log("Posição salva: " + playerData.posicao);
    }

    //botão para zerar os dados de pontos e posição
    public void OnZerarClicked()
    {
        //zerar os dados de posição e pontos dos dados do player 
        playerMove.transform.position = new Vector3(0, 1, 0); //1 no y para ele não ficar pulando do chão quando iniciar
        playerMove.totalPontos = 0; 
        //zera os dados do scriptable object
        playerData.pontos = 0;
        playerData.posicao = new Vector3(0, 0, 0);
        Debug.Log("Pontos e posição zerados. Pontos: " + playerData.pontos + " Posição: " + playerData.posicao);
       
    }
}