using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame.Character
{
    interface Character
    {
        String getSmallAddress();
        String getBigAddress();
        void Action1(Character[] enemy);
        void Action2(Character[] enemy);
        void Action3(Character[] enemy);
        void useSkill();
    }
}
