using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCardImage : MonoBehaviour
{
    private string _url = "https://picsum.photos/140/130";
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
        StartCoroutine(LoadFromLink());
    }

    private IEnumerator LoadFromLink()
    {
        WWW loader = new WWW(_url);

        yield return loader;

        Texture2D texture = new Texture2D(140, 130);
        loader.LoadImageIntoTexture(texture);
        _image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one / 2);
    }
}
