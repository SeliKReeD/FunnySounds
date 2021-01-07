using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainController : MonoBehaviour
{
    public Transform buttonPanel;
    public GameObject buttonPrefab;
    public int buttonCount;
    public int columns;

    public GridLayoutGroup gridLayoutGroup;
    // Start is called before the first frame update
    void Start()
    {
        float width = this.GetComponent<RectTransform>().rect.width;
        Debug.Log(width);
        gridLayoutGroup.cellSize = new Vector2(width/columns, width/columns);

        for (int i = 0; i < buttonCount; i++)
        {
            GameObject newButton = (GameObject) Instantiate(buttonPrefab);
            newButton.GetComponent<ButtonController>().setId(i);
            newButton.transform.SetParent(buttonPanel, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
