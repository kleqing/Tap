# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),  
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## [0.0.4] - 2025-1-3

### 🎉 Added
- **New trap:** Arrow trap

## [0.0.3] - 2024-12-30

### 🐞 Bug Fixes
- **Auto Respawn:** Fixed an issue where the player would automatically respawn after death.
- **Game Over Screen:** Resolved an issue where the arrow in the Game Over menu could move beyond the intended boundaries.
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
