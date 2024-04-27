using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiUpdater : MonoBehaviour
{

    public TextMeshProUGUI textMesh;
    public TMP_Dropdown dropdown;



    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = 
            "<color=#FF0000>SBS ����Ƽ ���� ����</color> \n �����Դϴ�.";

        dropdown.onValueChanged.AddListener((t) =>
        {
            
            Debug.Log(dropdown.options[t].text);
        });
    }


}
