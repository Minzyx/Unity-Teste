using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    int[] numeros = { 3, 5, 45, 7, 10, 68, 23, 71, 18, 97 };
    int maior;
    void Start()
    {
        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item> maior)
            {
                maior = item;
            }
        }
        print("O maior n�mero �: " + maior);
    }

        
    // Update is called once per frame
    void Update()
    {
        
    }
}
