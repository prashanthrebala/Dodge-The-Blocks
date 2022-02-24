
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float mapWidth;
    private Rigidbody2D rb;

    public void Start() {

        rb = GetComponent<Rigidbody2D>();

    }

    public void FixedUpdate() {

        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime;
        Vector2 newPosition = rb.position + Vector2.right * x * speed;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);

    }

    public void OnCollisionEnter2D () {
        FindObjectOfType<GameManager>().EndGame();
    }

}
