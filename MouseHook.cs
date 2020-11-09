using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading;

using System.Diagnostics;

namespace ImageChecker
{
    public static class MouseHook
    {
        public static event EventHandler MouseActionLeftClick = delegate { };
        public static event EventHandler MouseActionRightClick = delegate { };

        public static void Start()
        {
            hookNumber = SetHook(mouseTickResultLeftClick);
            hookNumber = SetHook(mouseTickResultRightClick);

        }
        public static void stop()
        {
            UnhookWindowsHookEx(hookNumber);
        }

        private static ReadMouseTick mouseTickResultLeftClick = MouseEventReturnLeftClick;
        private static ReadMouseTick mouseTickResultRightClick = MouseEventReturnRichgClick;
        private static IntPtr hookNumber = IntPtr.Zero;

        private static IntPtr SetHook(ReadMouseTick proc)
        {
            using (Process cursorProcess = Process.GetCurrentProcess())
            using (ProcessModule cursorModule = cursorProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                  GetModuleHandle(cursorModule.ModuleName), 0);
            }
        }

        private delegate IntPtr ReadMouseTick(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr MouseEventReturnLeftClick(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MouseEventStruckt mouseEventResult = (MouseEventStruckt)Marshal.PtrToStructure(lParam, typeof(MouseEventStruckt));
                MouseActionLeftClick(null, new EventArgs());
            }
            return CallNextHookEx(hookNumber, nCode, wParam, lParam);
        }
        private static IntPtr MouseEventReturnRichgClick(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_RBUTTONDOWN == (MouseMessages)wParam)
            {
                MouseEventStruckt mouseEventResult = (MouseEventStruckt)Marshal.PtrToStructure(lParam, typeof(MouseEventStruckt));
                MouseActionRightClick(null, new EventArgs());
            }
            return CallNextHookEx(hookNumber, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseEventStruckt
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          ReadMouseTick lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);


    }
}
