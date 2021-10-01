using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{
    [Header ("키눌렀을때 작동할 이벤트 ")]
    public UnityEvent OnKeyDown;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            OnKeyDown.Invoke();

        }
    }


}
