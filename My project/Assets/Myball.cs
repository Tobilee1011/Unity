using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    // 선언 할당 사용 
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //1. 속도바꾸기 
        //rigid.velocity = Vector3.right;
        //rigid.velocity = Vector3.left;
        //rigid.velocity = new Vector3(5, 4, 0);

        //2. 힘으로 밀기 
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); //impulse는 캐릭터 점프에 주로사용 

    }

    //1. 속도바꾸기 
    // Update is called once per frame
    //void Update()
    //{
    //    rigid.velocity = new Vector3(2, 4, 1);
    //}

    //RigidBody 관련코드는 FixedUpdate에 작성 (안정적임)
    void FixedUpdate()
    {
        //1. 속도바꾸기 
        //rigid.velocity = new Vector3(2, 4, 1);
        //rigid.velocity = Vector3.forward; //#속력바꾸기

        //2. 힘으로 밀기  
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 1, ForceMode.Impulse);
        //    Debug.Log(rigid.velocity);
        //}
        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        //rigid.AddForce(vec, ForceMode.Impulse);

        //3. 회전력
        //rigid.AddTorque(Vector3.back);

        //rigid.AddTorque(Vector3.up);

        rigid.AddTorque(Vector3.down);
    }
}
