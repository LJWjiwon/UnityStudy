using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject bullet = null;

    private void Start()
    {
        //Instantiate(GameObject)
        //���̾��Ű�� ���� ������Ʈ�� �����ϴ� �ڵ�
        //Instantiate(bullet);   
        //Instantiate(GameObject, ��ġ��, ȸ����)
        Instantiate(bullet, new Vector2(1f, 1f), Quaternion.identity);

    }
}
