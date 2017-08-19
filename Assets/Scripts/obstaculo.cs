using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public float velocidade;
    public float range = 3;

    void Start()
    {
        transform.position -= new Vector3(transform.position.x, transform.position.y - range * Random.value, 0);
    }

    void Update()
    {
        transform.position -= new Vector3(velocidade, 0, 0) * Time.deltaTime;
    }
}
