using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int estado;
    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Da para fazer com ternário?");
                break;

            case 2:
                print("Sextou!");
                break;

            case 3:
                print("Cadê o Thiago?");
                break;

            case 4:
                print("Cadê a Alana?");
                break;

            case 5:
                print("Jucelino, cadê meu aumento?");
                break;




            default:
                print("Não tenho nada a dizer sobre isso.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
