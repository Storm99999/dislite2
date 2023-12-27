﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class Blurtil
{
    // This is almost never used, but i'll leave it here incase someone would like to take this.

    /// <summary>
    /// Enables Window Blur.
    /// </summary>
    /// <param name="window">Form</param>
    /// <param name="blurColor">Color of the blur</param>
    /// <exception cref="ArgumentNullException"></exception>
    public static void EnableAcrylic(IWin32Window window, Color blurColor)
    {
        if (window is null) throw new ArgumentNullException(nameof(window));

        var accentPolicy = new AccentPolicy
        {
            AccentState = ACCENT.ENABLE_ACRYLICBLURBEHIND,
            GradientColor = ToAbgr(blurColor),
        };

        unsafe
        {
            SetWindowCompositionAttribute(
                new HandleRef(window, window.Handle),
                new WindowCompositionAttributeData
                {
                    Attribute = WCA.ACCENT_POLICY,
                    Data = &accentPolicy,
                    DataLength = Marshal.SizeOf<AccentPolicy>()
                });
        }
    }

    private static uint ToAbgr(Color color)
    {
        return ((uint)color.A << 24)
            | ((uint)color.B << 16)
            | ((uint)color.G << 8)
            | color.R;
    }


#pragma warning disable 649

    [DllImport("user32.dll")]
    private static extern int SetWindowCompositionAttribute(HandleRef hWnd, in WindowCompositionAttributeData data);

    private unsafe struct WindowCompositionAttributeData
    {
        public WCA Attribute;
        public void* Data;
        public int DataLength;
    }

    private enum WCA
    {
        ACCENT_POLICY = 19
    }

    private enum ACCENT
    {
        DISABLED = 0,
        ENABLE_GRADIENT = 1,
        ENABLE_TRANSPARENTGRADIENT = 2,
        ENABLE_BLURBEHIND = 3,
        ENABLE_ACRYLICBLURBEHIND = 4,
        INVALID_STATE = 5
    }

    private struct AccentPolicy
    {
        public ACCENT AccentState;
        public uint AccentFlags;
        public uint GradientColor;
        public uint AnimationId;
    }
}
