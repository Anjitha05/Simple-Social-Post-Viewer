# Simple-Social-Post-Viewer
This Unity project is a minimalistic social media post viewer, displaying 3 posts with dummy data. The project includes like/dislike functionality, a particle effect when liked, and a scrollable post feed.

Features
- 3 posts with dummy data (username, photo, caption, and likes).
- Like button that changes between like & dislike.
- Likes & dislikes count .
- Particle system effect plays when post is liked.
- Scrollable post layout.
- Uses ScriptableObjects for dummy data.

Technologies Used
- Unity 2022.3.58f1
- C# Scripting
- Unity UI System
- ScriptableObjects 
- Particle System 

Scripts
ScriptableObjects (PostData.cs) containing:
- Username
- Post Image
- Caption
- Likes count
Post data is fetched by DisplayData.cs to populate UI.
 LikeDislikeScript.cs handles:
- change sprite between Like/Dislike.
- Updating like/dislike count dynamically.
- Playing a particle effect when liked.
UI is scrollable, allowing the user to navigate posts.
