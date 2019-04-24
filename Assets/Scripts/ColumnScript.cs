using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColumnScript: MonoBehaviour        //此脚本用来判断得分和修改记录分值的变量
{
    private GameObject player;    //玩家游戏对象
    private GameObject scoresText;   //用来记录得分的文本组件
    private bool isGetedScore;   //记录是否已经判断过得分
    private AudioSource getScoreSound;
    private void Start()
    {
        player = GameObject.Find("Player");
        scoresText = GameObject.Find("Canvas/ScoreText");
        getScoreSound = GameObject.Find("Sound/GetScoreSound").GetComponent<AudioSource>();
        isGetedScore = false;
    }
    private void Update()
    {
        if(!isGetedScore)
        {
            if (player.transform.position.x - this.transform.position.x >= 0.4f)
            {
                getScoreSound.Play();
                Information.scores++;
                scoresText.GetComponent<Text>().text = Information.scores.ToString();
                isGetedScore = true;
            }
        }
        if (player.transform.position.x - this.transform.position.x >= 20.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
