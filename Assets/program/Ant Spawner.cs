using UnityEngine;

public class AntSpawner : MonoBehaviour
{
    public GameObject antPrefab;
    public float spawnInterval = 2f;
    public float xRange = 7f;
    public float yOffset = 6f; // how high above the screen they spawn

    void Start()
    {
        InvokeRepeating("SpawnAnt", 1f, spawnInterval);
    }

    void SpawnAnt()
    {
        float randomX = Random.Range(-xRange, xRange);
        Vector3 spawnPos = new Vector3(randomX, Camera.main.transform.position.y + yOffset, 0f);
        Instantiate(antPrefab, spawnPos, Quaternion.identity);
    }
}
