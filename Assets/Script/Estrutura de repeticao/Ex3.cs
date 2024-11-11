using UnityEngine;

public class Ex3 : MonoBehaviour
{
    //    O jogador coleta 3 moedas a
    //cada fase.Após 10 fases, exiba o total de moedas coletadas.
    [SerializeField] int moeda = 3;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            print("Moedas: " + moeda);
            moeda += 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
