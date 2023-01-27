using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Menthod that trigger the collision
    void OnTriggerEnter(Collider other)
    {
        // Destroy the animal and the projectile when they collide
        Destroy(gameObject);
    }
}
