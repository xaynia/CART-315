// Using statements: link script to necessary libraries (so when you enter something like RigidBody, script knows what that means)
using UnityEngine;

// class declaration: 
// public class named "Collectible", that inherits unity's MonoBehaviour class (MonoBehaviour is required class for all gameObjects in Unity)
public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
