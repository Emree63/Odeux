using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Odeux.converter
{
    class DoubleToString : IValueConverter
    {
        //Ce Converter va s'occuper de retirer les notes négatifs en ne les affichants pas
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d = (double)value;
            if(d == -1)
            {
                return "";
            }
            return d.ToString();

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
