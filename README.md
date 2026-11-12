# Coin Collector 🪙🎮

A physics-based 3D roll-a-ball coin collection game built in Unity featuring smooth camera tracking, dynamic coin animations, and game state management.

![Unity](https://img.shields.io/badge/Unity-6000.3.20f1-black?logo=unity)
![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20WebGL-blue)
![License](https://img.shields.io/badge/License-MIT-green)

---

## 🚀 Features

- **Physics-Based Ball Controller:** Smooth torque and force-based sphere movement powered by Unity's 3D physics engine (`Rigidbody`) with jump capability.
- **Dynamic Coin Mechanics:** Coins with continuous 360-degree rotation and sinusoidal vertical floating/bobbing animations.
- **Smooth Follow Camera:** Custom third-person `CameraFollow` script implementing `Vector3.Lerp` damping and dynamic look-at target framing.
- **Game State Manager:** Centralized `GameManager` handling score updates, victory threshold detection, out-of-bounds fall detection, and level restarts.
- **Modular Scripts:** Clean, decoupled C# scripts adhering to Unity best practices.

---

## 🎮 Controls

| Key / Input | Action |
|---|---|
| `W` / `Up Arrow` | Roll forward |
| `S` / `Down Arrow` | Roll backward |
| `A` / `Left Arrow` | Roll left |
| `D` / `Right Arrow` | Roll right |
| `Space` | Jump |

---

## 📁 Project Structure

```
Coin Collector/
├── Assets/
│   ├── Scripts/
│   │   ├── PlayerBallController.cs   # Rigidbody physics, roll controls, jump & collisions
│   │   ├── Coin.cs                   # Continuous rotation, sinusoidal bobbing & pickup
│   │   ├── CameraFollow.cs           # Smooth Lerp camera tracking
│   │   └── GameManager.cs            # Singleton score & game loop manager
│   ├── Scenes/
│   │   └── SampleScene.unity         # Core level scene
│   └── InputSystem_Actions.inputactions
├── Packages/
├── ProjectSettings/
└── README.md
```

---

## ⚡ Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/priyanshipanja/Coin-Collector.git
   ```
2. Open **Unity Hub** and click **Add** $\rightarrow$ select the cloned `Coin Collector` folder.
3. Open the project using **Unity 6000.3.20f1** (or compatible Unity 6 / LTS version).
4. Navigate to `Assets/Scenes/SampleScene.unity` and click **Play (Ctrl + P)**.

---

## 👤 Author

**Priyanshi Panja**  
- GitHub: [@priyanshipanja](https://github.com/priyanshipanja)

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
