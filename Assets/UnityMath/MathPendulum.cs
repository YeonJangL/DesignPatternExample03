using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPendulum : MonoBehaviour
{
    public float angle; // ���� ǥ��

    private float time = 0; // �ð�
    private float speed = 2.0f; // �ӵ�

    private void Update()
    {
        time += Time.deltaTime * speed;
        transform.rotation = MovePendulum();
        // ������ ������ z���� 1���� -1���� �̵��ϴ� �۾��� �ݺ���
    }

    // ���� ��� ���� �Լ� ����
    Quaternion MovePendulum() => Quaternion.Lerp(Quaternion.Euler(Vector3.forward * angle), Quaternion.Euler(Vector3.back * angle), LerpT());

    // ���Ϸ� �� (Euler)
    // Transform ������Ʈ�� Rotation ���� �� ���� ����(Degree)�� �����Ǿ� ����
    // 3���� �࿡ ���� ȸ�� ������ ǥ���� ���� ���Ϸ� ���̶�� ������
    // ���Ϸ� ���� ���� ��ġ�� ��Ȳ���� ���� 3���� �ƴ� 2������ ���� ���ɼ��� ������(���� �� ����)

    // z -> x -> z ������ ���Ϸ� ���� ó���ϰ��� ��

    // �� ����� ������ ������ �������� ���� ���� ��
    // RX =     1       0       0
    //          0       cos     -sin
    //          0       sin     cos

    // Rz =     cos     -sin    0
    //          sin     cos     0
    //          0       0       1   

    // RzRxRz = cos     -sin    0       1       0       0       cos     -sin    0
    //          sin     cos     0       0       cos     -sin    sin     cos     0
    //          0       0       1       0       sin     cos     0       0       1

    // ���Ϸ� ���� ���� a, b, c ��� ����

    //      cos(a + c)      -sin(a +c)      0
    //      sin(a + c)      cos(a + b)      0
    //          0               0           1   

    // �� �̵��� �����ϸ� ��ġ�� ������ �߻���


    // Lerp(a, b, t) �Լ��� t�� ���� ����ϴ� �Լ�
    // Lerp�� a �������� b �������� �ε巴�� t �������� �̵�
    float LerpT() => (Mathf.Sin(time) + 1) * 0.5f;
}
