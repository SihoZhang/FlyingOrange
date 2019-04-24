using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject player;
    public void StartGameMethod()
    {
        Time.timeScale = 1;
        player.GetComponent<PlayerControlScript>().enabled = true;
        player.GetComponent<BoxCollider>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
