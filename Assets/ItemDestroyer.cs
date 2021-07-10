using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{

    GameObject mainCamObj;

    // Start is called before the first frame update
    void Start()

    {
        mainCamObj = Camera.main.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

        //画面外に出たオブジェクトを削除

        if (this.transform.position.z <= mainCamObj.transform.position.z)

        {
            Destroy(this.gameObject);
        }


    }
}
