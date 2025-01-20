# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),  
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## **Changelog - [1.0.0] (2025-01-20)** 🎉 *Initial Release*

### **✨ New Features**

- **Flag:** Added an endpoint to the room, marking the end of a level.
- **Mute/Unmute Sound:** Implemented sound toggle functionality in both the menu and pause menu.
- **Prefabs:** Introduced various prefabs for developers to quickly create new levels or extend functionality.

### **🔧 Bug Fixes**

- **Game Freeze on Restart:** Resolved an issue where the game would freeze upon restarting. [#5](https://github.com/kleqing/Tap/issues/5)
- **Pause/Unpause Issue:** Fixed a bug where the player couldn't move after resuming the game. [#4](https://github.com/kleqing/Tap/issues/4)
- **Player Friction:** Fixed the player getting stuck on objects when touching edges. [#3](https://github.com/kleqing/Tap/issues/3)
- **Background Music (BGM):** Fixed an issue where music would replay unnecessarily upon restarting or transitioning to a new scene.

### **🐛 Known Issues**

- **No known issues** at the moment. Everything seems to be working as expected.

### **🔮 Coming Soon**

- **Level 2:** Development of an entirely new level is underway (the current Level 2 is just a duplicate of Level 1).  
- **Additional Traps:** Idk which type of trap I should make next:D

## [0.1.1] - 2025-01-16

### 🎉 Added

- **Enemies:**
  - **Saw Trap:** A new trap that moves along a path to hinder the player's progress toward their destination.
- **Level Completion:**
  - **Level 1:** The first level is now complete and ready for the transition to Level 2.

### 🔧 Fixed

- **Player Double Jump:** Resolved an issue where the player could jump multiple times instead of the intended double jump. [#1](https://github.com/kleqing/Tap/issues/1)
- **Screen Resolution:** Adjusted settings to ensure the game runs correctly on all screen resolutions. (This issue was present in earlier 0.0.x versions but is now resolved.)

### 🐛 Known Issues

- **Menu Alignment:** The arrow icons in the pause and game-over menus remain misaligned with the corresponding text. (Fix pending for a future update.)

### 🔮 Coming Soon

- **Menu Screen Sound:** Background music or sound effects for the menu screen.
- **Level 2:** Development of a new level.
- **Additional Traps:** Idk which type of trap I should make next:D


## [0.1.0] - 2025-01-14

### 🚀 Milestone
- After 6 versions of updates, the game is nearly ready for release! 🎉

---

### 🎉 Added

- **Enemies:**
  - **Spike Head:** A new enemy that attacks the player when detected.
- **Main Menu (Startup Screen):** Added a polished main menu for a smoother start to the game.

### 🐞 Fixed

- **Arrow Trap:** Resolved the reported bug. [#2](https://github.com/kleqing/Tap/issues/2)

### 🐛 Known Issues

- **Menu Alignment:** Arrow icons in the pause and game-over menus are misaligned with the corresponding text.  
- **Multiple Jump Bug:** Players can perform multiple jumps instead of being limited to double jumps, allowing unintended level progression.  

### 🔮 Coming Soon

- **Menu Screen Sound:** Adding background music or sound effects for the menu screen.  
- **Additional Features:** Stay tuned for more exciting updates and enhancements in future releases!  

## [0.0.6] - 2025-01-10

### 🎉 Added

- **Enemies:**
  - **Peashooter:** A new enemy that shoots when the player enters its range.

### 🛠️ Adjustments

- **Player:**
  - **Double Jump:** Players can now perform a second jump while in mid-air, enhancing mobility.

### 🐞 Fixed

- **Build Version:** Resolved a versioning issue where the project was labeled as `0.0.4` despite the release being `0.0.5`. This has been fully corrected in `0.0.6` by properly committing the `ProjectSettings` files.
- **ArrowTrap.cs:** Corrected a typo that caused functionality errors in the arrow trap mechanic.

### 🐛 Known Issues

- **Menu Alignment:** Arrow icons in the pause and game-over menus are not properly aligned with the corresponding text.

### 🛠️ Cannot Fix (Unity Engine Limitations)

- **Hitbox Issues:** Players may still occasionally get stuck when touching the edges of box colliders. This appears to be a limitation of Unity's physics engine.

### 🔮 Coming Soon

- **Startup Screen:** A polished introductory screen to improve the game launch experience.
- **New Traps:**
  - Introducing spikeheads and additional trap mechanics.
- **Other Features:** Stay tuned for more exciting updates and enhancements in future releases!

## [0.0.5] - 2025-01-08

### 🎉 Added
- **New Room:** Introduced Room 3 (still under development).  
- **New Terrain:** Expanded environments with fresh terrain designs.  
- **Background Music:** Added "Galaxy Collapse" from Touhou to enhance the atmosphere.  
- **Pause Menu:** Players can now pause the game and access options seamlessly.  

### 🔄 Updated
- **Camera System:**  
  - The camera now dynamically follows the player instead of being fixed.  
  - Smooth transitions are applied when moving between rooms.  

### 🐞 Fixed
- **Build Version Issues:** Resolved compatibility and scaling issues in the game build (fix was applied in [0.0.4] but not documented).  
- **Background Visuals:** Corrected occasional screen scratches affecting the game background.  

### 🐛 Known Bugs
- **Menu Alignment:** The arrow icons in the pause and dead menus are misaligned with the text.  

### 🛠️ Cannot Fix (Known Unity Issues)
- **Hitbox Errors:** Players may still get stuck when touching the edges of box colliders. This seems to be related to Unity's physics engine limitations.  

### 🔮 Coming Soon
- **Stage 2 Completion:** New challenges and exciting gameplay enhancements in the second stage.  
- **Startup Screen:** Implementing a polished introductory screen for a smoother game launch.  
- **Additional Features:** Further updates and surprises in upcoming releases!  

## [0.0.4] - 2025-01-04

### 🎉 Added
- **Trap:** Arrow trap
  - Shoots arrows at the player from a distance, adding a new challenge.

### 🐞 Known Issues
- **Hitbox Errors:** Players may still get stuck when touching the edge of a box collider (likely related to Unity's physics engine).
- **Camera Movement:** During transitions between levels along the Y-axis, the camera occasionally remains stuck for a few frames in the previous room. (Optimized but not fully resolved.)

### 🛠️ Fixed
- **Arrow Trap:** Fixed an issue where the arrow only shot once due to improper usage of `activeInHierarchy`.
- **Game Resolution:** Adjusted settings to improve compatibility with various screen resolutions after building the game.

### 🔮 Coming Soon
- **Background Music:** Adding immersive tracks to enhance gameplay ambiance.
- **Stage 2 Completion:** Introducing new challenges and finalizing the second stage.
- **Pause Menu:** Allowing players to pause and resume the game conveniently.
- **Startup Screen:** Implementing an introductory screen for a polished game start.
- **Other Enhancements:** Additional improvements and features to be announced.

## [0.0.3] - 2024-12-30

### 🐞 Bug Fixes
- **Auto Respawn:** Fixed an issue where the player would automatically respawn after death.
- **Game Over Screen:** Resolved an issue where the arrow in the Game Over menu could move bey🐞 Known Issues🐞 Known Issuesond the intended boundaries.
- **Screen Boundary:** Fixed a bug where the player could move outside the game screen.

### 🎉 Added
- **New Level:** Added an empty object as a placeholder for the next level.

### 🐞 Known Issues
- **Hitbox Errors:** Players may still get stuck when touching the edge of a box collider (potentially a Unity engine behavior).
- **Camera Movement:** The camera doesn't properly transition between levels on the Y-axis; some frames remain stuck in the previous room.
- **Game Resolution:** After building the game, the resolution may not fit certain computer screens correctly.

### 🔮 Coming Soon
- **Background Music:** Immersive background music to enhance the gaming experience.
- **Stage 2 Completion:** Finalizing and releasing Stage 2 with new challenges.
- **Additional Features:** More updates and features to come.

## [0.0.2 - Hot Fix] - 2024-12-28
- **Game startup:** Fixed a build error causing the game not to run when opened.

## [0.0.1] - 2024-12-28

### 🎉 Added
- Initial release of the game **Tap**.

### 🐞 Known Issues
- **Auto Respawn:** Player respawns automatically without displaying the UI.
- **Hitbox Errors:** Collision issues occur when the player touches the edge of an object.

### 🔮 Coming Soon
- **New Levels:** Exciting challenges to enhance gameplay (ETA: January 2025).
- **Bug Fixes:** Improvements to resolve known issues.

---

### 🛠️ How to Contribute
1. Report bugs or request features via [GitHub Issues](https://github.com/kleqing/Tap/issues).
2. Follow our contribution guidelines to submit a pull request.
