using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(0, 0.55f, 2);
    // Update is called once per frame
    void Update()
    {
        //1.MoveTowards
        //transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);

        //2.SmoothDamp - �Ű������� (������ġ, ��ǥ��ġ, �����ӵ�, �ӵ�)
        //ref : �������� -> �ǽð����� �ٲ�� �� ���� ����
        //Vector3 velo = Vector3.zero;
        ////Vector3 velo = Vector3.up *50;

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3.Lerp : ��������, SmoothDamp���� ���ӽð��� ��
        //������ �Ű������� ����Ͽ� �ӵ� ���� (�ִ� 1)
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        //4. Slerp : ���� �������� �̵�, ȣ�� �׸��� �̵� 
        //transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
}
