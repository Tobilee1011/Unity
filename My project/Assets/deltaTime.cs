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
        //델타타임 - 1프레임에 사용된 시간 (이전 프레임의 완료까지 걸린시간)
        // deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 작음 
        //Time.deltaTime 사용법
        //Translate : 벡터에 곱하기
        // - transform.Translate(Vec*Time.deltaTime);
        //Vector 함수 : 시간 매개변수에 곱하기
        // - Vector3.Lerp(Vec1, Vec2,T*Time.deltaTime);
        //Vector3 vec = new Vector3(
        //    Input.GetAxisRaw("Horizontal") * Time.deltaTime,
        //    Input.GetAxisRaw("Vertical") * Time.deltaTime,
        //    transform.Translate(vec));
    }
}
