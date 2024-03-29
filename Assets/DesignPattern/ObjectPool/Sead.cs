using System.Collections;
using UnityEngine;

public class Sead : MonoBehaviour
{
    // 클릭할때만 씨앗 심기
    private void OnMouseDown()
    {
        gameObject.SetActive(true);
    }
}