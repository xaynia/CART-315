
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject fallingSpherePrefab;
    [SerializeField] private Vector3 spawnPosition = new Vector3(0, 5f, 0f);

    private void Start()
    {
        if (fallingSpherePrefab != null)
        {
            // instantiate the FallingSphere at spawnPosition
            Instantiate(fallingSpherePrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No falling sphere prefab assigned!");
        }
    }
}
