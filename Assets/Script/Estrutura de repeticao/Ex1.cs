using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    //    Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.

    [SerializeField] int i = 0;
    void Start()
    {
        for (int i = 5; i >= 1; i--)
        {
            print(i);
        }
        print("Inicio da partida!");
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
