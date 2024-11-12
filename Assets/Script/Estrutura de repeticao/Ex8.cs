using UnityEngine;

public class Ex8 : MonoBehaviour
{
    //string é um conjunto de caracteres

    string palavra = "Ao vento";

    string invertida = "";
    void Start()
    {
        // O -1 após a palavra.lenght ele inverte o início
        for (int i = palavra.Length -1 ; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        print("String invertida: " + invertida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
