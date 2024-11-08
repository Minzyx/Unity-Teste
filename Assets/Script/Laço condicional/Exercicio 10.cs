using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocaoVida = false;
    void Start()
    {
        switch (tipoItem)
        {
            case "moedas":
                moeda++;
                print("moeda coletada: " + moeda);
                break;

            case "escudo":
                escudo = true;
                print("escudo ativo");
                break;

            case "Poção":
                pocaoVida= true;
                print("Poção de vida coletada");
                break;

            default:
                Debug.Log("Item desconhecido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
