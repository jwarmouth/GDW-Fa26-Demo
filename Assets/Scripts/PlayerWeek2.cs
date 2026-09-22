using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeek2 : MonoBehaviour
{
    public float speed;
    public InputAction moveAction;
    public InputAction fireAction;
    public Vector2 moveVector;

    public GameObject[] projectiles;
    public Transform spawnPoint;

    public float stopwatch;

    private void OnEnable()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.right * moveVector.x * speed * Time.deltaTime);
        stopwatch += Time.deltaTime; // counts up

        /*if (stopwatch >= 1)
        {
            stopwatch = 0; // reset stopwatch
            Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        }
        */

        if (fireAction.triggered)
        {
            int dieRoll = Random.Range(0, projectiles.Length);

            Instantiate(projectiles[dieRoll], spawnPoint.position, 
                projectiles[dieRoll].transform.rotation);
        }

    }
}
