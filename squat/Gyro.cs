using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 // 기존의 시선으로는 측정하기 어려웠던 y축의 움직임을 찾기 위해 자이로센서 사용
 // y축 움직임 측정으로 스쿼트자세를 취했을 때 시선이 움직이지 않아도 응시점이 이동
public class Gyro : MonoBehaviour
{
    public Text text;   //자이로값
    int count = 0;
    public Text textcount;
    private bool gyroCheck; //자이로 기능 탑재 체크
    private Gyroscope gyro;

    private GameObject Container;

    private Quaternion rot;

    /*private void Awake()
    {
        //자이로 센서값 화면 글자 설정
        text.text = "Salut";
        text.fontSize = 30;
        text.color = Color.white;
          
    }*/

    void Start()
    {
        //기준 좌표 및 축 설정을 위한 부모 오브젝트
        Container = new GameObject("Container");
        //container object 만듬
        Container.transform.position = transform.position;
        //오브젝트 위치 자신의 위치와 동일하게 설정
        transform.SetParent(Container.transform);
        //오브젝트를 자신의 부모로 설정
        gyroCheck = GyroCheck();
    }
    private bool GyroCheck()
    {
        //자이로 기능 탑재 체크 함수
        //자이로센서 지원 여부 체크 후 부모 오브젝트 연동
        if (SystemInfo.supportsGyroscope)
        {
            //SystemInfo.supportGyroscope
            //자이로센서 가능 여부 bool값 반환
            gyro = Input.gyro;
            gyro.enabled = true;

            //부모 오브젝트 기준 로테이선 재설정 후 연동
            //Container.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
            //자이로 센서는 바닥에 두고 북쪽을 기준으로 설정, 정면=x축 기준 90도
            Container.transform.rotation = Quaternion.Euler(10f, 0f, 0f);


            //부모 오브젝트 기준 축 재설정 후 연동
            rot = new Quaternion(0f, 0f, 1f, 0);
            //z축 기준으로 반전
            //1000
            //0100 x
            //0010 y
            //0001 z
            return true;
        }
        return false;
        //자이로 센서 지원 여부 체크
    }

    void Update()
    {
        // y축의 자이로값을 이용하여 동작의 변화를 측정하는 방식으로 스쿼트의 count값을
        // 세려고 했으나 실행할 때마다 값이 달라져 특정 값을 찾을 수 없어 해당 코드 사용X


        /*if (gyroCheck)
        {
            //입력되는 자이로 센서 값 동기화
            transform.localRotation = gyro.attitude * rot;

            text.text = "Gyrosope: " + transform.localRotation; //현재 자이로 값 출력

            //if (gyro.attitude.y < 0.6 && gyro.attitude.y >0)
            if (gyro.attitude.z < 0.7 && gyro.attitude.z > 0)
            {
                count = count + 1;
                textcount.text = "count: " + count;
            }            
        }
        else
        {
            text.text = "Gyroscope:No support";
        }*/
    }

}
