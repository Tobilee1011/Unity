using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��ŸŸ�� - 1�����ӿ� ���� �ð� (���� �������� �Ϸ���� �ɸ��ð�)
        // deltaTime ���� �������� ������ ũ��, �������� ������ ���� 
        //Time.deltaTime ����
        //Translate : ���Ϳ� ���ϱ�
        // - transform.Translate(Vec*Time.deltaTime);
        //Vector �Լ� : �ð� �Ű������� ���ϱ�
        // - Vector3.Lerp(Vec1, Vec2,T*Time.deltaTime);
        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal") * Time.deltaTime,
        //    Input.GetAxisRaw("Vertical") * Time.deltaTime,
        //    transform.Translate(vec));
    }
}
