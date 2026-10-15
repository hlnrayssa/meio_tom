using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public PlayerMovement player;
    public Vector3 posicao;

    #region Singleton
    public static SaveGame instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SalvarPos();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ZerarPos();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ApagarPos();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Mover();
        }
    }

    void SalvarPos()
    {
        posicao = player.transform.position;
        PlayerPrefs.SetFloat("PosX", posicao.x);
        PlayerPrefs.SetFloat("PosY", posicao.y);
        PlayerPrefs.SetFloat("PosZ", posicao.z);
        Debug.Log("Posição salva: " + posicao);
    }

    void ZerarPos()
    {
        player.transform.position = Vector3.zero;
        player.transform.position = posicao;
        Debug.Log("Posição zerada" + posicao);
    }

    void ApagarPos()
    {
        PlayerPrefs.DeleteKey("PosX");
        PlayerPrefs.DeleteKey("PosY");
        PlayerPrefs.DeleteKey("PosZ");
        Debug.Log("Dados de posição apagados");

    }

    void Mover()
    {
        float x = PlayerPrefs.GetFloat("PosX");
        float y = PlayerPrefs.GetFloat("PosY");
        float z = PlayerPrefs.GetFloat("PosZ");

        player.transform.position = new Vector3(x, y, z);
        Debug.Log("Player movido para: " + posicao);

    }
}
