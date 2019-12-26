
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  //씬 이동에 필요한 패키지

public class backbutton : MonoBehaviour
{
    public UnityEngine.UI.Scrollbar obj_scrollbar_; //unity상의 scrollbar 선언  

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
        for (float value = 0.0f; value < 1.0f; value += 0.01f)
        {
            obj_scrollbar_.size = value;
            yield return new WaitForEndOfFrame();
        }
        obj_scrollbar_.size = 1.0f;
        Debug.Log("버튼 동작 처리");
        SceneManager.LoadScene("buttonmenu");  //메뉴화면으로 씬 이동(=뒤로가기)

    }
}
