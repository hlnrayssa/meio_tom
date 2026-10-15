using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text textoTempo;
    public float tempoInicial = 60f;
    float tempoAtual;
    bool rodando = true;

    void Start() => tempoAtual = tempoInicial;

    void Update()
    {
        if (!rodando) return;
        tempoAtual -= Time.deltaTime;
        if (tempoAtual <= 0f)
        {
            tempoAtual = 0f;
            rodando = false;
            // ação ao zerar, ex.: fim de jogo
        }
        textoTempo.text = "Tempo: " + Mathf.CeilToInt(tempoAtual);
    }
}