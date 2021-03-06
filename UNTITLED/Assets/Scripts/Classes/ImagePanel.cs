﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ImagePanel : MonoBehaviour
{
    private Texture2D LoadTexture(string path)
    {
        Texture2D tex;
        byte[] FileData;

        if (File.Exists(path))
        {
            FileData = File.ReadAllBytes(path);
            tex = new Texture2D(1, 1);
            if (tex.LoadImage(FileData))
                return tex;
        }
        return null;
    }

    public Sprite LoadSprite(string path, float pixelsPerUnit = 100.0f)
    {
        Sprite sprite;
        Texture2D texture = LoadTexture(path);
        sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0), pixelsPerUnit);

        return sprite;
    }

    public void SetImage(string path)
    {
        Sprite panelImage = LoadSprite(path);

        if (!panelImage) Debug.Log("FILE ERROR No file at path \"" + path + "\"");

        transform.GetChild(1).GetComponent<Image>().sprite = panelImage;
        transform.GetChild(1).GetComponent<Image>().preserveAspect = true;
    }
}
