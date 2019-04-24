using UnityEngine;

public class RotatePlayer : MonoBehaviour   //此脚本用于实现角色飞行的仰角与俯角功能
{
    private Vector3 prePos;
    private Vector3 nowPos;
    private float nowRotationZ; //当前Z轴旋转角度
    private float angle;
    public float rotateScale;
    private void Start()
    {
        prePos = this.transform.position;
        rotateScale = 90.0f;
        nowRotationZ = 0.0f;
    }
    private void Update()
    {
        nowPos = this.transform.position;
        angle = Time.deltaTime * rotateScale;
        angle = prePos.y <= nowPos.y ? angle : -angle;
        if (nowRotationZ <= 10.0f && nowRotationZ >= -85.0f)
        {
            this.transform.Rotate(0, 0, angle);
            nowRotationZ += angle;
        }
        else if (nowRotationZ > 10.0f)
        {
            this.transform.Rotate(0, 0, -(nowRotationZ - 10.0f));
            nowRotationZ = 10.0f;
        }
        else if (nowRotationZ < -85.0f)
        {
            this.transform.Rotate(0, 0, -(nowRotationZ + 85.0f));
            nowRotationZ = -85.0f;
        }
        prePos = nowPos;
    }
}
