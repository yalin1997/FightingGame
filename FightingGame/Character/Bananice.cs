using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame.Character
{
    class Bananice : Character
    {
        String Name
        {
            get
            {
                return "Banana";
            }
        }
        int position = 22;
        int Level = 60;
        int ACT=763;
        int Def=252;
        int magicResist=253;
        int HP=6137;
        int MP=0;
        int COST=9;
        int Speed=636;
        private String smallAddress {
            get
            {
                return @"../../CharacterPicture\Bananice2.jpg";
            }
        }
        private String bigAddress
        {
            get
            {
                return @"../../CharacterPicture\Bananice3.png";
            }
        }
        public String getSmallAddress()
        {
            return smallAddress;
        }
        public String getBigAddress()
        {
            return bigAddress;
        }
        public void Action1(Character [] enemy)
        {
            throw new NotImplementedException();
        }

        public void Action2(Character[] enemy)
        {
            throw new NotImplementedException();
        }

        public void Action3(Character[] enemy)
        {
            throw new NotImplementedException();
        }

        public void useSkill()
        {
            throw new NotImplementedException();
        }


    }
}
