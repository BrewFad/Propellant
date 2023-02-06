using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public void OnClick() 
    {
        level1.SetActive(true);
        level2.SetActive(true);
        level3.SetActive(true);
        gameObject.SetActive(false);
    }
}
