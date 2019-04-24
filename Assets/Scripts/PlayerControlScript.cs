using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour  //此脚本用于控制人物行动
{
    private float flySpeed;  //水平飞行速度
    private float upSpeed; //向上的飞行速度
    private float switchTime;
    private int nowTextureNum;
    private bool isWaitTimeStarted;
    public GameObject skin;  //皮肤
    public Texture[] GoldenOrangeSkin = new Texture[2];
    public AudioSource flySound;  //向上飞声音
    public AudioSource failSound;  //失败的音效

    private void Start() 
    {
        flySpeed = 8.0f;
        upSpeed = 13.0f;
        switchTime = 0.01f;
        nowTextureNum = 0;
        isWaitTimeStarted = false;
    }

    private void Update()
    {
        if (!Information.isDie)
        {
            this.transform.Translate(flySpeed * Time.deltaTime, 0, 0);   //水平飞行
        }
        ClickScreen();
        FlyMotion();
    }

	private void OnCollisionEnter(Collision column)
	{
        if (column.transform.tag == "Barrier")
        {
            failSound.Play();
            Information.isDie = true;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<PlayerControlScript>().enabled = false;
        }
	}

    private void ClickScreen()    //点击屏幕向上飞行
    {
        if (Input.GetMouseButtonDown(0))
        {
            flySound.Play();
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, upSpeed, 0);  //给予游戏对象一个向上的速度
        }
    }

    private void FlyMotion()
    {
        if (!isWaitTimeStarted)
        {
            StartCoroutine(WaitTime(switchTime));
            if (nowTextureNum == 0)
            {
                skin.GetComponent<Renderer>().material.mainTexture = GoldenOrangeSkin[1];
                nowTextureNum = 1;
            }
            else
            {
                skin.GetComponent<Renderer>().material.mainTexture = GoldenOrangeSkin[0];
                nowTextureNum = 0;
            }
        }
        
    }
    IEnumerator WaitTime(float needWaitTime)
    {
        isWaitTimeStarted = true;
        yield return new WaitForSeconds(needWaitTime);
        isWaitTimeStarted = false;
    }

}