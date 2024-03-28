using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{

    public class AppMode
    {
        public ModeStateDS state;
        private AppMode() { }

        public AppMode(ModeStateDS state)
        {
            this.state = state;
        }
        private static AppMode curMODE;

        public static AppMode CurMODE
        {
            get { if (curMODE == null) curMODE = new AppMode(new LightMode()); return AppMode.curMODE; }
            private set { AppMode.curMODE = value; }
        }


    }
    public abstract class ModeStateDS
    {
        public string modeName;

        public Color primary = ColorTranslator.FromHtml("#00A9FF");
        public Color   secondary = ColorTranslator.FromHtml("#89CFF3");
        public Color third = ColorTranslator.FromHtml("#A0E9FF");
        public Color fourth = ColorTranslator.FromHtml("#CDF5FD");
        public Color fifth = ColorTranslator.FromHtml("#EEF5FF");
        public Color sixth = ColorTranslator.FromHtml("#B4D4FF");
        public Color seventh = ColorTranslator.FromHtml("#86B6F6");
        public ModeStateDS() { }
        public void SetMode(string modeName)
        {
            this.modeName = modeName;
        }
        public abstract bool CheckMode(string modeName);
        public abstract string GetModeName();
        public abstract void SwitchMode();

    }

    class LightMode : ModeStateDS
    {
       public LightMode() { }
        public override bool CheckMode(string modeName)
        {
            return modeName.CompareTo("Light") == 0;
        }

        public override string GetModeName()
        {
            return "Light";
        }
        public override void SwitchMode()
        {
            primary = ColorTranslator.FromHtml("#86f3ff");
            secondary = ColorTranslator.FromHtml("#00e5ff");
            third = ColorTranslator.FromHtml("#A0E9FF");
            fourth = ColorTranslator.FromHtml("#CDF5FD");
            fifth = ColorTranslator.FromHtml("#00f");

            sixth = ColorTranslator.FromHtml("#B4D4FF");
            seventh = ColorTranslator.FromHtml("#86B6F6");
        }
    }

    class DarkMode : ModeStateDS
    {
        public DarkMode() { }
        public override bool CheckMode(string modeName)
        {
            return modeName.CompareTo("Dark") == 0;
        }

        public override string GetModeName()
        {
            return "Dark";
        }
        public override void SwitchMode()
        {
            primary = ColorTranslator.FromHtml("#030637");
            secondary = ColorTranslator.FromHtml("#3C0753");
            third = ColorTranslator.FromHtml("#720455");
            fourth = ColorTranslator.FromHtml("#1B1A55");
            fifth = ColorTranslator.FromHtml("#EEF5FF");

            sixth = ColorTranslator.FromHtml("#535C91");
            seventh = ColorTranslator.FromHtml("#9290C3");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Contexts;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChatApp
//{

//    public class MODE
//    {
//        public MODE()
//        {

//            this.modeName = "Light";
//        }
//        public MODE(string modeName)
//        {
//            this.modeName = modeName;
//        }

//        public string modeName;
//        public void SetMode(string modeName)
//        {
//            this.modeName = modeName;
//        }
//        public bool CheckMode(string modeName)
//        {
//            return this.modeName.CompareTo(modeName) == 0;
//        }
//        public string GetModeName()
//        {
//            return this.modeName;
//        }

//        public static MODE curMODE
//        {
//            get { if (curMODE == null) curMODE = new MODE(); return MODE.curMODE; }
//            private set { MODE.curMODE = value; }
//        }


//    }
//}
