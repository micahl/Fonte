﻿/**
 * Copyright 2018, Adrien Tétar. All Rights Reserved.
 */

namespace Fonte.App.Interfaces
{
    using Fonte.App.Controls;
    using Microsoft.Graphics.Canvas;

    using Windows.UI.Core;
    using Windows.UI.Xaml.Input;

    public interface ICanvasDelegate
    {
        CoreCursor Cursor { get; }

        bool HandlePointerEvent(DesignCanvas canvas, PointerRoutedEventArgs e);
        void OnDraw(DesignCanvas canvas, CanvasDrawingSession ds, float rescale);
        void OnDrawBackground(DesignCanvas canvas, CanvasDrawingSession ds, float rescale);
        void OnKeyDown(DesignCanvas canvas, KeyRoutedEventArgs e);
        void OnKeyUp(DesignCanvas canvas, KeyRoutedEventArgs e);
        void OnPointerPressed(DesignCanvas canvas, PointerRoutedEventArgs e);
        void OnPointerMoved(DesignCanvas canvas, PointerRoutedEventArgs e);
        void OnPointerReleased(DesignCanvas canvas, PointerRoutedEventArgs e);
    }
}
