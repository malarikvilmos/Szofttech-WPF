﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Szofttech_WPF.Converters
{
    public class ColorConverter : IValueConverter
    {
        Color Blue = Color.FromRgb(50, 105, 168);
        Color Dark = Color.FromRgb(37, 57, 66);
        Color Light = Color.FromRgb(186, 217, 232);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color val = (Color)value;

            if (val == Blue)
                return "Blue";
            else if (val == Dark)
                return "Dark";
            else if (val == Light)
                return "Light";
            else
                return "Dark";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case "Blue":
                    return Blue;
                case "Dark":
                    return Dark;
                case "Light":
                    return Light;
                default:
                    return Dark;
            }
        }
    }
}
