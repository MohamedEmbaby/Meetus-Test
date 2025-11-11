using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Assign your cube prefab here
    public Button2 spawnButton;    // Assign your UI button here
    public float spawnRange = 10f; // How far from the origin cubes can spawn

    void Start()
    {
        if (spawnButton != null)
            spawnButton.onClick.AddListener(SpawnCube);
    }

    void SpawnCube()
    {
        if (cubePrefab == null) return;

        Vector3 randomPos = new Vector3(
            Random.Range(-spawnRange, spawnRange),
            Random.Range(0f, spawnRange),
            Random.Range(-spawnRange, spawnRange)
        );

        Instantiate(cubePrefab, randomPos, Quaternion.identity);
    }
}
