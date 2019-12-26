using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

//윗몸 일으키기 1번 버튼
//1번 버튼은 그냥 버튼의 모양만 있음 
public class upbutton_1 : MonoBehaviour  
{
    // Start is called before the first frame update
    public UnityEngine.UI.Scrollbar obj_scrollbar_;

    public void PointEnter()    //scrollbar에 들어갈 때
    {
        StartCoroutine(TimeToAction()); //scrollbar안에 들어가면 timetoaction실행 
    }
    public void PointExit()     //시점이 버튼에서 벗어날 때
    {
        obj_scrollbar_.size = 0;    //scrollbar의 게이지를 0으로 설정해 시점이 벗어남 처리
        StopAllCoroutines();        //coroutine메서드 멈춤
    }


    IEnumerator TimeToAction()
    {
        //0.01씩 값을 올리면서 화면 갱신, 1.0이 된 후 '버튼 동작 처리' 로그 출력
        for (float value = 0.0f; value < 1.0f; value += 0.03f)
        {
            obj_scrollbar_.size = value;
            yield return new WaitForEndOfFrame();
        }
        obj_scrollbar_.size = 1.0f;

        Debug.Log("1"); 
    }
}


