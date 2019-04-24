using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour   //此脚本用来限制人物的上下位置
{
    private void Update()
    {
        if (this.transform.position.y >= 10.5f)     //上界设置无法越过
        {
            this.transform.position = new Vector3(this.transform.position.x, 10.5f, 0);
        }
        if (this.transform.position.y <= -13.0f)
        {
            Information.isDie = true;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<PlayerControlScript>().enabled = false;
            Time.timeScale = 0.0f;
        }
    }
}
