using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet = null;
    public Transform shootTr = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shootTr.position, shootTr.rotation);
        }
    }
}
