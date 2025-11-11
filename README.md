# Unity Multiplayer Demo Project

A simple Unity demonstration project featuring user authentication, scene management, object spawning mechanics, and a robust debugging system.

## 🚀 Features

- **User Login System**: Name-based authentication with input validation
- **Persistent Data**: Player preferences storage across sessions
- **Scene Management**: Seamless transition between login and main room scenes
- **Dynamic Object Spawning**: Random cube generation with UI controls
- **Multi-language Support**: RTL (Right-to-Left) text compatibility for languages like Arabic, Hebrew, etc.
- **Custom Debug System**: Configurable logging with multiple severity levels
- **Singleton Patterns**: Efficient management of global controllers

## 🏗️ Project Structure

### Core Scripts

#### `LoginScreen.cs`
- Handles user authentication interface
- Input validation for player names (1-31 characters)
- Automatic login for returning players
- Scene transition to main room

#### `PlayerController.cs`
- Singleton pattern for global player data access
- Persistent player credentials storage
- Cross-scene data persistence using `DontDestroyOnLoad`

#### `RoomManager.cs`
- Main room scene controller
- Displays player name using RTL-compatible text
- Integration with debugging system

#### `CubeSpawner.cs`
- UI-driven object spawning system
- Random 3D position generation within configurable range
- Prefab-based instantiation

#### `Prefs.cs`
- Centralized constants for PlayerPrefs keys
- Easy management of stored data identifiers

#### `Debugs.cs`
- Custom logging system with toggleable debug mode
- Multiple log levels: Normal, Warning, Error
- Singleton pattern for global access

## 🛠️ Setup Instructions

### Prerequisites
- Unity 2019.4 or later
- RTL Text Mesh Pro package (for RTL text support)
- Unity Visual Scripting (for Debugs component)

### Installation
1. Clone this repository
2. Open the project in Unity
3. Ensure all script dependencies are resolved
4. Set up the required scenes in Build Settings:
   - Login scene
   - Room scene

## 📁 Key Components

### Prefabs & Assets
- `cubePrefab`: The cube object to be spawned (assign in inspector)
- UI Button: Triggers cube spawning functionality

### Player Preferences
- `Prefs.PREF_PLAYER_NAME`: Stores player name between sessions

### Configuration
- `spawnRange`: Adjustable spawn area radius (default: 10 units)
- Input validation: Player name length 1-31 characters
- `Debugs.isDebug`: Toggle for enabling/disabling debug logs

## 🎮 Usage

1. **First Launch**:
   - Enter your name in the login screen (1-31 characters)
   - Name is saved automatically for future sessions

2. **Returning Players**:
   - Automatically logged in and taken to main room

3. **In Main Room**:
   - Your name is displayed at the top
   - Use the spawn button to generate cubes at random positions
   - Cubes spawn within the defined range around the origin

4. **Debugging**:
   - Toggle `isDebug` in the Debugs component to enable/disable logs
   - View different log types in console (Normal, Warning, Error)

## 🔧 Customization

### Modifying Spawn Behavior
Edit `CubeSpawner.cs`:
```csharp
public float spawnRange = 10f; // Change spawn area size
```

### Adding New Player Preferences
Extend `Prefs.cs`:
```csharp
public const string PREF_NEW_SETTING = "newsetting";
```

### Adding New Player Data
Extend `PlayerController.cs`:
```csharp
// Implement saving/loading in SaveCreds and initCreds methods
```

### Debug System Usage
```csharp
// Normal log
Debugs.Instance.Log("Player joined", Debugs.DebugType.Normal);

// Warning
Debugs.Instance.Log("Low resources", Debugs.DebugType.Warning);

// Error
Debugs.Instance.Log("Critical failure", Debugs.DebugType.Error);
```

## 🐛 Debugging

The project uses a custom `Debugs` system for logging:

- **Normal logs**: General information and gameplay events
- **Warning logs**: Non-critical issues and edge cases
- **Error logs**: Critical failures and system errors

### Debug Configuration
- Set `isDebug` to `true` in the Debugs component to enable logging
- Set to `false` in production to improve performance
- Check console output for comprehensive system tracking

### Common Log Events
- Player authentication and room joining
- Cube spawning activities
- System initialization status
- Error conditions and warnings

## 📝 Architecture Notes

- **Singleton Pattern**: Used for `PlayerController` and `Debugs` for global access
- **Separation of Concerns**: Each script has a specific, focused responsibility
- **Extensibility**: Easy to add new features like server communication
- **Persistence**: Player data survives between sessions and scene changes

## 🔄 Potential Extensions

1. **Server Integration**: Replace local authentication with actual server calls
2. **Multiplayer Features**: Add networking for multiple players
3. **Enhanced UI**: Improve user interface with animations and feedback
4. **Data Persistence**: Add more player statistics and preferences
5. **Advanced Debugging**: Add file logging and remote debug capabilities
