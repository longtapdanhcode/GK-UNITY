using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 15f;
    public float lifeTime = 3f;

    void Start()
    {
        // Tự huỷ sau 3 giây để tránh nặng bộ nhớ
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Bay thẳng lên phía trên màn hình
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Bắn trúng thiên thạch -> Huỷ thiên thạch và viên đạn
        if (collision.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}