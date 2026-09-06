using SFML.Graphics;
using SFML.Window;
using SFML.System;

var window = new RenderWindow(new VideoMode(new Vector2u(1280, 720)), "Sorting Visualization");
window.Closed += (s, e) => window.Close();

while (window.IsOpen)
{
    window.DispatchEvents();
    window.Clear(Color.Green);
    window.Display();
}
