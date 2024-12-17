# 🎮 Events and Delegates in .NET Core Explained with a Video Game Console Analogy  

Welcome to this guide where we explain **Events and Delegates in .NET Core** using a fun analogy: a **video game console**! This guide is available in three languages: **English**, **Spanish (MX)**, and **French (CA)**.

---

## 📖 Table of Contents  
- [English Version](#english-version)  
- [Versión en Español](#versión-en-español)  
- [Version en Français](#version-en-français)  

---

## English Version

### **What are Events and Delegates?**  
In .NET Core:  
- A **delegate** is like a **remote control** for your game console.  
- An **event** is something that happens in your game.  

Let’s dive into the **5 types of delegates** with video game examples!

---

### **1. Single-Cast Delegate 🎮**  
**Definition**: Calls **one method**.  

```csharp
public delegate void GameEvent();

static void PauseGame()
{
    Console.WriteLine("Game Paused!");
}

static void Main()
{
    GameEvent pauseButton = PauseGame;
    pauseButton();
}
```

---

### **2. Multi-Cast Delegate 🎮**  
**Definition**: Calls **multiple methods** in order.  

```csharp
public delegate void GameEvent();

static void ShowScreen() => Console.WriteLine("Screen ON!");
static void PlaySound() => Console.WriteLine("Welcome Sound Playing!");

static void Main()
{
    GameEvent powerButton = ShowScreen;
    powerButton += PlaySound;
    powerButton();
}
```

---

### **3. Func Delegate 🎮**  
**Definition**: Returns a value.  

```csharp
static int GetRemainingLives() => 3;

static void Main()
{
    Func<int> checkLives = GetRemainingLives;
    Console.WriteLine($"You have {checkLives()} lives left.");
}
```

---

### **4. Action Delegate 🎮**  
**Definition**: Calls a method **without returning a value**.  

```csharp
static void SaveGame() => Console.WriteLine("Game Saved!");

static void Main()
{
    Action saveButton = SaveGame;
    saveButton();
}
```

---

### **5. Predicate Delegate 🎮**  
**Definition**: Checks a condition and returns `true` or `false`.  

```csharp
static bool CanUnlockCharacter(int coins) => coins >= 100;

static void Main()
{
    Predicate<int> checkCoins = CanUnlockCharacter;
    Console.WriteLine($"Can unlock character: {checkCoins(120)}");
}
```

---

## Versión en Español

### **¿Qué son los eventos y delegados?**  
- Un **delegado** es como un **control remoto** de tu consola.  
- Un **evento** es algo que sucede en el juego.  

Aquí explicamos los **5 tipos de delegados** con ejemplos.

---

### **1. Delegado Simple 🎮**

```csharp
public delegate void EventoJuego();

static void PausarJuego()
{
    Console.WriteLine("¡Juego Pausado!");
}

static void Main()
{
    EventoJuego botonPausa = PausarJuego;
    botonPausa();
}
```

---

### **2. Delegado Múltiple 🎮**

```csharp
public delegate void EventoJuego();

static void MostrarPantalla() => Console.WriteLine("¡Pantalla Encendida!");
static void ReproducirSonido() => Console.WriteLine("¡Sonido de Bienvenida!");

static void Main()
{
    EventoJuego botonEncender = MostrarPantalla;
    botonEncender += ReproducirSonido;
    botonEncender();
}
```

---

### **3. Delegado Func 🎮**

```csharp
static int ObtenerVidasRestantes() => 3;

static void Main()
{
    Func<int> verificarVidas = ObtenerVidasRestantes;
    Console.WriteLine($"Tienes {verificarVidas()} vidas restantes.");
}
```

---

### **4. Delegado Action 🎮**

```csharp
static void GuardarJuego() => Console.WriteLine("¡Juego Guardado!");

static void Main()
{
    Action botonGuardar = GuardarJuego;
    botonGuardar();
}
```

---

### **5. Delegado Predicate 🎮**

```csharp
static bool PuedeDesbloquearPersonaje(int monedas) => monedas >= 100;

static void Main()
{
    Predicate<int> verificarMonedas = PuedeDesbloquearPersonaje;
    Console.WriteLine($"¿Desbloquear personaje? {verificarMonedas(120)}");
}
```

---

## Version en Français

### **Qu’est-ce que les événements et délégués ?**  
- Un **délégué** est comme une **télécommande** pour votre console.  
- Un **événement** est une action dans le jeu.  

Voyons les **5 types de délégués** avec des exemples.

---

### **1. Délégué Simple 🎮**

```csharp
public delegate void EvenementJeu();

static void MettrePause()
{
    Console.WriteLine("Jeu en pause !");
}

static void Main()
{
    EvenementJeu boutonPause = MettrePause;
    boutonPause();
}
```

---

### **2. Délégué Multiple 🎮**

```csharp
public delegate void EvenementJeu();

static void AllumerEcran() => Console.WriteLine("Écran allumé !");
static void JouerSon() => Console.WriteLine("Son de bienvenue !");

static void Main()
{
    EvenementJeu boutonAllumer = AllumerEcran;
    boutonAllumer += JouerSon;
    boutonAllumer();
}
```

---

### **3. Délégué Func 🎮**

```csharp
static int ViesRestantes() => 3;

static void Main()
{
    Func<int> verifierVies = ViesRestantes;
    Console.WriteLine($"Il vous reste {verifierVies()} vies.");
}
```

---

### **4. Délégué Action 🎮**

```csharp
static void SauvegarderJeu() => Console.WriteLine("Jeu sauvegardé !");

static void Main()
{
    Action boutonSauvegarde = SauvegarderJeu;
    boutonSauvegarde();
}
```

---

### **5. Délégué Predicate 🎮**

```csharp
static bool DebloquerPersonnage(int pieces) => pieces >= 100;

static void Main()
{
    Predicate<int> verifierPieces = DebloquerPersonnage;
    Console.WriteLine($"Débloquer personnage ? {verifierPieces(120)}");
}
```

---

### **Why It Matters 🎯**  
Delegates are essential for clean, dynamic programming, just like configuring your console for the perfect gaming experience.

---
