using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -5;

    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver) return;

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < leftBound && CompareTag("Obstacle")) Destroy(gameObject);
    }
}
