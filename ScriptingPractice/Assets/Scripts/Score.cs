using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    

	void Update() {
        if (player.position.z >= 0)
            scoreText.text = player.position.z.ToString("0");
        else
            scoreText.text = "0";
	}
}
