using UnityEngine;

public class Ex8 : MonoBehaviour
{
    //string � um conjunto de caracteres

    string palavra = "Ao vento";

    string invertida = "";
    void Start()
    {
        // O -1 ap�s a palavra.lenght ele inverte o in�cio
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
