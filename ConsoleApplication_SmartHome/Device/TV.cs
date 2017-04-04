using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class TV : MediaDevice, IColorRedable
    {

        private ILevelSetable levelColorRed;

        public byte ColorRed
        {
            get
            {
                return levelColorRed.LevelSetup;
            }
            set
            {
                levelColorRed.LevelSetup = value;
            }
        }

        public TV(string name, bool state, byte volume, int chanel, byte levelRedColor, ILevelSetable volumeSet, ISwitchSetable chanelSet, ILevelSetable settingColorRed)// инъекция зависимости через конструктор
        {
            this.VolumeSet = volumeSet; // сначала создаем ссылку а потом вызываем метод
            this.levelColorRed = settingColorRed;
            CurrentSet = chanelSet;
            Name = name;
            State = state;
            Current = chanel;
            Volume = volume;
            ColorRed = levelRedColor;
        }

        public void ColorRedUp()
        {
            levelColorRed.LevelUp();
        }
        public void ColorRedDown()
        {
            levelColorRed.LevelDown();
        }

        public override string ToString()
        {
            string toString;
            if (State == true)
            {
                toString = "Телевизор " + base.ToString() + "текущий канал " + Current + ", уровень насыщенности красного цвета " + ColorRed + "%";
            }
            else
            {
                toString = "Телевизор " + Name + " выкл.";
            }
            return toString;
            //return "Телевизор " + base.ToString() + "текущий канал " + Current + ", уровень насыщенности красного цвета " + ColorRed + "%";
        }
    }
}
