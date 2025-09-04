using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ToriSpriteController : MonoBehaviour
{
    AsyncOperationHandle<Sprite> Handle;
    Sprite[] Tatisprite = new Sprite[3];
    Sprite[] Tobisprite = new Sprite[3];
    float fps = 0.05f;
    SpriteRenderer Renderer;
    CarController Car;
    Rigidbody2D rb;
    float tatiTime = 0;
    float tobuTime = 0;
    int tatiIdx = 1;
    int tobiIdx = 1;
    int tatinum = 1;
    int tobinum = 1;
    static public int count = 3;
    static public bool fly;

    void Start()
    {
        Set();
        Renderer = GetComponent<SpriteRenderer>();
        Car = GetComponent<CarController>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Set()
    {
        Addressables.LoadAssetAsync<Sprite>("taiki01").Completed += sprite =>
        {
            Tatisprite[0] = sprite.Result;
        };
        Addressables.LoadAssetAsync<Sprite>("taiki02").Completed += sprite =>
        {
            Tatisprite[1] = sprite.Result;
        };
        Addressables.LoadAssetAsync<Sprite>("taiki03").Completed += sprite =>
        {
            Tatisprite[2] = sprite.Result;
        };

        Addressables.LoadAssetAsync<Sprite>("jump01").Completed += sprite =>
        {
            Tobisprite[0] = sprite.Result;
        };
        Addressables.LoadAssetAsync<Sprite>("jump02").Completed += sprite =>
        {
            Tobisprite[1] = sprite.Result;
        };
        Addressables.LoadAssetAsync<Sprite>("jump03").Completed += sprite =>
        {
            Tobisprite[2] = sprite.Result;
        };

    }
    void Update()
    {
        SpAnimation();
    }

    void SpAnimation()
    {
        if (!fly)
        {
            tatiTime += Time.deltaTime;
            if (tatiTime >= fps)
            {
                tatiTime = 0;
                if (tatiIdx == Tatisprite.Length - 1)
                    tatinum = -1;
                else if (tatiIdx == 0)
                    tatinum = 1;
                tatiIdx += tatinum;
            }
            Renderer.sprite = Tatisprite[tatiIdx];
        }
        else if (fly)
        {
            tobuTime += Time.deltaTime;
            if (tobuTime >= fps)
            {
                tobuTime = 0;
                if (tobiIdx == Tobisprite.Length - 1)
                    tobinum = -1;
                else if (tobiIdx == 0)
                    tobinum = 1;
                tobiIdx += tobinum;
            }
            Renderer.sprite = Tobisprite[tobiIdx];

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        fly = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        fly = true;
        count--;
    }

}
