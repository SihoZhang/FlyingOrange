using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour         //此脚本用于重新开始游戏
{
    public void RestartMethod()
    {
        SceneManager.LoadScene("MainScene");
    }
}
