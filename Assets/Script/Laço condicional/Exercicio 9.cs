using UnityEngine;

public class Exercicio9 : MonoBehaviour
{

    [SerializeField] int placarTimeA;
    [SerializeField] int placarTimeB;
    void Start()
    {
        if (placarTimeA > placarTimeB)
        {
            print("Vitória do time A!");

        }
        else if (placarTimeB > placarTimeA) 
        {
            print("Vitoria do time B");
        }
        else //caso de empate
        {
            if(placarTimeA > 3 && placarTimeB > 3)
            {
                print("Foi um empate emocionante!");
            }
            else
            {
                print("Foi um empate!");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
