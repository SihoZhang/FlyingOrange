using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour  //�˽ű����ڿ��������ж�
{
    private float flySpeed;  //ˮƽ�����ٶ�
    private float upSpeed; //���ϵķ����ٶ�
    private float switchTime;
    private int nowTextureNum;
    private bool isWaitTimeStarted;
    public GameObject skin;  //Ƥ��
    public Texture[] GoldenOrangeSkin = new Texture[2];
    public AudioSource flySound;  //���Ϸ�����
    public AudioSource failSound;  //ʧ�ܵ���Ч

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
            this.transform.Translate(flySpeed * Time.deltaTime, 0, 0);   //ˮƽ����
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

    private void ClickScreen()    //�����Ļ���Ϸ���
    {
        if (Input.GetMouseButtonDown(0))
        {
            flySound.Play();
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, upSpeed, 0);  //������Ϸ����һ�����ϵ��ٶ�
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