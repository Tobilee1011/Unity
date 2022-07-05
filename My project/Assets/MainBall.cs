using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 1 , ForceMode.Impulse);

    }

    // 실제 물리적인 충돌로 발생하는 이벤트
    // OnCollisionEnter, OnCollisionStay, OnCollisionExit
    // 콜라이더 충돌로 발생하는 이벤트
    // OnTriggerEnter, OnTriggerStay, OnTriggerExit

}
