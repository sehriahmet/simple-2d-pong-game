using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D ball;

    void Start()
    {
        float xDir = UnityEngine.Random.Range(0f, 1f) < 0.5f ? -1f : 1f;
        float yDir = UnityEngine.Random.Range(0f, 1f) < 0.5f ? -1f : 1f;

        ball.linearVelocity = new Vector2(xDir * moveSpeed, yDir * moveSpeed);
    }

    void Update()
    {
        
    }
}
