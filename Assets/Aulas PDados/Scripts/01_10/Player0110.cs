using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player0110 : MonoBehaviour
{
    int vida;
    int vidaMax = 1000;

    int buff;
    int debuff;
    int level;
    int atk;

    int escudo = 2;


    //para properties � boa pr�tica sempre come�ar com letra maiuscula e set como private se n�o for usado
    public int PorcentagemVida
    { get { return vida / vidaMax; } }

    public int AtaqueEspecial
    {
        //pegar as vari�veis e faz o c�lculo, mas n�o seta elas definitivamente
        get { return atk * (buff - debuff); }
        private set {}
    }

    public int Vida
    {
        get { return vida * level; }
        set 
        {
            //pode ter loops dentro dos properties
            //vida = value > 0 ? value : 0; if ternario
            /* condi��o ? valorSeVerdadeiro : valorSeFalso
             * se value for maior que 0
             * verdadeiro = ele continua como value
             * falso = ele vai ser 0
             */

            //indicar que vida � o value que est� sendo passado para o property e n�o a vari�vel vida
            vida = value;

            if (vida > 74)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else if (vida > 49)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (vida > 24)
            {
                GetComponent<Renderer>().material.color = Color.gray;
            }
            else if (vida > 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                vida = 0;
                level--;
            }


            if (vida <= 0)
            { 
                vida = 0;
                level--;
            }
        }
           
    }


    void Start()
    {
        vida = 10;
    }


    /*public int Vida
    {
        get
        {
            return vida;
        }
        set 
        { 
            vida = Mathf.Clamp(value, 0, vidaMax); 
            //value � o valor que est� sendo passado para a vida, e estamos dizendo que o valor m�nimo que ele pode chegar � 0 e o m�ximo � o vidaMax
            //se o value for < 0 ou ele voltar� para 0, se value > vidaMax ele volta para vidaMax

        }
    }*/


    // Update is called once per frame
    void Update()
    {
        Enemy0110 enemy = new Enemy0110();
        Debug.Log(enemy.PosX);
    }
}
