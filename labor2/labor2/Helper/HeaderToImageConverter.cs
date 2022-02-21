﻿using System;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;
using System.IO;

namespace labor2.helper
{
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter headerToImageConverter = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string)value;
            if (path == null)
                return null;
            string name = MainWindow.getFileFolderName(path);
            string image = "images/file.png";
            if (string.IsNullOrEmpty(name))
                image = "images/hard_drive.png";
            else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                image = "images/folder.png";
            return new BitmapImage(new Uri($"pack://application:,,/{image}"));
        }
        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
