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

        //2.SmoothDamp - 매개변수는 (현재위치, 목표위치, 참조속도, 속도)
        //ref : 참조접근 -> 실시간으로 바뀌는 값 적용 가능
        //Vector3 velo = Vector3.zero;
        ////Vector3 velo = Vector3.up *50;

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3.Lerp : 선형보간, SmoothDamp보다 감속시간이 김
        //마지막 매개변수에 비례하여 속도 증가 (최대 1)
        //transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        //4. Slerp : 구면 선형보간 이동, 호를 그리며 이동 
        //transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
}
