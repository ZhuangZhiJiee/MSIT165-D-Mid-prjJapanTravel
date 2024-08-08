using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CNumberUtility
    {
        public static bool isNumber(string p) //建一個方法來存判斷輸入的是否為數字，因為很常用不要一直new所以用static
        {
            try
            {
                double d = Convert.ToDouble(p); //檢查輸入的參數是否能轉換為double
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
