using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move : MonoBehaviour   //MonoBehaviour=클래스
{
    Vector3 position;

    int speed = -5;
    void Start()
    {
        position = transform.position; 
    }
    void Update()
    {
        position.z += Time.deltaTime * speed;   //z축 이동
        transform.position = position;  //변경한 위치로 현재위치 변경 
    }
}

//시도했던 코드 참고 
    /*public Vector3 tposition = new Vector3(0,0,0);  //위치를 변수에 할당

    int speed = 5;
    void Update()   //지속적으로 발생하는 이동->매 프레임당 한번 (start는 시작될 때 한번)
    {
        //transform.position = tposition;    //할당한 위치를 현재 게임오브젝트의 위치로 적용
        float fMove = Time.deltaTime * speed;
        transform.Translate(Vector3.forward * fMove);
    }*/

    /*/// <summary>The red box will use Lerp to move. We will link
    /// this object in via the inspector.</summary>
    public GameObject lerpObject;
    /// <summary>The starting position for our red box.</summary>
    public Vector3 lerpStart = new Vector3(0, 0, 0);
    /// <summary>The end position for our red box.</summary>
    public Vector3 lerpTarget = new Vector3(-15, 0, 0);

    /// <summary>The blue box will use LerpUnclamped to move. We will 
    /// link this object in via the inspector.</summary>
    public GameObject lerpUnclampedObject;
    /// <summary>The starting position for our blue box.</summary>
    public Vector3 lerpUnclampedStart = new Vector3(0, 3, 0);
    /// <summary>The end position for our blue box.</summary>
    public Vector3 lerpUnclampedTarget = new Vector3(-15, 3, 0);

    /// <summary>The current fraction to increment our lerp functions by.</summary>
    public float lerpFraction = 0;

    private void Update()
    {
        // First, I increment the lerp fraction. 
        // delaTime * 0.25 should give me a value of +1 every second.
        lerpFraction += (Time.deltaTime * 0.25f);

        // Next, we apply the new lerp values to the target transform position.
        lerpObject.transform.position
            = Vector3.Lerp(lerpStart, lerpTarget, lerpFraction);
        lerpUnclampedObject.transform.position
            = Vector3.LerpUnclamped(lerpUnclampedStart, lerpUnclampedTarget, lerpFraction);
    }*/
