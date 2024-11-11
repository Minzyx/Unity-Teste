using UnityEngine;

public class Ex4 : MonoBehaviour
{
    //    Cada combo realizado aumenta em 10
    //pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int pontos;
    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            print("Pontuação: " + pontos);
            pontos += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
