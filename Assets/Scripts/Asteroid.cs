using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minSpeed = 2f;
    public float maxSpeed = 4f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Tạo hướng bay ngẫu nhiên chúi xuống dưới hoặc tỏa tròn
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, -1.5f)).normalized;
        rb.linearVelocity = randomDirection * Random.Range(minSpeed, maxSpeed);

        // Tự hủy sau 8 giây nếu bay ra khỏi màn hình
        Destroy(gameObject, 8f);
    }
}