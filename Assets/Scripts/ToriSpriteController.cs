using UnityEngine;

public class ToriSpriteController : MonoBehaviour
{
    [SerializeField] Sprite[] Tatisprite = new Sprite[3];
    [SerializeField] Sprite[] Tobisprite = new Sprite[3];
    float fps = 0.05f;
    SpriteRenderer Renderer;
    float tatiTime = 0;
    float tobuTime = 0;
    int tatiIdx = 1;
    int tobiIdx = 1;
    int tatinum = 1;
    int tobinum = 1;
    public int count = 3;
    static public bool fly;

    void Start()
    {

        Renderer = GetComponent<SpriteRenderer>();
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
