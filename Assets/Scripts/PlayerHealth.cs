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
    public GameObject spawnSix;
    public GameObject chainerOne;
    public GameObject chainerTwo;
    public GameObject chainerThree;
    public GameObject chainerFour;
    public GameObject gameOver;
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
            Cursor.lockState = CursorLockMode.None;
        }
        if (killCount == 10)
        {
            spawnOne.SetActive(false);
            spawnTwo.SetActive(true);
            chainerOne.SetActive(false);
        }
        if(killCount == 15)
        {
            spawnTwo.SetActive(false);
            chainerTwo.SetActive(false);
            spawnThree.SetActive(true);
            spawnFour.SetActive(true);
        }
        if (killCount == 30)
        {
            spawnTwo.SetActive(true);
            chainerThree.SetActive(false);
        }
        if (killCount == 40)
        {
            spawnFive.SetActive(true);
            chainerFour.SetActive(false);
        }
        if (killCount == 50)
        {
            spawnSix.SetActive(true);
        }
    }
}
