
using UnityEngine;

public class gerador : MonoBehaviour
{

    public GameObject obstaculos;
    void Start()
    {

        InvokeRepeating("CriarObstaculos", 2f, 2.5f);
    }
    void Update()
    {

    }

    void CriarObstaculos()
    {

        Instantiate(obstaculos);
    }
}
