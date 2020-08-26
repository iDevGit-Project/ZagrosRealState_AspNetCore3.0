using System;
using System.Collections.Generic;
using System.Text;

namespace ZagrosRealState.Data.Interface
{
    public interface IConvertDate
    {
        DateTime ConvertShamsiToMiladi(string Date);
        string ConvertMiladiToShamsi(DateTime Date, string Format);
    }
}
