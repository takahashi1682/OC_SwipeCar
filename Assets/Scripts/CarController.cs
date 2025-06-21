using UnityEngine;

public class CarController : MonoBehaviour
{

    //GameObject flag;　※旗のデータを入れる変数(箱のようなもの)

    //float speed = 0f;  ※初速度を入れる変数(箱のようなもの)

    //Vector2 startPos;　　※車がいる位置を入れる変数(箱のようなもの)

    //void Start()  ※ゲームが始まったときに実行されるもの、{}の内容が実行される

    //{

    //Application.targetFrameRate = 60;  ※ゲームのフレームレートを60に固定にする設定

    //this.flag = GameObject.Find("flag_0");　※旗の変数に旗のデータを見つけてきて入れてあげる作業

    //}


    //void Update() 　※毎フレーム実行されるもの、{}の内容が実行される
    //{

    //※if()は、もし～の時に実行するという意味、その後に{}の内容が実行される
    //if (Input.GetMouseButtonDown(0))  ※もし左クリックが押された時
    //   {

    //    this.startPos = Input.mousePosition;  ※クリックした時の座標をstartPosに入れる

    //    }

    //else if (Input.GetMouseButtonUp(0))  ※もし左クリックが離された時
    //   {


    //    Vector2 endPos = Input.mousePosition;  ※クリックを離した時の座標をendPosに入れる

    //    float swipeLength = endPos.x - this.startPos.x; 　※クリックを離した時の座標 - クリックした時の座標

    //    float length = flag.transform.position.x - transform.position.x;  ※旗と車の位置を引いて、距離を求めて入れる

    //    if(swipeLength < 0 || length < 0)  ※もし、車が旗を越している、または後ろにスワイプした場合は、処理をここでストップ
    //       {

    //           return;

    //       }

    //    this.speed = swipeLength / 1500.0f;  ※スワイプの長さ↑を初速度に変換する

    //    GetComponent<AudioSource>().Play();　　※効果音再生

    //    }

    //transform.Translate(speed,0,0);　※Xにspeedの値分、移動する

    //speed *= 0.98f;  ※初速度に0.98をかけることで、だんだんと減速させる
    //}
}
