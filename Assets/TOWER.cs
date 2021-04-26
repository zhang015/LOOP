using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOWER : MonoBehaviour
{
    public GameObject hole1;
    public GameObject hole2;
    public GameObject hole1_base;
    public GameObject hole2_base;
    public GameObject hole3_base;

    int pos_hole1;  //穴１の高さ
    int pos_hole2;  //穴２の高さ
    int pos_hole_b; //変更前の高さ
    int rot_hole1;  //穴１の回転
    int rot_hole2;  //穴２の回転

    int MOVE;
    int SPIN;

    int count;  //移動、回転処理カウント

    // Start is called before the first frame update
    void Start()
    {
        MOVE = 0;
        SPIN = 0;
        pos_hole1 = 1;
        pos_hole2 = 2;
        rot_hole1 = 1;
        rot_hole2 = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //穴１の高さ変更
        if (Input.GetKey(KeyCode.J) && MOVE == 0 && SPIN == 0)
        {
            MOVE = 1;
            count = 90;



            //位置を上に移動
            pos_hole1++;

            //上限を超えたら一番下に
            if(pos_hole1 == 4)
            {
                pos_hole1 = 1;
            }
            
            //同じ向きで穴の高さが重なる場合はもう一段進める
            if(pos_hole1 == pos_hole2 && rot_hole1 == rot_hole2)
            {
                pos_hole1++;
            }
            if (pos_hole1 == 4)
            {
                pos_hole1 = 1;
            }




        }

        //穴２の高さ変更
        if (Input.GetKey(KeyCode.K) && MOVE == 0 && SPIN == 0)
        {
            MOVE = 2;
            count = 90;
        }

        //穴１の向き変更
        if (Input.GetKey(KeyCode.U) && MOVE == 0 && SPIN == 0)
        {
            SPIN = 1;
            count = 90;
        }

        //穴２の向き変更
        if (Input.GetKey(KeyCode.I) && MOVE == 0 && SPIN == 0)
        {
            SPIN = 2;
            count = 90;
        }
    }

    void FixedUpdate()
    {
        if (count > 0)
        {
            if (MOVE == 1)
            {

            }

            if(SPIN == 1)
            {

            }

            count--;
        }

    }
}
