using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Detector))] // ������ Ÿ���� ������� ����
public class DetectFront : Editor
{
    // GUI ȯ�濡�� ó���� ����� �ۼ��ϴ� ��ġ
    private void OnSceneGUI()
    {
        // Ÿ���� �����ͷ� ����
        Detector detector = (Detector)target;

        // �ڵ��� �� red �� ����
        Handles.color = Color.red;

        Handles.DrawLine(detector.transform.position, detector.transform.forward * 2.0f, 3.0f);

        // �ڵ��� ���� �������� ��ġ���� �� �������� 2��ŭ ���� �׸� ����� 3

        Handles.color = Color.green;
        // �ڵ� �� �ʷ����� ����

        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * 0.5f) * detector.radius); // ������
        Handles.DrawLine(Vector3.zero, (AngleDirection(detector.angle) * -1 * 0.5f) * detector.radius); // ����

        // Handles.DrawWireArc(detector.transform.position, detector.transform.up, Vector3.up, 360.0f, detector.radius);

        // Vector3.up�� ���� �κ�(ȣ)
        // detector�� ��ġ�� �߾� ��ġ
        // up�� ���� ����(� �����̳� ����� ���⳪ ��簢�� ǥ���� �� �ش� �����̳� ��鿡 ������ ����)
    }

    Vector3 AngleDirection(float angle) => new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), Mathf.Cos(angle * Mathf.Deg2Rad), 0);
}
