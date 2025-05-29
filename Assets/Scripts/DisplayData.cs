using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Username, username2, likes;
    [SerializeField] private Image postImage;
    [SerializeField] private ScriptableObjects postData;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            Username.text = postData.username;
            username2 = Username;
            postImage.sprite = postData.postImage;
            likes.text = postData.likes;
            Debug.Log("post one is updated");
        
       




    }
}
