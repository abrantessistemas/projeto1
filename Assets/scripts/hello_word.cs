using System.Collections.Generic;
using UnityEngine;

public class hello_word : MonoBehaviour
{
    Dictionary<string, int> mochila = new Dictionary<string, int>();

    int tamanhoMochila;

    // Start is called before the first frame update
    void Start()
    {
        mochila.Add("corda", 1);
        mochila.Add("Elichir e protecao", 3);
        mochila.Add("Espada curta", 1);
        mochila.Add("Espada Longa", 1);
        mochila.Add("Escudo", 1);

        tamanhoMochila = mochila.Count;

        if (mochila.ContainsKey("corda"))
        {
            Debug.Log("Contem uma corda");
        }

        foreach (KeyValuePair<string, int> item in mochila)
        {
            Debug.Log("Item na mochina " + item + "Qtde: " + item.Value);
        }

        Debug.Log("Espaço na mochila: " + tamanhoMochila);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
