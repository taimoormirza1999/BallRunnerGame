using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPannel;

private void Start()
{
     GameOverPannel.SetActive(false);
}
public void showGameOverPannel(){
    GameOverPannel.SetActive(true);
}
public void Restart(){
    SceneManager.LoadScene("Game");
    GameOverPannel.SetActive(false);
}
public void Quit(){
    Application.Quit();
    // GameOverPannel.SetActive(true);
}

}
