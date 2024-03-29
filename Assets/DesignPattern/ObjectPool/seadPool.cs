using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seadPool : MonoBehaviour
{
    public GameObject SeadPrefab;
    public int PoolSize;
    public float spawnTime;
    public Text warnningtext;

    public GameObject grownSeadPrefab;
    public float growTime = 5.0f;

    GameObject[] seadpool;

    GameObject seadSpawnPool;

    // Start is called before the first frame update
    void Start()
    {
        seadSpawnPool = new GameObject("SeadSpawnPool");

        seadpool = new GameObject[PoolSize];

        Spawn(seadpool, PoolSize);

        StartCoroutine("SeadPooling");
    }

    private void Spawn(GameObject[] seadpool, int PoolSize)
    {
        for (int i = 0; i < PoolSize; i++)
        {
            seadpool[i] = Instantiate(SeadPrefab);
            seadpool[i].name = "apple" + i;
            seadpool[i].transform.parent = seadSpawnPool.transform;

            seadpool[i].SetActive(true);
        }
    }

    IEnumerator SeadPooling()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            for (int i = 0;i < PoolSize; i++)
            {
                if (seadpool[i].activeSelf == true)
                {
                    continue;
                }

                seadpool[i].SetActive(false);
                break;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlantSead();
        }
    }

    public void PlantSead()
    {
        foreach (Collider2D target in GetComponent<seadTarget>().targetList)
        {
            GameObject plantsead = GetplantseadPool();

            if (plantsead != null)
            {
                plantsead.transform.position = target.transform.position;
                plantsead.SetActive(true);
                StartCoroutine(GrowSead(plantsead));
            }
        }
    }

    private GameObject GetplantseadPool()
    {
        foreach (GameObject sead in seadpool)
        {
            if (!sead.activeSelf)
            {
                return sead;
            }
        }
        return null;
    }

    IEnumerator GrowSead(GameObject sead)
    {
        yield return new WaitForSeconds(growTime);

        if (sead != null)
        {
            SeadImage seadImages = sead.GetComponent<SeadImage>();
            if (seadImages != null)
            {
                seadImages.Grow(); // 다음 자라는 단계의 이미지로 변경
            }
        }
    }
}
