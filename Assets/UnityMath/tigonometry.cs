using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���α׷��� �⺻ �̷�(���� ����)
public class tigonometry : MonoBehaviour
{
    // ���� ���п��� �ַ� �ٷ�� �͵�
    // 1. �ﰢ �Լ�
    // 2. ��ǥ
    // 3. ����
    // 4. ���
    // 5. �����
    // 6. �

    // 1-1. �ﰢ�Լ�
    // ����(sin A)    a / h
    // -> ������ angle �̶�� �Ҷ� h�� ������ ������ sin�̶�� ������
    // -> h�� ���̿� ������ �˰� �ִٸ� h�� ���� * sin angle�� ���� ���� ���� ���ϱ� ����
    // ����Ƽ���� ��ǥ���� y

    // �ڻ���(cos A)   b / h
    // -> h�� cos angle�� ���� b ��� ����(����Ƽ���� ��ǥ���� x)

    // ź��Ʈ(tan A)   a / b

    // �ﰢ�Լ� ��� ���� : ���� ������ ����, ��ä�� ������ ����, ������ ��ǥ ���
    // ������ ���� ���� ����ϱ�, �� ���� ������ ���� ����ϱ�(������ ����)

    // �ڡڡ� ����(radian) : ȣ��
    // ���а� ���α׷��� �о߿��� ������ ��Ÿ���� ����

    // ��� �� �� ���� ���� ������ �߽����� �������� ���̸�ŭ
    // �� �������� ���������� �����ϴ� ���� ũ�⸦ 1 ���� �̶�� ������
    // �Ϲ����� ����(Degree) �� 60���� 1 �������� ���� ����
    // ��� ���� : �������� ǥ���ϴ°� ���̸� �̿��� ���������� ǥ���ϴ°� ���� ������
    
    // Mathf.Deg2Rad�� ���� ������ �������� ����

    private void Start()
    {
        float angle = 45; // ����
        Debug.Log(Mathf.Sin(angle * Mathf.Deg2Rad));
        // ����Ƽ ������ �ﰢ�Լ��� ����� �� �ִ� ������ ���� ����
        Debug.Log(Mathf.Cos(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Tan(angle * Mathf.Deg2Rad));

        // ����Ƽ sin, cos �Լ����� h�� 1�� ������
        // ���� sin�� cos�� ������ ����

        Vector2 vector2;
        vector2.x = Mathf.Cos(angle * Mathf.Deg2Rad);
        vector2.y = Mathf.Sign(angle * Mathf.Deg2Rad);

        // x�� �ﰢ���� �غ�(b)
        // y�� �ﰢ���� ����(a)

        // ���� ������ 1�̰� ������ 45���� �ﰢ���� �������� ��ġ�� �ľ��� ����
    }

    private void Update()
    {
        /*Vector2 vector2;
        vector2.x = Mathf.Cos(Time.time * 360 *  Mathf.Deg2Rad);
        vector2.y = Mathf.Sin(Time.time * 360 *  Mathf.Deg2Rad);
        transform.position = vector2;*/
    }
}
