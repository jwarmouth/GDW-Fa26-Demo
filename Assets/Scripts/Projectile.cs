using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Destroy by time
        //Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 20)
        {
            Destroy(gameObject);
        }
    }
}
