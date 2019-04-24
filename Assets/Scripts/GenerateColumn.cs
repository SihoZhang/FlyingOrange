using UnityEngine;

public class GenerateColumn : MonoBehaviour  //此脚本用来生成柱子
{
    public GameObject[] column = new GameObject[5];
    private int columnNum;   //要生成的柱子编号，从0开始
    private bool isGenerated; //是否已经生成完成
    private void Start()
    {
        isGenerated = false;
        for (int i = 0; i < 10; i++)
        {
            columnNum = Random.Range(0, 5);
            Instantiate(column[columnNum], new Vector3(Information.columnNowX, 0, 0), column[columnNum].transform.rotation);
            Information.columnNowX += Information.interval;
        }
    }
    private void Update()
    {
        if (Information.scores % 5 == 0 && Information.scores != 0 && !isGenerated)
        {
            for (int i = 0; i < 5; i++)
            {
                columnNum = Random.Range(0, 5);
                Instantiate(column[columnNum], new Vector3(Information.columnNowX, 0, 0), column[columnNum].transform.rotation);
                Information.columnNowX += Information.interval;
            }
            isGenerated = true;
        }
        else if (Information.scores % 5 != 0)
        {
            isGenerated = false;
        }
    }
}
