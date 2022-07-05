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

    // ���� �������� �浹�� �߻��ϴ� �̺�Ʈ
    // OnCollisionEnter, OnCollisionStay, OnCollisionExit
    // �ݶ��̴� �浹�� �߻��ϴ� �̺�Ʈ
    // OnTriggerEnter, OnTriggerStay, OnTriggerExit

}
