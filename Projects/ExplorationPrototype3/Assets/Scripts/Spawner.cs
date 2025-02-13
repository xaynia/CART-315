using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    
//    public GameObject fallingSpherePrefab; //spawning prefab
//    public List<GameObject> spawnedSpheres; // track spawned spheres
//
//    [Tooltip("This is the amount a sphere will shrink each frame.")]
//    public float scalingFactor = 0.95f;
//    public int numSpheres = 0; // count of spawned spheres
//
//    void Start() {
//       // initialize list
//       spawnedSpheres = new List<GameObject>();
//    }
//
//    void Update() {
//       // spawn new sphere each frame
//       numSpheres++;
//       
//       // instantiate a new sphere
//       GameObject gObj = Instantiate(fallingSpherePrefab);
//       gObj.name = "FallingSphere" + numSpheres;
//       
//       
//       // Spawn at random X, random Z, with a fixed Y (make it rain)
//       float xPos = Random.Range(-5f, 5f);
//       float yPos = 6f; // starting y position
//       float zPos = Random.Range(-5f, 5f);
//       gObj.transform.position = new Vector3(xPos, yPos, zPos);
//       // Add the new sphere to our list
//       spawnedSpheres.Add(gObj);
//
//       // Make a temporary list for anything we need to remove
//       List<GameObject> removeList = new List<GameObject>();
//
//       // Scale each existing sphere down
//       foreach (GameObject sphere in spawnedSpheres) {
//       //    float scale = sphere.transform.localScale.x;
//       //    scale *= scalingFactor;
//       //    sphere.transform.localScale = Vector3.one * scale;
//       //
//       //    // If it’s too small, mark it for removal
//       //    if (scale <= 0.1f) {
//       //       removeList.Add(sphere);
//       //    }
//       // }
//       //
//       // // Now remove flagged spheres
//       // foreach (GameObject sphere in removeList) {
//       //    spawnedSpheres.Remove(sphere);
//       //    Destroy(sphere);
//       }
//    }
// }

    // --- Singleton instance ---
    public static Spawner instance;

    [Header("Falling Sphere Prefab")]
    public GameObject fallingSpherePrefab;

    // count of spawned spheres
    public List<GameObject> spawnedSpheres = new List<GameObject>();

    // spawn frequency
    public float spawnInterval = 1f;
    private float timer = 0f;

    private void Awake() {
        // Ensures only one Spawner exists
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Update() {
        //  spawns a ball every spawnInterval seconds
        timer += Time.deltaTime;
        if (timer >= spawnInterval) {
            timer = 0f;
            SpawnBall();
        }
    }

    private void SpawnBall() {
        GameObject sphere = Instantiate(fallingSpherePrefab);
        spawnedSpheres.Add(sphere);

        sphere.transform.position = new Vector3(
            Random.Range(-5f, 5f),
            6f, // start height
            Random.Range(-5f, 5f)
        );
    }

    // remove sphere
    public void RemoveSphere(GameObject sphere) {
        if (spawnedSpheres.Contains(sphere)) {
            spawnedSpheres.Remove(sphere);
        }
        Destroy(sphere);
    }
}