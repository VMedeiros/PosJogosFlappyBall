using UnityEngine;
public class rotacao : MonoBehaviour
{
    public float volta = 50;
    void Update()
    {
        transform.Rotate(Vector3.up * volta * Time.deltaTime);
    }

}
