using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    ////(Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.


    [SerializeField] int dano = 2;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            print("Dano: " + dano);
            dano += 2;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
