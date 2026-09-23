# 🎮 Modular Event-Driven Inventory System (Unity 2D / C#)

A clean, scalable 2D Inventory System developed in Unity. This project demonstrates practical usage of software architecture patterns (Observer Pattern, ScriptableObjects) and strict separation of data from UI.

---

## 🌟 Key Features

- **Event-Driven Architecture:** UI updates dynamically via C# events (`OnInventoryChanged`) only when data changes, eliminating unnecessary `Update()` checks.
- **Data-Driven Items:** Item parameters (icons, stack limits, IDs) are isolated using `ScriptableObjects`.
- **Decoupled Architecture:** Strict separation between Data, Logic (`InventoryController`), and UI presentation (`InventorySlotUI`).
- **World Interaction:** Universal `ItemPickup` component for picking up items from the scene with stack validation.
- **Pixel-Art Friendly UI:** Configured Canvas Scaler, dynamic `GridLayoutGroup`, and `Point (no filter)` sprite settings for crisp rendering.

---

## 🛠️ Tech Stack & Concepts

- **Engine:** Unity
- **Language:** C#
- **Patterns & Architecture:** Observer Pattern, ScriptableObjects, Event-Driven UI, Component-Based Design

