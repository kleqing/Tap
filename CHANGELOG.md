# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),  
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

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
