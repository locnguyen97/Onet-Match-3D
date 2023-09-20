using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject real;
    // Start is called before the first frame update
    void Start()
    {
        real.SetActive(false);
    }

    public void Show()
    {
        real.SetActive(true);
    }
}
