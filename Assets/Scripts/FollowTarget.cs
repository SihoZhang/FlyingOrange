using UnityEngine;

public class FollowTarget : MonoBehaviour    //此脚本用于当前对象与目标物体的位置同步
{
    public GameObject followTarget;   //目标物体
    private float differenceX;        //当前物体与目标物体X坐标的差值
    private void Start()
    {
        differenceX = this.transform.position.x - followTarget.transform.position.x;   //计算出初始X轴数值差
    }
    private void LateUpdate()    //在所有Update执行完成后执行，避免摄像机抖动
    {
        this.transform.position = new Vector3(followTarget.transform.position.x + differenceX, this.transform.position.y, this.transform.position.z);
    }
}
