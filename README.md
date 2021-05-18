# UnityVirtualCamDemos
A collection of demos that shows how to use VirtualCam prefab for Unity

Any scene of this project can run successfully alone.

This project contains these scenes:

 - SampleARScene: runs in mobile phone with AR setting.  Shares the view from the ARCamera.
 - SampleMinScene: runs in any platform (including Editor). Shares any assigned camera.

## Prerequisites

 - Agora Account and App IDs (tokens optional)
 - Unity 2019 LTS (Recommended) and up
 - [Agora Unity SDK](https://assetstore.unity.com/packages/tools/video/agora-video-sdk-for-unity-134502) v3.x.x

## How to Run
- set your AppID and token (optional) to AgoraVirtualCamera game object in the scene.
- check Join/Leave/Microphone/Quit button set up on AgoraVirtualCamera
- hit Play for Editor and check the shared camera view on a different device using [Agora WebDemo app](https://webdemo.agora.io/agora-web-showcase/examples/Agora-Web-Tutorial-1to1-Web/) or another Agora app (e.g. Unity Demo) using the same AppId and Channel information.
- For AR demo on mobile devices, following the standard Unity ARFoundation package set up.  Also read the README file from Agora Video SDK for configuration recommendations.

![SampleMinScene_-_VirtualCamSample](https://user-images.githubusercontent.com/1261195/118602946-2e86cc80-b768-11eb-88e9-7d2b05a9a9ca.png)


## Help Resources

- You can find full API document at Document Center
- VirtualCamPrefab repo: https://github.com/AgoraIO-Community/Unity-Virtual-Camera-Prefab

## License
The MIT License (MIT).
