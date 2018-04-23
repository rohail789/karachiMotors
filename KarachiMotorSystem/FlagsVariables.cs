using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarachiMotorSystem
{
    public class FlagsVariables
    {
       public static FlagsVariables sharedInstanse = new FlagsVariables();
       public static bool accountCreate = false;
       public static string userId;
    }
}