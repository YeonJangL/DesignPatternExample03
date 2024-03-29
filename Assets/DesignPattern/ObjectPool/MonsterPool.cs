using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool : MonoBehaviour
{
    // [무한 생성기의 경우]
    // 1. Update 문으로 구현
    // 2. Coroutine 을 이용한 설계(반드시 start 함수가 있어야함)

    public GameObject MonsterPrefab; // 몬스터 프리팹에 대한 값
    public int PoolSize; // 풀로 생성할 유닛의 개수
    public float spawnTime; // 몬스터 젠(생성) 시간

    GameObject[] monsterPool; // 몬스터에 대한 배열 (몬스터 풀)

    GameObject monsterSpawnPool;

    // Start is called before the first frame update
    void Start()
    {
        monsterSpawnPool = new GameObject("MonsterSpawnPool");

        // 풀에서 설정된 사이즈 만큼 오브젝트를 배열에 할당함
        monsterPool = new GameObject[PoolSize];

        // 할당한 배열만큼 생성 진행
        Spawn(monsterPool, PoolSize);

        // 특정 시간마다 몬스터가 생성될 수 있도록 코루틴 작동
        StartCoroutine("MonsterPooling");
    }

    private void Spawn(GameObject[] monsterPool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            monsterPool[i] = Instantiate(MonsterPrefab); // 몬스터 프리팹 생성
            monsterPool[i].name = "Monster_" + i; // 생성 몬스터 이름 넣기
            monsterPool[i].transform.parent = monsterSpawnPool.transform; // 풀을 부모로 등록

            // 비활성화 처리
            monsterPool[i].SetActive(false);
        }
    }

    IEnumerator MonsterPooling()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            for (int i = 0; i < PoolSize; i++)
            {
                // 활성화가 되어있는 상태라면 이 작업은 건너 뜀
                if (monsterPool[i].activeSelf == true)
                {
                    continue;
                }

                float x = Random.Range(-5, 5);
                float y = Random.Range(-5, 5); // 3D로 생성을 짜는 경우라면 x, z 축으로 설계

                monsterPool[i].transform.position = new Vector2(x, y);
                // 3D 일 경우에는 Vector3

                // 활성화 작업 진행
                monsterPool[i].SetActive (true);
                break;
            }
        }
    }
}
