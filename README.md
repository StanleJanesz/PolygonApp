# 🧩 Polygon Editor

A powerful and intuitive polygon editor that lets users create, manipulate, and constrain polygon shapes with ease.

![Polygon Editor Screenshot](https://github.com/user-attachments/assets/c35b7a6b-ef20-4d0f-bd28-0530785a644a)

## ✨ Features

- ➕ **Add, move, or delete vertices** with simple interactions.
- 📏 **Apply geometric constraints** to edges:
  - Horizontal
  - Vertical
  - Fixed length
- 🎨 **Convert edges to Bézier curves** with support for:
  - `C0` continuity (positional)
  - `C1` continuity (tangential)
  - `C2` continuity (curvature)
- 🧠 **Smart constraint handling**: moving one vertex automatically adjusts others to maintain all active constraints.
- ⚙️ **Automatic constraint detection**: when placing two vertices horizontally or vertically, the editor will remember it as a rule — unless specified otherwise.

## 🛠️ How It Works

1. Click to add vertices to your polygon.
2. Select edges to apply constraints or convert them to curves.
3. Drag vertices — the editor maintains all your set rules.
4. Enjoy a seamless editing experience with geometric precision!

## 📸 Demo

_See the screenshot above or try it yourself by cloning the repo._

## 🚀 Getting Started

Clone the repo and open the project in your preferred development environment.  
Coming soon: a full build & usage guide.

```bash
git clone https://github.com/your-username/polygon-editor.git
