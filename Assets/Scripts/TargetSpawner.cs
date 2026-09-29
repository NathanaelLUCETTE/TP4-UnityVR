using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform[] spawnPoints;

    public float spawnInterval = 3f;

    private void Start()
    {
        InvokeRepeating(
            nameof(SpawnTarget),
            1f,
            spawnInterval
        );
    }

    private void SpawnTarget()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Transform selectedPoint = spawnPoints[randomIndex];

        Instantiate(
            targetPrefab,
            selectedPoint.position,
            selectedPoint.rotation
        );
    }
}