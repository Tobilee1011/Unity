using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    // ���� �Ҵ� ��� 
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //1. �ӵ��ٲٱ� 
        //rigid.velocity = Vector3.right;
        //rigid.velocity = Vector3.left;
        //rigid.velocity = new Vector3(5, 4, 0);

        //2. ������ �б� 
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); //impulse�� ĳ���� ������ �ַλ�� 

    }

    //1. �ӵ��ٲٱ� 
    // Update is called once per frame
    //void Update()
    //{
    //    rigid.velocity = new Vector3(2, 4, 1);
    //}

    //RigidBody �����ڵ�� FixedUpdate�� �ۼ� (��������)
    void FixedUpdate()
    {
        //1. �ӵ��ٲٱ� 
        //rigid.velocity = new Vector3(2, 4, 1);
        //rigid.velocity = Vector3.forward; //#�ӷ¹ٲٱ�

        //2. ������ �б�  
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);
        //    Debug.Log(rigid.velocity);
        //}
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        //rigid.AddForce(vec, ForceMode.Impulse);

        //3. ȸ����
        //rigid.AddTorque(Vector3.back);

        //rigid.AddTorque(Vector3.up);

        rigid.AddTorque(Vector3.down);
    }
}
