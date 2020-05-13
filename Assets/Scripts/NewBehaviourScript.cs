using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public static NewBehaviourScript instance = null;
    public float speed = 3;
    public Vector3 ax;
    public Vector3 yx;
    int i = 0;
    private void Awake()
    {
        instance = this;
    }

    //인스턴스는 무언가 있다고 보장을 해줄때 쓴다.


    // Start is called before the first frame update
    void Start()
    {
        ax = new Vector3(1, 0, 0);
        yx = new Vector3(0, 1, 0);

        Debug.Log(Vector3.Dot(ax, yx));
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0.003f, 0, Space.World);

        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.02f, 0, 0, Space.World);
        }
    */

        Debug.Log("그냥포재션: "+transform.position);
        Debug.Log("로컬포재션: "+transform.localPosition);
        transform.Translate(speed * Time.deltaTime,0,0);
        //로컬은항상바뀌지않음
    }
}



