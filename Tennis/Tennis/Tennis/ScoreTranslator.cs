using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class ScoreTranslator
    {
      public string TransScore(int score)
        {
           string value = string.Empty;
           switch (score)
            {
                case 0: value = "love";break;
                case 1: value = "15";break;
                case 2: value = "30";break;
                case 3: value = "40";break;
                case 4: value = "advantage";break;
               default: value = score.ToString();break;
            }
            return value;
        }
       
    }
}
