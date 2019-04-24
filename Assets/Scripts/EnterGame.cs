using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterGame : MonoBehaviour  //此脚本用于从当前场景转换到游戏场景
{
    public AudioSource buttonSound;
    public void Click()
    {
        buttonSound.Play();
        if (this.gameObject.name == "EasyMode") Information.interval = 12.0f;
        else if (this.gameObject.name == "MiddleMode") Information.interval = 11.0f;
        else if (this.gameObject.name == "HardMode") Information.interval = 10.0f;
        SceneManager.LoadScene("MainScene");
    }
}
