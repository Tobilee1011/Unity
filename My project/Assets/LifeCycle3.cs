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
        //Vector3 vec = new Vector3(0, 0.1f, 0); //벡터값
        //transform.Translate(vec);

        //실린더와 카메라를 동시에 이동하게됨 
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(vec);
    }
}
