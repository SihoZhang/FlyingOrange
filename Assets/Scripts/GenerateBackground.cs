using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour   //此脚本用来生成背景
{
    public GameObject player;
    public GameObject background;
    private bool isGenerated;
    private void Start()
    {
        isGenerated = false;
    }
    private void Update()
    {
        if(!isGenerated)
        {
            if (player.transform.position.x - this.transform.position.x >= 0.0f)
            {
                GameObject newBackground = Instantiate(background, new Vector3(Information.backgroundNowX, 0, 2.0f), background.transform.rotation);
                newBackground.name = "NewBackground";
                Information.backgroundNowX += 80.0f;
                isGenerated = true;
            }
        }
        if (isGenerated && player.transform.position.x - this.transform.position.x >= 80.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
