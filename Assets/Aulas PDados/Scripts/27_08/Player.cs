using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Info info;
    public Energia energia = new Energia();
    public Atributos atributos = new Atributos();
    public Stats stats = new Stats();
    

    public bool grounded;

    private void Start()
    {
        atributos.forca = 100;
    }

}

#region Data

[System.Serializable]
public class Info
{
    public Info(string newNome, string newClasse, string newRaca)
    {
        nome = newNome;
        classe = newClasse;
        raca = newRaca;
    }

    public string nome;
    public string classe;
    public string raca;


}

[System.Serializable]
public class Energia
{
    public float vida;
    public float mana;
    public float stamina;
}

[System.Serializable]
public class Atributos
{
    public int vel;
    public int forca;
    public int beleza;
    public int intel;

}
[System.Serializable]
public class Stats
{
    public float armadura;
    public float atk;
}

#endregion
