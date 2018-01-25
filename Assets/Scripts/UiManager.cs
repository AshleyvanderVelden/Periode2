using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {
    public GameObject player;
    public GameObject startScherm;
    public GameObject enemy;
    public GameObject control;
    public GameObject buttonTekst;
    public GameObject menu;
    public GameObject scoreBoard;
    public GameObject healthBar;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.lockState = CursorLockMode.None;
            menu.SetActive(true);
            player.SetActive(false);
            enemy.SetActive(false);
            scoreBoard.SetActive(false);
            healthBar.SetActive(false);
            buttonTekst.GetComponent<Text>().text = "Resume";
        }
    }
    public void Begin() {
        player.SetActive(true);
        startScherm.SetActive(false);
        enemy.SetActive(true);
        scoreBoard.SetActive(true);
        healthBar.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Controlls() {
        startScherm.SetActive(false);
        control.SetActive(true);
    }
    public void Back()
    {
        control.SetActive(false);
        startScherm.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}