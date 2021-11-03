﻿using Xamarin.Forms;

namespace ValueConverters
{
    /// <summary>
    /// Converts a bool value to Keyboard.
    /// This converter is useful if you want to switch the Keyboard type of an Entry
    /// depending on a data binding.
    /// </summary>
    public class BoolToKeyboardConverter : BoolToValueConverter<Keyboard>
    {
    }
}
