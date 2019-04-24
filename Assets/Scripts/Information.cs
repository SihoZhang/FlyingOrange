using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information: MonoBehaviour   //此脚本用来记录一些各脚本间共享的信息
{
    public static int scores;     //用来记录得分
    public static bool isDie; //是否失败
    public static float backgroundNowX;
    public static float columnNowX;
    public static float interval = 12.0f;  //两个柱子间相隔的距离，因不同的模式而距离不同
    private void Awake()
    {
        scores = 0;
        isDie = false;
        backgroundNowX = 80.0f;
        columnNowX = 0.0f;
    }
}
