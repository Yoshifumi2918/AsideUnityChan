using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefbabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    //Unityちゃんのコンポーネントを取得
    private GameObject unitychan;
    //最後にアイテムを生成したときのunitychanのz座標を格納する変数を用意
    float lastunitychan;


    // Start is called before the first frame update
    void Start()
    {
        unitychan = GameObject.Find("unitychan");

    }


    // Update is called once per frame
    void Update()
    {
     
        //Unityちゃんの動きに合わせてオブジェクトを配置する
       if (unitychan.transform.position.z >=lastunitychan + 15)

        {
            //lastunitychanに現在のunitychanのz座標を代入

            lastunitychan = unitychan.transform.position.z;


            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + 50);
                }

            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);

                    //アイテムを置くz座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);

                    //60%コイン配置：30%車配置：10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コイン生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 50);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 50);
                    }
                }
            }

        }

    }
}

