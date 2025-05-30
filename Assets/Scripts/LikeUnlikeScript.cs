using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LikeUnlikeScript : MonoBehaviour
{
    [SerializeField] private Sprite likeSprite, unlikeSprite;
    [SerializeField] private ParticleSystem particals;
    [SerializeField] private ScriptableObjects postData;
    [SerializeField] private TextMeshProUGUI numberOfLikes;
    public void OnButtonClick()
    {
        Button likeButton = GetComponent<Button>();
        if (likeButton.image.sprite == likeSprite)
        {
            likeButton.image.sprite = unlikeSprite;
            int postlikes = int.Parse(postData.likes);
            numberOfLikes.text = postlikes + " likes";
            Debug.Log("no of likes = " + numberOfLikes);
        }
        else
        {
            likeButton.image.sprite = likeSprite;
            int postlikes = int.Parse(postData.likes);
            numberOfLikes.text = postlikes + 1 + " likes";
            Debug.Log("no of likes = " + numberOfLikes);
            particals.Play();

        }
    }

}
