using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {
    public Image Image;
    private Color[] colors;
    private System.Random rnd = new System.Random();

    void Start() {
        colors = new Color[] { Color.red, Color.blue, Color.green, Color.magenta };
        Image.GetComponent<Image>().color = colors[0];
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Image.GetComponent<Image>().color = colors[rnd.Next(colors.Length)];
        }
    }
}
