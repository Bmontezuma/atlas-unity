# ***About The Developer!***
![](https://scontent-dfw5-1.xx.fbcdn.net/v/t39.30808-1/346989429_899462764451875_7538672357379803910_n.jpg?stp=dst-jpg_s200x200&_nc_cat=101&ccb=1-7&_nc_sid=0ecb9b&_nc_ohc=frOqNWGVNvkQ7kNvgEIe_HX&_nc_zt=24&_nc_ht=scontent-dfw5-1.xx&_nc_gid=A552ze1rtKoGxWORGAK6SWf&oh=00_AYDCJBv_MMqnpous-IytSoY_xD3b5nL2bAJIM4qQDmxwLw&oe=6728B011)
***"I've had a passion for video game development since childhood, inspired by the Atari, TurboGrafix 16, Nintendo systems, Sega Saturn, and every console in between. Life took me in a different direction for a while—parenthood took priority, and I paused on my dreams to focus on family. My son’s birth was the most important part of my life, and I knew supporting him meant everything. I found my way back through modding for games like Borderlands, creating custom weapons, shields, and relics, and reigniting the excitement for game creation. Now that both of my sons are older, I’m able to focus again on game development with renewed wisdom and purpose. Check out my LinkedIn, Some of my work on Artstation, or explore my projects on GitHub."***

Repo:[atlas-unity](https://github.com/Bmontezuma/atlas-unity/tree/main)


Directory:[unity-audio](https://github.com/Bmontezuma/atlas-unity/tree/main/unity-audio)

# Platformer Project

![gif]([https://s3.eu-west-3.amazonaws.com/hbtn.intranet/uploads/medias/2019/12/c1dfd96eea8cc2b62785.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIA4MYA5JM5DUTZGMZG%2F20241031%2Feu-west-3%2Fs3%2Faws4_request&X-Amz-Date=20241031T003626Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=1fb92ee1e410e975ab1ed7410b56c4e27646c9813c56218ffacc951ad9307092](https://scontent-dfw5-1.xx.fbcdn.net/v/t39.30808-6/449526513_1421746988539635_8392174129364370833_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=127cfc&_nc_ohc=oprmVtuHgEIQ7kNvgEUf9Kc&_nc_zt=23&_nc_ht=scontent-dfw5-1.xx&_nc_gid=AC54vf8n02RpelGknmhn5nH&oh=00_AYCAweB01Z-JibOkm1AuVaey83Nl-muCYCgfqYT9Q-jWbg&oe=67291F5C))

This platformer game provides an immersive experience with dynamic audio, environmental soundscapes, and responsive controls. Each level has unique background music, ambient sounds that change with the player's proximity, and responsive sound effects based on the player's actions and interactions with various surfaces.

## Project Details

### Scenes

- **MainMenu**: This is the starting screen where players can select levels, access options, and exit the game. It includes the following audio feedback:
  - Button rollover and click sounds for menu navigation.
  - **Background Music (BGM)**: "Wallpaper," which loops until the player loads a level.
  
- **Options**: The Options scene allows players to adjust sound settings.
  - **BGMSlider**: Adjusts background music volume from muted to max. The settings persist across scenes and game sessions.
  - **SFXSlider**: Controls sound effect volume, which includes ambient sounds and UI button sounds. The volume settings also persist across scenes and sessions.

- **Level01**: This is the first level where the player is introduced to audio-based interaction.
  - **Background Music**: "Cheery Monday," which loops and stops when the player touches the WinFlag or returns to the MainMenu.
  - **Footstep Sounds**: Different footstep sounds play depending on the terrain, matching the player’s animation.
  - **Landing Sounds**: Sound effects trigger based on the terrain when the player lands after a fall.
  - **Ambient Sounds**: Birds chirping in trees and crickets near rocks, with audio volume increasing as the player approaches.
  - **Snapshot Effect**: Background music becomes muffled when the game is paused, enhancing the immersive feel.

- **Level02**: This level features the following:
  - **Background Music**: "Porch Swing Days" loops and stops when the player completes the level or exits to the MainMenu.
  
- **Level03**: The final level includes:
  - **Background Music**: "Brittle Rille" as a looping track, stopping when the level ends or the player returns to the MainMenu.

### Audio Setup

- **Master Mixer**: Contains Audio Mixer Groups for BGM, Running, Landing, and Ambience, each with specific dB levels and filters to match the game's environment.
  - **BGM**: Background music is set to 0.00dB by default.
  - **Running**: Footsteps audio, with a default level of -20.00dB and filters for fitting each terrain.
  - **Landing**: Landing sounds, with a default level of 2.00dB, are configured to provide a robust, impactful sound.
  - **Ambience**: Ambient sounds, such as birds and crickets, set to 5.00dB, fade based on player proximity.

### Builds

The game is available in three builds:
- **Linux (x86_64)**
  - `Platformer_Linux_x86_64.zip`
- **Mac**
  - `Platformer_Mac.zip`
- **Windows (x86_64)**
  - `Platformer_Windows_x86_64.zip`

Each build includes all five scenes (MainMenu, Options, Level01, Level02, and Level03) in the following folder hierarchy:

Builds ├── Linux │ └── Platformer_Data │ └── Platformer.x86_64 ├── Mac │ └── Platformer.app └── Windows ├── Platformer_Data ├── Platformer.exe └── UnityPlayer.dll



![](https://camo.githubusercontent.com/1b7f4bf64cd32a6ad678d96e7ecbf33e5db878a6bb9340930845e77fa413b2cc/68747470733a2f2f7265732e636c6f7564696e6172792e636f6d2f6465627869777462712f696d6167652f75706c6f61642f76313733303332373538362f657a6769662e636f6d2d766964656f2d746f2d6769662d636f6e7665727465725f325f78786f69696b2e676966)
Directory:[unity_ar_business_card](https://github.com/Bmontezuma/atlas-unity/tree/main/unity_ar_business_card)

# AR Business Card Project

This project creates an interactive and dynamic augmented reality (AR) business card that appears when viewed through a device camera. The AR business card includes contact details, social media links, and custom animations, all anchored to an AR-identifiable marker.

## Project Overview

In this AR experience, your business card layout appears when the device detects a unique AR marker. The card contains interactive buttons and animations, creating a memorable way for others to connect with you. This project leverages Vuforia for marker detection, Unity for 3D layout and animations, and scripts to make links clickable.

### Features

1. **Static Layout**: The business card is designed in Unity as a 3D scene, `ARBusinessCard.unity`, and includes:
   - **Your Name**
   - **Job Title**
   - **Four Links** (as text or buttons):
     - Email
     - Website / GitHub
     - Twitter
     - LinkedIn
   - **Visual Design**: Icons and logos were sourced to make the layout visually appealing and easy to navigate.

2. **Marker-Based Display**:
   - The layout is activated when the AR marker is detected and anchored to the marker.
   - Elements adapt to the marker's position, distance, and angle relative to the device camera.
   - If the marker is not visible, all elements disappear, ensuring a clean user experience.

3. **Interactive Links**:
   - Each link on the business card is fully interactive.
   - When tapped, links open their respective apps or websites directly from the AR interface.
   - Accessibility guidelines were taken into account, with legible text and appropriately sized buttons for easy navigation.

4. **Animation and Feedback**:
   - The layout includes dynamic animations to enhance the AR experience, making use of AR's visual strengths.
   - Buttons provide visual and audible feedback (e.g., color changes, clicks, or beeps) when pressed, ensuring a responsive and accessible UI/UX.

## Project Setup

### Repository and Directory Structure

- **GitHub Repository**: [atlas-unity](https://github.com/Bmontezuma/atlas-unity/tree/main)
- **Directory**: [unity_ar_business_card](https://github.com/Bmontezuma/atlas-unity/tree/main/unity_ar_business_card)
- **Main Scene**: [Assets/Scenes/ARBusinessCard.unity](https://github.com/Bmontezuma/atlas-unity/tree/main/unity_ar_business_card/Assets/Scenes)

### Build Information

Two builds are included to make the AR business card accessible on both iOS and Android devices.

- **Builds Folder Structure**:
Builds ├── iOS │ └── [Build files] └── Android ├── ARBusinessCard.apk


- **Build Files**:
- [unity-ar_business_card-iOS.zip](https://drive.google.com/file/d/1O5qBP602dS_8EGkIil_cTfQDhbxxN9EN/view)
- [unity-ar_business_card-Android.zip](https://drive.google.com/file/d/1bSny8aVxdNMvF1PbR4rE9DWeRIwIv7EH/view)

**Download Links**:  
- [iOS Build (.zip)](https://example-link-ios.zip)
- [Android Build (.zip)](https://example-link-android.zip)

## Requirements

- **Unity** with Vuforia Engine integrated
- **Compatible AR Device** (iOS or Android)
- **AR Marker** for detection

## Setup Instructions

1. **Marker Setup**: Upload your chosen marker to Vuforia’s Target Manager, ensuring high recognition accuracy.
2. **Build and Test**:
 - Export builds for both iOS and Android platforms.
 - Test the APK and iOS files to confirm functionality on both platforms or your preferred device.
3. **Deployment**: Once tested, upload the build files to a platform like Google Drive or Dropbox for easy sharing.

## Acknowledgments

This project integrates Vuforia for AR tracking, Unity for 3D and animation design, and various online resources for button icons and audio clips.


## ***Special Thanks***


[Kenney](https://kenney.nl)
[Oculus Audio Pack:](https://developer.oculus.com/downloads/package/oculus-audio-pack-1)\
[Mindful Audio:](https://mindful-audio.com) “Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)\
[Licensed under Creative Commons](`http://creativecommons.org/licenses/by/3.0)




