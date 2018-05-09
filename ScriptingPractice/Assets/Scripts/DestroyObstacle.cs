using UnityEngine;
using UnityEngine.UI;

public class DestroyObstacle : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
