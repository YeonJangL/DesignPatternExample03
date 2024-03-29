using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern01 : MonoBehaviour
{
    // ��ä�� ��� �߻� ���
    public GameObject BulletPrefab; // �Ѿ� ������

    // Update is called once per frame
    private void Update()
    {
        FireSector();
    }

    int cnt = 0;

    private void FireSector()
    {
        var bullet = Instantiate(BulletPrefab);

        Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();

        Vector2 dir = new Vector2(Mathf.Cos(Mathf.PI * cnt), -1);

        rbody.AddForce(dir * 3, ForceMode2D.Impulse);
        // normalized�� ���� ����ȭ ����
        // ForceMode2D.Impulse�� ���� ���������� ���� ����

        cnt++;
    }
}
