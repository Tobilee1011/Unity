using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
         
        if (Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");
    }
}
