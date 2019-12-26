using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  //씬 이동에 필요한 패키지

 //squat content에서 count값을 세기 위한 script
 //모든 squat틀의 각 버튼에 추가해줘야 함 
public class countbutton : MonoBehaviour   
{
    // Start is called before the first frame update
    public UnityEngine.UI.Scrollbar obj_scrollbar_;

    public static int count = 0;    //다른 cs파일에서도 사용할 수 있도록 static으로 변수 선언 
    public Text textcount;

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

        Debug.Log("count1");
        count = count + 1;
        textcount.text = "count: " + count; //현재 count값 출력 
    }
}
