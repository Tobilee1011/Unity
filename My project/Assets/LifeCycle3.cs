using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0); //���Ͱ�
        //transform.Translate(vec);

        //�Ǹ����� ī�޶� ���ÿ� �̵��ϰԵ� 
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
