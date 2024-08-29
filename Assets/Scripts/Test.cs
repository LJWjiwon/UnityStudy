using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject bullet = null;

    private void Start()
    {
        //Instantiate(GameObject)
        //하이어라키에 게임 오브젝트를 생성하는 코드
        //Instantiate(bullet);   
        //Instantiate(GameObject, 위치값, 회전값)
        Instantiate(bullet, new Vector2(1f, 1f), Quaternion.identity);

    }
}
