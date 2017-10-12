using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class Sportster : Harleys
    {
        public string wheelOption;
        public string licensePlateMount;
    }

    public string WheelOption
    {
        get { return this.WheelOption; }
        set { this.WheelOption = value; }
    }
    public string LicensePlateMount
    {
        get { return this.LicensePlateMount; }
        set { this.LicensePlateMount = value; }
    }


}
