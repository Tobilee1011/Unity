using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    
    void Update()
    {
        //아무 입력을 최초로 받을 때 true
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        ////아무 입력을 받으면 true
        //if (Input.anyKey)
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        //// GeyKey : 키보드 버튼 입력을 받으면 true
        //if(Input.GetKeyDown(KeyCode.Return)) // Return은 엔터버튼임 
        //{
        //    Debug.Log("아이템을 구입하였습니다.");
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Debug.Log("왼쪽으로 이동 중");
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log("오른쪽으로 이동을 멈추었습니다.");
        //}

        //GetMouse : 마우스 버튼 입력을 받으면 true
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("미사일 발사!");
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("미사일 모으는중...");
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("슈퍼 미사일 발사!");
        //}
        
        //if (Input.GetButtonDown("Jump")) //Jump를 Fire로도 변경 가능 
        //    Debug.Log("점프!");
        //if (Input.GetButton("Jump"))
        //    Debug.Log("점프 모으는중 ...");
        //if(Input.GetButtonUp("Jump"     ))
        //    Debug.Log("슈퍼점프!!");

        ////InputManger에서 Button추가 변경 가능함 
        ////Axis 사이즈를 늘리고 Cancel에서 커맨드 이름(SuperFire) 변경 후 스크립트 작성
        //if (Input.GetButtonDown("SuperFire")) //Jump를 Fire로도 변경 가능 
        //    Debug.Log("필살기!");

        if(Input.GetButton("Horizontal"))
        {
            //GetAxis:수평, 수직 버튼 입력을 받으면 float 반환 

            //감가속이 적용되는 모습임
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));


            ////감가속이 적용안되게 하려면 raw를 붙임 
            //Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxis("Vertical"));
        }



    }
}
