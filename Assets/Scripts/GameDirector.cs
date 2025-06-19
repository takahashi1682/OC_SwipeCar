using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{

    //GameObject car;  ※車のデータを入れる変数(箱のようなもの)

    //GameObject flag;　※旗のデータを入れる変数(箱のようなもの)

    //GameObject distance;　※表示する予定のUIを入れる変数(箱のようなもの)

    //TextMeshProUGUI distanceTextUGUI;　※上のUIの中身の特定のデータを入れる変数(箱のようなもの)


    //void Start()  ※ゲームが始まったときに実行されるもの、{}の内容が実行される

    //{

    //this.car = GameObject.Find("car_0");  ※車の変数に車のデータを見つけてきて入れてあげる作業

    //this.flag = GameObject.Find("flag_0");　※旗の変数に旗のデータを見つけてきて入れてあげる作業

    //this.distance = GameObject.Find("distance");　※UIの変数にUIのデータを見つけてきて入れてあげる作業

    //distanceTextUGUI = distance.GetComponent<TextMeshProUGUI>();　※UIの変数にUIの中身の特定のデータを入れる作業

    //}


    //void Update() ※毎フレーム実行されるもの、{}の内容が実行される
    //{

    //float length = flag.transform.position.x - car.transform.position.x;　※旗と車の位置を引いて、距離を求めて入れる

    //if (length >= 0 )　※車が旗を越していないか
    //{

    //distanceTextUGUI.text = $"Distance:{length:F2}m";  ※車と旗の距離を表示させる

    //}

    //else　※if()の内容が当てはまらない時に、{}の内容が実行される（それ以外の時ということ）
    //{

    //distanceTextUGUI.text = "Game Over!!";　※Game Over!と表示させる

    //}

    //}
}
