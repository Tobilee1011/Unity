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

    //CollisionEnter : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    private void OnCollisionEnter(Collision collision) //Collision : �浹���� Ŭ���� 
    {
        if (collision.gameObject.name == "MainBall")
            mat.color = new Color(0, 0, 0);
    }

    //CollisionStay : ������ �浹�� �߻����϶� ȣ��Ǵ� �Լ� 


    //CollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    private void OnCollisionExit(Collision collision) //Collision : �浹���� Ŭ���� 
    {
        if (collision.gameObject.name == "MainBall")
            mat.color = new Color(1, 1, 1);
    }


}
