using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

    void Start()
    {
        //placeholder texture
        Texture2D level = new Texture2D(6,6);
        for (int i = 0; i < level.height; i++)
            for (int j = 0; j < level.width; j++)
                level.SetPixel(i, j, Color.white);

        //load the level with placeholder texture
        LoadLevel(level);
    }

    public void LoadLevel(Texture2D levelLayout)
    {
        int width = levelLayout.width;
        int height = levelLayout.height;

        for(int y = -height / 2; y <= height / 2; y++)
        {
            for(int x = -width / 2; x <= width / 2; x++)
            {
                Debug.Log(x + "," + y);
            }
        }
    }

    //TODO
    public void DestoryLevel()
    {

    }
}
