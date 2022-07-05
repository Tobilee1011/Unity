using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    MeshRenderer mesh;
    Material mat;



    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

    }

    //CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수.
    private void OnCollisionEnter(Collision collision) //Collision : 충돌정보 클래스 
    {
        if (collision.gameObject.name == "MainBall")
            mat.color = new Color(0, 0, 0);
    }

    //CollisionStay : 물리적 충돌이 발생중일때 호출되는 함수 


    //CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수.
    private void OnCollisionExit(Collision collision) //Collision : 충돌정보 클래스 
    {
        if (collision.gameObject.name == "MainBall")
            mat.color = new Color(1, 1, 1);
    }


}
