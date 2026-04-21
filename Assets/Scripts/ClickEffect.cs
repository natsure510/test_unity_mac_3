using UnityEngine;
using UnityEngine.UI;

public class ClickEffect : MonoBehaviour
{
    private Color color;
    private SpriteRenderer sr;
    void Start()
    {
        //  x, y, -5 に配置
        //this.transform.Translate(new Vector3(0, 0, -5));
        var tr = this.transform;
        var pos = tr.position;
        tr.position = new Vector3(pos.x, pos.y, -5);
        sr = this.GetComponent<SpriteRenderer>();
        color = sr.color;
        Debug.Log($"pos => {this.transform.position}");
    }

    void Update()
    {
        // 徐々に薄くして消す
        color.a -= Time.deltaTime; // アルファ値を減少させる
        //Debug.Log($"color.a => {color.a}");
        sr.color = color;
        if (color.a <= 0)
        {
            Destroy(this.gameObject); // アルファ値が0以下になったらオブジェクトを破壊
            Debug.Log("Destroyed");
        }
    }
}
