using System.Collections.Generic;
using UnityEngine;

public class seadTarget : MonoBehaviour
{
    public List<Collider2D> targetList = new List<Collider2D>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Field"))
        {
            targetList.Add(collision);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        targetList.Remove(collision);
    }
}