using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

    public CameraFollow cameraFollow;
    public ShakeCamera cameraShake;

    private Score score;
    private GameManager gameManager;
    //private MoveCube movement;

    void Awake()
    {
        // movement = GetComponent<MoveCube>();
        gameManager = FindObjectOfType<GameManager>();
        score = FindObjectOfType<Score>();
    }

	void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // When the player is destroyed it falls through the ground after its movement is disabled
            //gameObject.GetComponent<BoxCollider>().enabled = false;
            //movement.enabled = false;
            //cameraFollow.enabled = false;
            Destroy(gameObject, 1f);
            score.alive = false;
            gameManager.EndGame();

            StartCoroutine(cameraShake.Shake(.15f, .4f));
        }
    }
}
