using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //1. 초기화 영역

    //게임 오브젝트 생성할 때, 최초실행 
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    //1-1. 게임 오브젝트가 활성화 되었을 때
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    //업데이트 시작 직전, 최초실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    //2. 물리연산 영역

    //물리 연산 업데이트 - 고정된 실행 주기로 CPU를 많이 사용
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    //3. 게임로직영역

    //게임로직 업데이트 - 반복실행
    void Update()
    {
        Debug.Log("몬스터 사냥!");
    }
    //모든 업데이트가 끝난후 호출되는 함수
    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    //1-2. 게임 오브젝트가 비활성화 되었을 때
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    //4. 해체영역

    // 게임 오브젝트가 삭제될때 - awake 반대개념 (실린더를 삭제하면 자동으로 삭제가 된다)
    void OnDestroy ()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
