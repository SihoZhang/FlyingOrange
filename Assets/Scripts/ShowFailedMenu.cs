using UnityEngine;

public class ShowFailedMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject restartButton;
    public GameObject menuButton;
    public GameObject exitButton;
    private void Update()
    {
        if (Information.isDie && player.transform.position.y < -13.0f)
        {
            restartButton.SetActive(true);
            menuButton.SetActive(true);
            exitButton.SetActive(true);
        }
    }
}
