using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefbab������
    public GameObject coinPrefab;
    //cornPrefab������
    public GameObject conePrefab;
    //�X�^�[�g�n�_
    private int startPos = 80;
    //�S�[���n�_
    private int goalPos = 360;
    //�A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;
    //Unity�����̃R���|�[�l���g���擾
    private GameObject unitychan;
    //�Ō�ɃA�C�e���𐶐������Ƃ���unitychan��z���W���i�[����ϐ���p��
    float lastunitychan;


    // Start is called before the first frame update
    void Start()
    {
        unitychan = GameObject.Find("unitychan");

    }


    // Update is called once per frame
    void Update()
    {
     
        //Unity�����̓����ɍ��킹�ăI�u�W�F�N�g��z�u����
       if (unitychan.transform.position.z >=lastunitychan + 15)

        {
            //lastunitychan�Ɍ��݂�unitychan��z���W����

            lastunitychan = unitychan.transform.position.z;


            //�ǂ̃A�C�e�����o���̂��������_���ɐݒ�
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //�R�[����x�������Ɉ꒼���ɐ���
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + 50);
                }

            }
            else
            {

                //���[�����ƂɃA�C�e���𐶐�
                for (int j = -1; j <= 1; j++)
                {
                    //�A�C�e���̎�ނ����߂�
                    int item = Random.Range(1, 11);

                    //�A�C�e����u��z���W�̃I�t�Z�b�g�������_���ɐݒ�
                    int offsetZ = Random.Range(-5, 6);

                    //60%�R�C���z�u�F30%�Ԕz�u�F10%�����Ȃ�
                    if (1 <= item && item <= 6)
                    {
                        //�R�C������
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 50);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //�Ԃ𐶐�
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 50);
                    }
                }
            }

        }

    }
}

