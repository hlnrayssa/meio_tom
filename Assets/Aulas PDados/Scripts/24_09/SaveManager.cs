using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    #region Singleton
    public static SaveManager instance;

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

    public string nome;
    public int idade;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Salvar(nome);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Salvar(idade);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Salvar(altura);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            ApagarDados();
        }

        /*if (Input.GetKeyDown(KeyCode.X))
        {
            ApagarDados("Nome");
        }*/

        if (Input.GetKeyDown(KeyCode.G))
        {
            string valor = PlayerPrefs.GetString("Nome");
            Debug.Log(valor);
        }
    }

    public void Salvar()
    {
        Debug.LogWarning("Não passou valor!");
    }
    public void Salvar(string valor)
    {
        PlayerPrefs.SetString("Nome", nome);
        Debug.Log(nome);
    }

    public void Salvar(int valor)
    {
        PlayerPrefs.SetInt("Idade", idade);
        Debug.Log(idade);
    }

    public void Salvar(float valor)
    {
        PlayerPrefs.SetFloat("Altura", altura);
        Debug.Log(altura);
    }

    public void ApagarDados()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Dados apagados!");
    }

    /*public void ApagarDados(string )
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Dados apagados!");
    }*/

}
