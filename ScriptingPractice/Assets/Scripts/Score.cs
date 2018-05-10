using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public int score;
    public int bonus;
    public bool alive = true;

    void Start()
    {
        score = 0;
        bonus = 0;
    }

	void Update()
    {
        if (player.position.z > 0 && alive)
            score = (int)player.position.z;
        SetScoreText();        
	}

    public void AddBonusPoints()
    {
        bonus += 100;
    }

    void SetScoreText()
    {
        if (alive)
            scoreText.text = (score + bonus).ToString("0");
    }
}
