using UnityEngine;

public class Ex5 : MonoBehaviour
{
    //A cada fase completada, a
    //dificuldade aumenta em 5 pontos.Exiba a dificuldade ap�s cada
    //fase, em um total de 6 fases.
    [SerializeField] int dificuldade;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            print("Dificuldade do n�vel: " + dificuldade);
            dificuldade += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
