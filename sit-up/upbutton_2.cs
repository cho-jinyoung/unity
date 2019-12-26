using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  //씬 이동에 필요한 패키지

public class upbutton_2 : MonoBehaviour //윗몸 일으키기 2번 버튼 
{
    // Start is called before the first frame update
    public UnityEngine.UI.Scrollbar obj_scrollbar_;

    int count = 0;  //count값을 세기 위한 변수
    public Text countText;  //text출력을 위한 변수 

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
        count = count + 1;
        countText.text = "Count:" + count;  //2번 버튼을 누를때마다 카운트값 1증가 출력 
        Debug.Log("2");
        //SceneManager.LoadScene("arm_back");  //씬 이동
    }
}