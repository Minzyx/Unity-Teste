using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int dias;
    [SerializeField] int horas;
    [SerializeField] float segundos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10f)
        {
            horas++;
            segundos = 0;
            if(horas == 4)
            {
                dias++;
                horas = 0;
                print(dias);
            }
        }
    }
}
