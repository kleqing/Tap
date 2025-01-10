using System;
using UnityEngine;

public class Beans : MonoBehaviour
{
    [SerializeField] private Transform Peashooter;

    private void Update()
    {
        transform.localScale = Peashooter.localScale;
    }
}
