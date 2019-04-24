using UnityEngine;

public class Initialize : MonoBehaviour   //此脚本用来做游戏初始化时候的一些工作
{
    public GameObject restartButton;
    public GameObject menuButton;
    public GameObject exitButton;
    private void Start()
    {
        restartButton.SetActive(false);
        menuButton.SetActive(false);
        exitButton.SetActive(false);
        Time.timeScale = 0.0f;
    }
}
