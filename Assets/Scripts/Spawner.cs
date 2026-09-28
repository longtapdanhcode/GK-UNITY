using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject starPrefab;

    public float spawnInterval = 1.2f;
    public float spawnXRange = 7f;
    public float spawnY = 6f;

    void Start()
    {
        // Gọi lặp lại hàm SpawnObject
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(-spawnXRange, spawnXRange);
        Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);

        // 70% ra thiên thạch, 30% ra ngôi sao
        if (Random.value < 0.7f)
        {
            if (asteroidPrefab != null)
                Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            if (starPrefab != null)
                Instantiate(starPrefab, spawnPos, Quaternion.identity);
        }
    }
}