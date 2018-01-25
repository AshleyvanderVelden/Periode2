using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public float playerHp;
    public string hpConverter;
    public int killCount;
    public string killConverter;
    public GameObject healthBar;
    public GameObject score;
    public GameObject spawnOne;
    public GameObject spawnTwo;
    public GameObject spawnThree;
    public GameObject spawnFour;
    public GameObject spawnFive;
    public GameObject gameOver;
    public GameObject finalScore;
    public GameObject battleMusic;
    public GameObject deathMusic;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hpConverter = playerHp.ToString();
        killConverter = killCount.ToString();
        healthBar.GetComponent<Text>().text = hpConverter;
        score.GetComponent<Text>().text = killConverter;
        if (playerHp <= 0)
        {
            Destroy(gameObject);
            spawnOne.SetActive(false);
            spawnTwo.SetActive(false);
            spawnThree.SetActive(false);
            spawnFour.SetActive(false);
            spawnFive.SetActive(false);
            gameOver.SetActive(true);
            battleMusic.SetActive(false);
            deathMusic.SetActive(true);
            finalScore.GetComponent<Text>().text = killConverter;
            Cursor.lockState = CursorLockMode.None;
        }
        if (killCount == 10)
        {
            spawnTwo.SetActive(true);
        }
        if(killCount == 15)
        {
            spawnThree.SetActive(true);
        }
        if (killCount == 30)
        {
            spawnFour.SetActive(true);
        }
        if (killCount == 40)
        {
            spawnFive.SetActive(true);
        }
    }
}
