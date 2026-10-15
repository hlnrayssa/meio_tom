using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    public ItemSO[] tiposItens;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject objeto = Instantiate(item, transform.position, transform.rotation);
            objeto.GetComponent<itemLegal>().dadosItem = tiposItens[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject objeto = Instantiate(item, transform.position, transform.rotation);
            objeto.GetComponent<itemLegal>().dadosItem = tiposItens[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject objeto = Instantiate(item, transform.position, transform.rotation);
            objeto.GetComponent<itemLegal>().dadosItem = tiposItens[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject objeto = Instantiate(item, transform.position, transform.rotation);
            objeto.GetComponent<itemLegal>().dadosItem = tiposItens[3];
        }


    }
}
