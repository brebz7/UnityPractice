using UnityEngine;
using UnityEngine.UI;

public class DestroyObstacle : MonoBehaviour {

    private Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            score.AddBonusPoints();
        }
    }
}
