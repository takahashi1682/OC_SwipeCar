using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{

    //GameObject car; // ※車のデータを入れる変数(箱のようなもの)

    //GameObject flag; //※旗のデータを入れる変数(箱のようなもの)

    //GameObject distance; //※表示する予定のUIを入れる変数(箱のようなもの)

    //GameObject countTextOb; //※表示する予定のUIを入れる変数(箱のようなもの)

    //TextMeshProUGUI distanceTextUGUI; //※上のUIの中身の特定のデータを入れる変数(箱のようなもの)

    //TextMeshProUGUI countText; //※上のUIの中身の特定のデータを入れる変数(箱のようなもの)

    //bool dead = false; //落ちたか落ちていないか

    //bool fly;

    //static public bool clear = false;

    //int _count;


    //void Start()  //※ゲームが始まったときに実行されるもの、{}の内容が実行される
    //{
    //    SceneManager.sceneLoaded += SceneLoadOn;

    //    car = GameObject.Find("chicken");  //※車の変数に車のデータを見つけてきて入れてあげる作業

    //    flag = GameObject.Find("flag"); //※旗の変数に旗のデータを見つけてきて入れてあげる作業

    //    distance = GameObject.Find("distance"); //※UIの変数にUIのデータを見つけてきて入れてあげる作業

    //    countTextOb = GameObject.Find("count"); //※UIの変数にUIのデータを見つけてきて入れてあげる作業

    //    countText = countTextOb.GetComponent<TextMeshProUGUI>(); //※UIの変数にUIの中身の特定のデータを入れる作業

    //    distanceTextUGUI = distance.GetComponent<TextMeshProUGUI>(); //※UIの変数にUIの中身の特定のデータを入れる作業

    //    _count = car.GetComponent<ToriSpriteController>().count;

    //}


    //void Update() //※毎フレーム実行されるもの、{}の内容が実行される
    //{
    //    _count = car.GetComponent<ToriSpriteController>().count;
    //    fly = ToriSpriteController.fly;

    //    if (car.transform.position.y <= -8)
    //    {
    //        Destroy(car);
    //        dead = true;
    //    }
    //    Debug.Log(dead);


    //    if (_count == 0 && !fly)
    //    {
    //        dead = true;
    //    }

    //    if (dead)
    //    {
    //        countText.text = "Game Over!!"; //※Game Over!と表示させる
    //        countText.color = Color.blue; //※Game Over!を赤にする
    //        clear = true;
    //        return;
    //    }

    //    countText.text = ($"JUMP:{_count}");

    //    float length = flag.transform.position.x - car.transform.position.x; //※旗と車の位置を引いて、距離を求めて入れる

    //    if (!dead) //※車が旗を越していないか
    //    {
    //            distanceTextUGUI.text = $"Distance:{length:F2}m";  //※車と旗の距離を表示させる

    //    }

    //    if ((length < 2 && !fly))//※if () の内容が当てはまらない時に、{ }の内容が実行される（それ以外の時ということ）
    //    {
    //        if (length >= 0)
    //        {
    //            countText.text = "Clear!!";
    //            countText.color = Color.red;
    //            clear = true;
    //        }

    //        if (length < 0)
    //        {
    //            dead = true;
    //        }

    //    }
  
    //}

    //public void Restart()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}

    //void SceneLoadOn( Scene scene, LoadSceneMode mode)
    //{
    //    clear = false;
    //}
}
