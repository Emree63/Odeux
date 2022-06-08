using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Odeux.converter
{
    class ColorNote : IValueConverter
    {
        //Si une note va se voir en dessous de 10, elle va s'afficher en rouge sinon en vert
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d = (double)value;
            if(d<10)
            {
                return new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            return new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
