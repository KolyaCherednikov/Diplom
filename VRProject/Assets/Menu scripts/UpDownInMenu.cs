using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownInMenu : MonoBehaviour
{
    public GameObject prefabular;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UPButton()
    {
        if (prefabular.transform.GetSiblingIndex() != 0)
        {
            Debug.LogError(prefabular.transform.GetSiblingIndex());
            prefabular.transform.SetSiblingIndex(prefabular.transform.GetSiblingIndex() - 1);
        }
    }

    public void DownButton()
    {
        Debug.LogError(prefabular.transform.GetSiblingIndex());
        prefabular.transform.SetSiblingIndex(prefabular.transform.GetSiblingIndex() + 1);
    }

    public void DeleteButton()
    {
        Destroy(prefabular);
    }
}
