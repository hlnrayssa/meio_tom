using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy0110 : MonoBehaviour
{

    int atkenemy = 10;
    Player0110 player;

    float baseXp = 15;
    float level = 1;

    public float XP
    { get
        { return baseXp * level; }
        private set { }
    }

    public float PosX
    {
        get { return transform.position.x; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
