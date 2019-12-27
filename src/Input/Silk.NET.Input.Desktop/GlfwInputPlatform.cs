// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Utilities;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Input.Desktop
{
    public class GlfwInputPlatform : IInputPlatform
    {
        private GlfwInputPlatform(){}
        private static Dictionary<IntPtr, GlfwEvents> _subs = new Dictionary<IntPtr, GlfwEvents>();
        public bool IsApplicable(IWindow window) => window is GlfwWindow;

        public IInputContext CreateInput(IWindow window) => new GlfwInputContext(window as GlfwWindow);
        public static GlfwInputPlatform Instance { get; } = new GlfwInputPlatform();

        static GlfwInputPlatform()
        {
            GlfwProvider.GLFW.Value.SetJoystickCallback(
                (j, s) =>
                {
                    foreach (var x in _subs.Values)
                    {
                        x.InvokeJoystick(j, s);
                    }
                }
            );
        }
        
        internal static unsafe void RegisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            var events = _subs.ContainsKey
                ((IntPtr) handle)
                ? _subs[(IntPtr) handle]
                : _subs[(IntPtr) handle] = new GlfwEvents(handle);
            foreach (var subscriber in subscribers)
            {
                subscriber.Subscribe(events);
            }
        }
        
        internal static unsafe void UnregisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            var events = _subs.ContainsKey
                ((IntPtr) handle)
                ? _subs[(IntPtr) handle]
                : _subs[(IntPtr) handle] = new GlfwEvents(handle);
            foreach (var subscriber in subscribers)
            {
                subscriber.Unsubscribe(events);
            }
        }
    }
}
