using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public static CubeController instance;
    private Touch touch;
    public float speed = 10;
    private float speedModifier;
    public float minCandlePos;
    public float maxCandlePos;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    void Start()
    {
        speedModifier = 0.01f;
        minCandlePos = -4.5f;
        maxCandlePos = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameStarted || GameManager.isGameEnded) // Oyun baslamadiysa veya bittiyse
        {
            return;
        }
        transform.Translate(Vector3.forward * (speed) * Time.deltaTime);// Ileri doğru hareket
        if (Input.touchCount > 0) // Dokunma varsa;
        {
            touch = Input.GetTouch(0); // Degiskeni atama atama

            if (touch.phase == TouchPhase.Moved) // Dokunma basladiginda;
            {
                //Yeni koordinatlar bunlar olsun.
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z);
            }
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,minCandlePos,maxCandlePos),Mathf.Clamp(transform.position.y,0f,200f),transform.position.z);
        
    }
}
