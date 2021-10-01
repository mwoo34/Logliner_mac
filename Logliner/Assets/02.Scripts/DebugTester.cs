using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTester : MonoBehaviour
{
    private void OnValidate()
    {
        //이스크립트를 컴포넌트로 삼은 게임오브젝트 이름을 바꿈
        gameObject.name = "DebugTester";

    }
    public void TestDebug(string arg)
    {
        Debug.Log(arg);
    }
}
