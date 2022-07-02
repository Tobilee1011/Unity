using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //1. �ʱ�ȭ ����

    //���� ������Ʈ ������ ��, ���ʽ��� 
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    //1-1. ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    //������Ʈ ���� ����, ���ʽ���
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    //2. �������� ����

    //���� ���� ������Ʈ - ������ ���� �ֱ�� CPU�� ���� ���
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    //3. ���ӷ�������

    //���ӷ��� ������Ʈ - �ݺ�����
    void Update()
    {
        Debug.Log("���� ���!");
    }
    //��� ������Ʈ�� ������ ȣ��Ǵ� �Լ�
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    //1-2. ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    //4. ��ü����

    // ���� ������Ʈ�� �����ɶ� - awake �ݴ밳�� (�Ǹ����� �����ϸ� �ڵ����� ������ �ȴ�)
    void OnDestroy ()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}
