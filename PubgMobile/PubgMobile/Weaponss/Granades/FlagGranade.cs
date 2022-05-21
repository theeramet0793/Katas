using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.Granades
{
    public class FlagGranade : Granade
    {
        public FlagGranade()
        {
            name = WeaponName.FlagGranade;
            damage = 200;
            throwRange = 20;
            radiusDamage = 5;
        }
    }
}
