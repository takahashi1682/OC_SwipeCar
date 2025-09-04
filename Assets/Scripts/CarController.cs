using UnityEngine;

public class CarController : MonoBehaviour
{
    //GameObject flag; //※旗のデータを入れる変数(箱のようなもの)

    //public float speed = 0f; //※初速度を入れる変数(箱のようなもの)

    //Vector2 startPos; //※鳥がいる位置を入れる変数(箱のようなもの)

    //public float swipeLength; //距離を求める

    void Start()
    {
        //Application.targetFrameRate = 60; //※ゲームのフレームレートを60に固定にする設定

        //this.flag = GameObject.Find("flag"); //※旗の変数に旗のデータを見つけてきて入れてあげる作業
    }

    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{
        //    this.startPos = Input.mousePosition; // ※クリックをした時の座標をstartPosに入れる
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{

        //    Vector2 endPos = Input.mousePosition; // ※クリックを離した時の座標をendPosに入れる

        //    swipeLength = endPos.x - startPos.x; // ※クリックを離した時の座標 - クリックした時の座標

        //    float length = flag.transform.position.x - transform.position.x; // ※旗と車の位置を引いて、距離を求めて入れる

        //    if (swipeLength < 0 || GameDirector.clear || ToriSpriteController.fly)
        //    {
        //        return; //  ※もし、車が旗を越している、または後ろにスワイプした場合は、処理をここでストップ
        //    }

        //    speed = swipeLength / 1500.0f; // ※スワイプの長さ↑を初速度に変換する

        //    GetComponent<AudioSource>().Play(); //※効果音再生
        //}


        //transform.Translate(speed, speed, 0); // ※Xにspeedの値分、移動する

        //if (speed <= 0.05)
        //{
        //    speed = 0f;
        //}

        //speed *= 0.98f; // ※初速度に0.98をかけることで、だんだんと減速させる
    }
}

