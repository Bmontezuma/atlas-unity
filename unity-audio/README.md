# Unity Audio Project Documentation

## Table of Contents
1. [Project Overview](#project-overview)
2. [Tasks and Implementation Details](#tasks-and-implementation-details)
   - [Task 0: Sound Check](#task-0-sound-check)
   - [Task 1: Click](#task-1-click)
   - [Task 2: Background Music](#task-2-background-music)
   - [Task 3: Footsteps](#task-3-footsteps)
   - [Task 4: Landing Sounds](#task-4-landing-sounds)
   - [Task 5: Level Background Music](#task-5-level-background-music)
   - [Task 6: Victory Fanfare](#task-6-victory-fanfare)
   - [Task 7: Ambient Sounds](#task-7-ambient-sounds)
   - [Task 8: Pausing Muffles Music](#task-8-pausing-muffles-music)
   - [Task 9: BGM Volume Control](#task-9-bgm-volume-control)
   - [Task 10: SFX Volume Control](#task-10-sfx-volume-control)
   - [Task 11: Add Music to Other Levels](#task-11-add-music-to-other-levels)
   - [Task 12: Final Builds](#task-12-final-builds)
3. [Testing and Final Adjustments](#testing-and-final-adjustments)
4. [References and Resources](#references-and-resources)

---

## Project Overview

This project implements a comprehensive audio experience within a Unity platformer game, incorporating background music, sound effects for interactions, ambient sounds, and audio feedback across multiple levels and scenes. The setup includes background music, environmental effects, UI interactions, and adjustable volume settings, all managed through a central audio mixer for streamlined control.

**Repository**: [GitHub repository: atlas-unity](https://github.com/yourusername/atlas-unity)  
**Directory**: `unity-audio`

---

## Tasks and Implementation Details

### Task 0: Sound Check
**Objective**: Set up basic UI sound effects for menu interactions, ensuring an engaging experience when navigating the main menu.

**Steps**:
1. Created a GameObject named `MenuSFX` and attached `button-rollover.ogg` as a child.
2. Added `button-rollover` sound effect to all menu buttons (Level Select, Options, Exit).
3. Configured hover audio for all buttons, confirming sound plays on mouse hover.

**Files**:
- **Main Menu Scene**: `Assets/Scenes/MainMenu.unity`
- **Audio File**: `Assets/Audio/SFX/UI/button-rollover.ogg`

---

### Task 1: Click
**Objective**: Add a click sound to buttons for user feedback on selection.

**Steps**:
1. Attached `button-click.ogg` to `MenuSFX` as a child.
2. Configured the sound to play on all button clicks.
3. Saved `MenuSFX` as a prefab and updated OptionsButton and ExitButton prefabs with sound effects.

**Files**:
- **Audio File**: `Assets/Audio/SFX/UI/button-click.ogg`

---

### Task 2: Background Music
**Objective**: Add looping background music to the Main Menu with a mixer group for volume control.

**Steps**:
1. Added `Wallpaper.mp3` to the Main Menu, set to play on load.
2. Created `MasterMixer` with an Audio Mixer Group named `BGM`.
3. Set the BGM levels to 0.00dB and configured the background music to loop.

**Files**:
- **Audio File**: `Assets/Audio/BGM/Wallpaper.mp3`
- **Mixer**: `Assets/Audio/MasterMixer.mixer`

---

### Task 3: Footsteps
**Objective**: Add looping footstep sounds that vary based on the surface type (grass or stone) in Level01.

**Steps**:
1. Configured `footsteps_running_grass` and `footsteps_running_rock` to play based on surface type.
2. Synced sounds with player animation to match footfall timing.
3. Created an Audio Mixer Group named `Running` with a -20.00dB level and added terrain-specific filters.

**Files**:
- **Audio Files**: `Assets/Audio/SFX/Player/footsteps_running_grass.wav`, `Assets/Audio/SFX/Player/footsteps_running_rock.wav`

---

### Task 4: Landing Sounds
**Objective**: Add a landing sound effect for when the player lands on different surfaces after jumping or falling.

**Steps**:
1. Added `footsteps_landing_grass` and `footsteps_landing_rock` sounds.
2. Configured sounds to trigger upon landing on respective surfaces.
3. Created an Audio Mixer Group named `Landing` with a 2.00dB level for impact sounds.

**Files**:
- **Audio Files**: `Assets/Audio/SFX/Player/footsteps_landing_grass.wav`, `Assets/Audio/SFX/Player/footsteps_landing_rock.wav`

---

### Task 5: Level Background Music
**Objective**: Add and control background music for Level01, allowing it to stop when the player reaches specific objectives.

**Steps**:
1. Configured `CheeryMonday.mp3` to play at level start and stop at WinFlag or MainMenu.
2. Set the music’s Audio Mixer Group to `BGM` and enabled looping.

**Files**:
- **Audio File**: `Assets/Audio/BGM/CheeryMonday.mp3`

---

### Task 6: Victory Fanfare
**Objective**: Play a victory sound effect upon reaching the WinFlag in Level01, pausing background music during playback.

**Steps**:
1. Added `VictoryPiano.wav` as a win sting that triggers upon reaching WinFlag.
2. Configured background music to pause when the victory sound begins.

**Files**:
- **Audio File**: `Assets/Audio/BGM/VictoryPiano.wav`

---

### Task 7: Ambient Sounds
**Objective**: Add ambient sounds, such as birds and crickets, that grow louder as the player approaches.

**Steps**:
1. Added bird sounds to trees and cricket sounds to grass/flower objects.
2. Configured proximity-based volume adjustments.
3. Created an Audio Mixer Group named `Ambience` with a default level of 5.00dB.

**Files**:
- **Audio Files**: `Assets/Audio/SFX/birds.wav`, `Assets/Audio/SFX/crickets.mp3`

---

### Task 8: Pausing Muffles Music
**Objective**: Use Snapshots to muffle background music when the game is paused.

**Steps**:
1. Configured Snapshot settings within `MasterMixer` to muffle BGM.
2. Set up a toggle to switch between normal and muffled settings when the game pauses or resumes.

**Files**:
- **Mixer**: `Assets/Audio/MasterMixer.mixer`

---

### Task 9: BGM Volume Control
**Objective**: Create a slider in the Options menu to adjust background music volume.

**Steps**:
1. Added `BGMSlider` in `OptionsMenu.cs` to control BGM volume.
2. Configured values to persist across scenes and game restarts.

**Files**:
- **Script**: `Assets/Scripts/OptionsMenu.cs`

---

### Task 10: SFX Volume Control
**Objective**: Create a slider for SFX volume, allowing adjustment of button and ambient sounds.

**Steps**:
1. Added `SFXSlider` to control volume of SFX sounds, including UI and ambient effects.
2. Configured values to save and persist across sessions.

**Files**:
- **Script**: `Assets/Scripts/OptionsMenu.cs`

---

### Task 11: Add Music to Other Levels
**Objective**: Implement BGM in Level02 and Level03 with respective soundtracks.

**Steps**:
1. Set up `PorchSwingDays` as BGM for Level02 and `BrittleRille` for Level03.
2. Used `MasterMixer` for BGM management across all levels.

**Files**:
- **Audio Files**: `Assets/Audio/BGM/PorchSwingDays.mp3`, `Assets/Audio/BGM/BrittleRille.mp3`

---

### Task 12: Final Builds
**Objective**: Prepare and export builds for Mac, Windows, and Linux, verifying functionality.

**Build Setup**:
1. Included scenes: MainMenu, Options, Level01, Level02, Level03.
2. Configured platform-specific folders in `Builds` directory with required structure.
3. Created ZIP files for each build and uploaded to Google Drive.

**Testing**:
Tested builds on each platform, verifying sound interactions, menu functionality, and scene transitions.

---

## Testing and Final Adjustments

Throughout the project, each audio interaction was tested to confirm accurate trigger responses and sound quality. Adjustments to mixer settings, ambient volume, and proximity-based sounds were refined based on these tests to enhance user experience.

---

## References and Resources

- **Kenney Assets**: [Kenney.nl](https://kenney.nl/)
- **Oculus Audio Pack**: [Oculus Developer](https://developer.oculus.com/downloads/package/oculus-audio-pack-1/)
- **Mindful Audio**: [Mindful Audio](https://mindful-audio.com/)
- **Kevin MacLeod**: "Wallpaper" and "Cheery Monday" by Kevin MacLeod (incompetech.com)  
  Licensed under Creative Commons: [By Attribution 3.0](http://creativecommons.org/licenses/by/3.0/)
