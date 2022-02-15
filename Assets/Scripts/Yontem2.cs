using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yontem2 : MonoBehaviour
{
    public static Yontem2 instance;
    public GameObject player;
    public Transform prevObject;
    public float yPos;
    public float newPos;
    public bool finishPad;

    void Start()
    {
        finishPad=false;
        yPos=player.transform.position.y;
        newPos=player.transform.position.y;
    }
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    void Update()
    {
        player.transform.position = new Vector3(transform.position.x,yPos,transform.position.z);
        yPos=Mathf.Lerp(yPos,newPos,0.15f);
        if(newPos<0)
        {
            if(finishPad)
            {
                GameManager.instance.OnLevelCompleted();
            }
            else
            {
                GameManager.instance.OnLevelFailed();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="FinishPad")
        {
            finishPad=true;
        }
        if (other.gameObject.tag=="Pick")
        {
            newPos+=1f;
            other.gameObject.transform.parent = player.transform;
            Vector3 desPos =prevObject.localPosition;
            desPos.x=0;
            desPos.z=0;
            desPos.y=-newPos+0.5f;
            other.gameObject.transform.localPosition = desPos;
            prevObject=other.transform;
        }
    }
}
