using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{

    GameObject car; // ※車のデータを入れる変数(箱のようなもの)

    GameObject flag; //※旗のデータを入れる変数(箱のようなもの)

    GameObject distance; //※表示する予定のUIを入れる変数(箱のようなもの)

    GameObject countTextOb; //※表示する予定のUIを入れる変数(箱のようなもの)

    TextMeshProUGUI distanceTextUGUI; //※上のUIの中身の特定のデータを入れる変数(箱のようなもの)

    TextMeshProUGUI countText; //※上のUIの中身の特定のデータを入れる変数(箱のようなもの)

    bool dead = false; //落ちたか落ちていないか

    static public bool clear = false;

    int _count = ToriSpriteController.count;

    void Start()  //※ゲームが始まったときに実行されるもの、{}の内容が実行される
    {

        car = GameObject.Find("chicken");  //※車の変数に車のデータを見つけてきて入れてあげる作業

        flag = GameObject.Find("flag"); //※旗の変数に旗のデータを見つけてきて入れてあげる作業

        distance = GameObject.Find("distance"); //※UIの変数にUIのデータを見つけてきて入れてあげる作業

        countTextOb = GameObject.Find("count"); //※UIの変数にUIのデータを見つけてきて入れてあげる作業

        countText = countTextOb.GetComponent<TextMeshProUGUI>(); //※UIの変数にUIの中身の特定のデータを入れる作業

        distanceTextUGUI = distance.GetComponent<TextMeshProUGUI>(); //※UIの変数にUIの中身の特定のデータを入れる作業

    }


    void Update() //※毎フレーム実行されるもの、{}の内容が実行される
    {

        if (car.transform.position.y <= -8)
        {
            Destroy(car);
            dead = true;
        }
        Debug.Log(dead);


        if (_count == 0 && !ToriSpriteController.fly)
        {
            dead = true;
        }

        if (dead)
        {
            distanceTextUGUI.text = "Game Over!!"; //※Game Over!と表示させる
            distanceTextUGUI.color = Color.blue; //※Game Over!を赤にする
            clear = true;
            return;
        }
        _count = ToriSpriteController.count;
       
        countText.text = ($"JUMP:{_count}");

        float length = flag.transform.position.x - car.transform.position.x; //※旗と車の位置を引いて、距離を求めて入れる
        if ((length < 2 && !ToriSpriteController.fly))//※if () の内容が当てはまらない時に、{ }の内容が実行される（それ以外の時ということ）
        {
            if (length >= 0)
            {
                distanceTextUGUI.text = "Clear!!";
                distanceTextUGUI.color = Color.red;
                clear = true;
            }

            if (length < 0)
            {
                dead = true;
            }

        }
        else if (!dead) //※車が旗を越していないか
        {
            if (_count != 3 || ToriSpriteController.fly)
                distanceTextUGUI.text = $"Distance:{length:F2}m";  //※車と旗の距離を表示させる

        }

    }
}
