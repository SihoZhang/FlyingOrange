using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public void Click()             //返回主菜单
    {
        SceneManager.LoadScene("MenuScene");
    }
}
