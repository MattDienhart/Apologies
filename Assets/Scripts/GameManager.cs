using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Token;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void CreateTokens(int numberOfTokens)
    {
        for (int i = 0; i < numberOfTokens; i++)
        {
            Canvas = GameObject.Find("Canvas");
            GameObject token = Instantiate(Token, new Vector2((i*150), 0), Quaternion.identity);
            token.GetComponent<Transform>().SetParent(Canvas.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
