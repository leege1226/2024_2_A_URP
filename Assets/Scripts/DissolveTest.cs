using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveTest : MonoBehaviour
{

    public Material material;   //메테리얼을 불러온다.
    public float amount = -1;   //설정한 값을 받아온다.
    public bool bDisslove;      //시작 플래그

    private void Start()
    {
        amount = -1;
        material.SetFloat("_Amount", amount);
    }

    void Update()
    {
        if(bDisslove)
        {
            amount += Time.deltaTime;
            material.SetFloat("_Amount", amount);
        }

    }
}
