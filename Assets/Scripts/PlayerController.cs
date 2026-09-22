using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * 
            Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.up * Time.deltaTime * speed *
            Input.GetAxis("Vertical"));
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        score++;
    }
}
