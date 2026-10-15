using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TMP_Text textoTempo;

    void Update()
    {
        textoTempo.text = "Tempo: " + Mathf.CeilToInt(TimerGlobal.Instance.TempoAtual);
    }
}