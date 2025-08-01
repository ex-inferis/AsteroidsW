using AsteroidsW;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;


var gameSettings = GameWindowSettings.Default;
var nativeSettings = new NativeWindowSettings
{
    ClientSize = new Vector2i(GameConfig.WindowWidth, GameConfig.WindowHeight),
    Title = GameConfig.WindowTitle,
    API = ContextAPI.OpenGL,
    APIVersion = new Version(4, 6),
    Profile = ContextProfile.Core
};

using var game = new AsteroidsGame(gameSettings, nativeSettings);
game.Run();