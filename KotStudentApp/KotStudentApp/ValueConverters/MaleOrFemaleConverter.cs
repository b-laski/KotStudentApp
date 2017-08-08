using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotStudentApp
{
    public class MaleOrFemaleConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value!=null)
            {
                return "COS";
            }
            else
            {
                return "X";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
