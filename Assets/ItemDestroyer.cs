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

        //��ʊO�ɏo���I�u�W�F�N�g���폜

        if (this.transform.position.z <= mainCamObj.transform.position.z)

        {
            Destroy(this.gameObject);
        }


    }
}
