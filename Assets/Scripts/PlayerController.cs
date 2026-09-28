using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7f;
    public GameObject laserPrefab;
    public Transform firePoint;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Nhận phím mũi tên hoặc WASD
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // Bấm Space để bắn
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        // Di chuyển mượt mà bằng Rigidbody 2D
        rb.linearVelocity = moveInput.normalized * moveSpeed;
    }

    void Shoot()
    {
        if (laserPrefab != null && firePoint != null)
        {
            Instantiate(laserPrefab, firePoint.position, Quaternion.identity);
        }
    }

   void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Star"))
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(10);
        }
        Destroy(collision.gameObject);
    }
    else if (collision.CompareTag("Asteroid"))
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver();
        }
        Destroy(gameObject);
    }
}
}