
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    private string flappyBird;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb = GetComponent<Rigidbody>();
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector3(0, 300, 0));
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Morrer();
    }
    void Morrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
