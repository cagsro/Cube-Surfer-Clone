using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScaler : MonoBehaviour
{
    public static CubeScaler instance;
    public GameObject Piece1;
    public GameObject Piece2;
    public GameObject Piece5;
    public GameObject Piece3;
    public GameObject Piece6;
    public GameObject Piece9;
    public GameObject Piece11;
    public bool FinishPad;
    public float pos;
    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        FinishPad=false;
        pos=0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetCube1()
    {
        this.transform.localScale += Vector3.up; // Y ekseninde yukselme islemi
    }
    public void GetCube5()
    {
        this.transform.localScale += Vector3.up*5; // Y ekseninde yukselme islemi
    }
    public void Barrier1()
    {
        if(this.transform.localScale.y <= 1f&& !FinishPad)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        if(this.transform.localScale.y <= 1f&&FinishPad)
        {
            GameManager.instance.OnLevelCompleted();
            return;
        }
        SpawnPiece1(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 1f; // Kisalma islemi
        if(FinishPad)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y+1f,transform.position.z);
            pos+=1f;
        }
    }
    public void Barrier2()
    {
        if(this.transform.localScale.y <= 2f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece2(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 2f; // Kisalma islemi
    }
    public void Barrier3()
    {
        if(this.transform.localScale.y <= 3f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece3(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 3f; // Kisalma islemi
    }
    public void Barrier5()
    {
        if(this.transform.localScale.y <= 5f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece5(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 5f; // Kisalma islemi
    }
    public void Barrier6()
    {
        if(this.transform.localScale.y <= 6f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece6(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 6f; // Kisalma islemi
    }
    public void Barrier9()
    {
        if(this.transform.localScale.y <= 9f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece9(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 9f; // Kisalma islemi
    }
    public void Barrier11()
    {
        if(this.transform.localScale.y <= 11f)
        {
            GameManager.instance.OnLevelFailed();
            return;
        }
        SpawnPiece11(); //Arkada parca birakma islemi
        this.transform.localScale -= Vector3.up * 6f; // Kisalma islemi
    }
    public void SpawnPiece1()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,pos,this.transform.position.z);
        Instantiate(Piece1, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece2()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,1f,this.transform.position.z);
        Instantiate(Piece2, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece3()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,1.5f,this.transform.position.z);
        Instantiate(Piece3, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece5()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,2.5f,this.transform.position.z);
        Instantiate(Piece5, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece6()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,3f,this.transform.position.z);
        Instantiate(Piece6, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece9()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,4.5f,this.transform.position.z);
        Instantiate(Piece9, PiecePos, Quaternion.identity);
    }
    public void SpawnPiece11()
    {
        var PiecePos= new Vector3(CubeController.instance.transform.position.x,5.5f,this.transform.position.z);
        Instantiate(Piece11, PiecePos, Quaternion.identity);
    }
}
