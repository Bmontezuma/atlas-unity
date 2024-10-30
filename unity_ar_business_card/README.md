# ***Unity - AR Business Card***

# ***Meet the Developer***
[Pic](https://res.cloudinary.com/debxiwtbq/image/upload/v1730329185/20230831_075518_z88ljk.jpg)
"***I've had a passion for video game development since childhood, inspired by the Atari, TurboGrafix 16, Nintendo systems, Sega Saturn, and every console in between. Life took me in a different direction for a while—parenthood took priority, and I paused on my dreams to focus on family. My son’s birth was the most important part of my life, and I knew supporting him meant everything. I found my way back through modding for games like Borderlands, creating custom weapons, shields, and relics, and reigniting the excitement for game creation. Now that both of my sons are older, I’m able to focus again on game development with renewed wisdom and purpose. Check out my [LinkedIn](https://www.linkedin.com/in/brandon-montezuma/), Some of my work on [Artstation](https://www.artstation.com/brandonmontezuma6), or explore my projects on [GitHub](https://github.com/Bmontezuma).***"


## Background Context
Welcome to an exciting project that will explore the world of Augmented Reality (AR). We’ll be utilizing **Vuforia**, a powerful AR software development kit (SDK), to make your business card come alive. Starting from **Unity 2017.2**, Vuforia has been integrated into Unity and supports development for iOS, Android, and Windows. This integration provides a seamless workflow and a host of powerful tools to create AR experiences.

Throughout this project, you will gain a firm grasp of **marker-based augmented reality** and understand the process of choosing or creating images optimized for target detection. You’ll learn to track an image using Vuforia and, finally, design an interactive environment that layers onto your business card.

Upon completion, you will have a solid understanding of **AR development using Vuforia and Unity**, enabling you to create augmented reality experiences that blur the lines between the physical and digital world.

Are you ready to augment your reality?

## Technical Description
This project focuses on the following key areas:

1. **Understanding Vuforia**  
   - Learn about the advantages and disadvantages of Vuforia.
   - Understand the concept of marker-based augmented reality.

2. **Image Optimization for Target Detection**  
   - Learn how to choose or create images optimized for target detection.

3. **Image Tracking with Vuforia**  
   - Learn how to track an image using Vuforia and Unity.

4. **AR Environment Design**  
   - Understand the principles of designing for an augmented reality environment.

> **Note**: Ensure you are using **Unity 2022.3.x LTS**. For this project, you will need to register for a free development license for Vuforia.

**Important**: The use of free or paid script assets from the Unity Asset Store or elsewhere is prohibited. Focus on creating your own scripts that interact with Unity’s AR components.

The final product of this project will be an **interactive AR business card**.

## Resources

### Core:
- **Getting Started with Vuforia Engine in Unity**
- **Optimizing Target Detection and Tracking Stability**

### Suggested:
- **Unity: World Space Canvas**
- **Vuforia: Unity API Reference**

### Supplementary:
- **UI / UX in AR / VR**

## Learning Objectives
By the end of this project, you should be able to explain the following concepts without assistance:

- What is Vuforia, and what are its advantages and disadvantages?
- What is marker-based augmented reality?
- How to choose or create images optimized for target detection.
- How to track an image using Vuforia.
- How to publish applications for both Android and iOS with Vuforia.
- How to design for an augmented reality environment.

## Requirements

### General
- Include a `README.md` file at the root of the project folder.
- Use Unity’s default `.gitignore` in your `holbertonschool-unity` directory.
- Push the entire project folder, `unity-ar_business_card`, to your repository.
- Organize scenes and project assets (e.g., Scripts) as specified in the tasks.
- In your scripts:
  - Document all public classes and their members with XML documentation tags.
  - Document all private classes and members, without using XML documentation tags.


# Tasks

## 0. Let's see Paul Allen's card


In this project, you will create a business card for yourself with an AR-identifiable printed marker. You can use the following image or create your own. If you create your own, you must upload it in the form below.

Create a static layout for the business card in a 3D Unity scene called `ARBusinessCard`. We strongly suggest you sketch out your business card layout (as well as storyboarding its subsequent animation for Task #2) before opening up Unity. Your layout must include:
- Your name
- Job title
- At least four links, in text or button form:
  - Email
  - Website / GitHub
  - Twitter
  - LinkedIn
  - Or any other link or social media you want to use to promote yourself

**Repo**:  
- GitHub repository: `atlas-unity`
- Directory: `unity_ar_business_card`
- File: `0-layout`

---

## 1. Target acquired
![Gif](https://res.cloudinary.com/debxiwtbq/image/upload/v1730327586/ezgif.com-video-to-gif-converter_chp3eh.gif)

![Gif](https://media.giphy.com/media/E3hJAZO1IBSzS/giphy.gif)

Set up a target image database in Vuforia’s Target Manager and set up your AR marker such that your business card layout appears when your device’s camera detects the marker.

The layout should be anchored to the marker, and the layout’s transform values should change depending on the marker’s angle, pose, and distance in relation to the device’s camera. If the marker is not visible, all elements of the business card should disappear.

**Repo**:  
- GitHub repository: [atlas-unity](https://github.com/Bmontezuma/atlas-unity)
- Directory: [unity_ar_business_card](https://github.com/Bmontezuma/atlas-unity/tree/main/unity_ar_business_card)
- File: [Assets/Scenes/ARBusinessCard.unity](https://github.com/Bmontezuma/atlas-unity/tree/main/unity_ar_business_card/Assets/Scenes)

---

## 2. Animated reality
![Gif](https://res.cloudinary.com/debxiwtbq/image/upload/v1730327586/ezgif.com-crop_l2yttr.gif)


Add animations to your layout. The design and feel of the experience are up to you, but keep in mind the overall user experience (text should be legible, buttons should be large enough to press individually, etc.).

Be dynamic and play to the strengths of the AR medium — animation is key!

**Repo**:  
- GitHub repository: `atlas-unity`
- Directory: `unity_ar_business_card`
- File: `Assets/Scenes/ARBusinessCard.unity`

---

## 3. Social link up
![Gif](https://res.cloudinary.com/debxiwtbq/image/upload/v1730327586/ezgif.com-crop_l2yttr.gif)

Script the links to be interactive. When they are pressed on the device screen, they should open the associated link or app. The buttons should also give some kind of visual or audible feedback when pressed, such as the button changing color or a sound like a beep or click. Keep in mind accessibility guidelines in your UI/UX decisions!

**Repo**:  
- GitHub repository: `atlas-unity`
- Directory: `unity_ar_business_card`
- File: `Assets/Scenes/ARBusinessCard.unity`

---

## 4. Building cards
![Gif](https://res.cloudinary.com/debxiwtbq/image/upload/v1730327586/ezgif.com-video-to-gif-converter_2_xxoiik.gif)

Scenes in Build:
- `ARBusinessCard`

Create two builds of the business card scene in the `Builds` directory.

### Build Folder Hierarchy:
- `Builds`
  - `iOS`
    - [Build files]
  - `Android`
    - `ARBusinessCard.apk`

Make sure to run your build and verify it works! Test on all platforms if possible, but at least test on your own device.

### Create a .zip of each build:
- `unity-ar_business_card-iOS.zip`
- `unity-ar_business_card-Android.zip`

Upload the two .zip files to Google Drive or Dropbox and add the links below.

- **Links**:
  - [iOS Build](https://drive.google.com/file/d/1bSny8aVxdNMvF1PbR4rE9DWeRIwIv7EH/view?usp=drive_link)
  - [Android Build](https://drive.google.com/file/d/1O5qBP602dS_8EGkIil_cTfQDhbxxN9EN/view?usp=drive_link)

**Repo**:  
- GitHub repository: `atlas-unity`
- Directory: `unity_ar_business_card`
- File: `Assets/Scenes/ARBusinessCard.unity`
