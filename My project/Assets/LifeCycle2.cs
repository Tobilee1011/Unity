using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    
    void Update()
    {
        //�ƹ� �Է��� ���ʷ� ���� �� true
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        ////�ƹ� �Է��� ������ true
        //if (Input.anyKey)
        //    Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        //// GeyKey : Ű���� ��ư �Է��� ������ true
        //if(Input.GetKeyDown(KeyCode.Return)) // Return�� ���͹�ư�� 
        //{
        //    Debug.Log("�������� �����Ͽ����ϴ�.");
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Debug.Log("�������� �̵� ��");
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log("���������� �̵��� ���߾����ϴ�.");
        //}

        //GetMouse : ���콺 ��ư �Է��� ������ true
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("�̻��� �߻�!");
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("�̻��� ��������...");
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("���� �̻��� �߻�!");
        //}
        
        //if (Input.GetButtonDown("Jump")) //Jump�� Fire�ε� ���� ���� 
        //    Debug.Log("����!");
        //if (Input.GetButton("Jump"))
        //    Debug.Log("���� �������� ...");
        //if(Input.GetButtonUp("Jump"     ))
        //    Debug.Log("��������!!");

        ////InputManger���� Button�߰� ���� ������ 
        ////Axis ����� �ø��� Cancel���� Ŀ�ǵ� �̸�(SuperFire) ���� �� ��ũ��Ʈ �ۼ�
        //if (Input.GetButtonDown("SuperFire")) //Jump�� Fire�ε� ���� ���� 
        //    Debug.Log("�ʻ��!");

        if(Input.GetButton("Horizontal"))
        {
            //GetAxis:����, ���� ��ư �Է��� ������ float ��ȯ 

            //�������� ����Ǵ� �����
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));


            ////�������� ����ȵǰ� �Ϸ��� raw�� ���� 
            //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxis("Vertical"));
        }



    }
}
