using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game : MonoBehaviour
{
    public GameObject[] Rows;
    public GameObject Board;
    public GameObject WinDialog;
    public int lines;
    public GameObject guard;
    public GameObject woman;

    //when mouse button is clicked, it will call this function
    void Update()
    {
        GameObject Pieces1 ;
        GameObject Pieces2 ;
        GameObject Pieces3 ;
        lines = 0;
        for(int i = 0;  i < Rows.Length; i++)
        {
            Pieces1 = Rows[i].transform.GetChild(0).GetChild(0).gameObject;
            Pieces2 = Rows[i].transform.GetChild(1).GetChild(0).gameObject;
            Pieces3 = Rows[i].transform.GetChild(2).GetChild(0).gameObject;

            if(Pieces1.CompareTag("PieceW") && Pieces2.CompareTag("PieceW") && Pieces3.CompareTag("PieceW"))
            {
                lines++;
            }
            if(Pieces1.CompareTag("PieceB") && Pieces2.CompareTag("PieceB") && Pieces3.CompareTag("PieceB"))
            {
                lines++;
            }
            checkWin();
            
        }
        // for(int i=0; i < Rows.Length; i++)
        // {
        //     GameObject Pieces1 = Rows[0].transform.GetChild(i).GetChild(0).gameObject;
        //     GameObject Pieces2 = Rows[1].transform.GetChild(i).GetChild(0).gameObject;
        //     GameObject Pieces3 = Rows[2].transform.GetChild(i).GetChild(0).gameObject;
        //     check(Pieces1, Pieces2, Pieces3);
        // }

        Pieces1 = Rows[0].transform.GetChild(2).GetChild(0).gameObject;
        Pieces2 = Rows[3].transform.GetChild(2).GetChild(0).gameObject;
        Pieces3 = Rows[7].transform.GetChild(2).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        Pieces1 = Rows[0].transform.GetChild(1).GetChild(0).gameObject;
        Pieces2 = Rows[1].transform.GetChild(1).GetChild(0).gameObject;
        Pieces3 = Rows[2].transform.GetChild(1).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);
        Pieces1 = Rows[5].transform.GetChild(1).GetChild(0).gameObject;
        Pieces2 = Rows[6].transform.GetChild(1).GetChild(0).gameObject;
        Pieces3 = Rows[7].transform.GetChild(1).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        checkWin();
        Pieces1 = Rows[1].transform.GetChild(0).GetChild(0).gameObject;
        Pieces2 = Rows[3].transform.GetChild(2).GetChild(0).gameObject;
        Pieces3 = Rows[6].transform.GetChild(0).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        Pieces1 = Rows[2].transform.GetChild(0).GetChild(0).gameObject;
        Pieces2 = Rows[3].transform.GetChild(2).GetChild(0).gameObject;
        Pieces3 = Rows[5].transform.GetChild(0).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        Pieces1 = Rows[2].transform.GetChild(2).GetChild(0).gameObject;
        Pieces2 = Rows[4].transform.GetChild(0).GetChild(0).gameObject;
        Pieces3 = Rows[5].transform.GetChild(2).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        Pieces1 = Rows[0].transform.GetChild(2).GetChild(0).gameObject;
        Pieces2 = Rows[4].transform.GetChild(2).GetChild(0).gameObject;
        Pieces3 = Rows[7].transform.GetChild(2).GetChild(0).gameObject;
        check(Pieces1, Pieces2, Pieces3);

        checkWin();
    }

    public void check(GameObject Pieces1, GameObject Pieces2, GameObject Pieces3){
        if(Pieces1.CompareTag("PieceW") && Pieces2.CompareTag("PieceW") && Pieces3.CompareTag("PieceW"))
        {
            lines++;
            
        }
        if(Pieces1.CompareTag("PieceB") && Pieces2.CompareTag("PieceB") && Pieces3.CompareTag("PieceB"))
        {
            lines++;
        }
    }
    public void changText(string text)
    {
        Debug.Log(lines);
    }

    public void checkWin(){
        if(lines>=2){
            Board.SetActive(false);
            WinDialog.SetActive(true);
        }
    }

    public void dissmiss()
    {
        WinDialog.SetActive(false);
        guard.SetActive(false);
        woman.SetActive(true);
    }
}
