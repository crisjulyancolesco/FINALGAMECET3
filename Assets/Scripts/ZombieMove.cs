using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    private float speed = 20;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the gameobjects to the left
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetTrigger("Speed_f");
        }

        // Destroy's the obstacle when it goes beyond the left bound
        if (transform.position.x < leftBound && gameObject.CompareTag("Zombie"))
        {
            Destroy(gameObject);
        }
    }
}
