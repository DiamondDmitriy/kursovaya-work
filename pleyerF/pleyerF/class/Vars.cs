using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pleyerF
{
    class Vars
    {
        public static Form1 link;
        //эта переменная будет хранить пусть к нашей программе где бы она не хранилась 
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        //список полных имён файлов 
        public static List<string> Files = new List<string>();

        //добавляем переключание песен 
        public static int CurrentTrackNumber;//хранит текущую позицию трека в плейлисте 


        //for crasiviy name
        //создаём масив разбив путь по слешам и берём последнюю часть без слеша
        public static string GetFileName(string file) {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }

        //метод пердотвращения закидывания что попало в плеер 
        public static void setInputFormats()
        {
            link.openFileDialog1.Filter = "Все форматы|*.mp3;*.m4a; *.mp4; *.tta; *.alac; *.ogg; *.opus; *.acc; " +
                "*.adx; *.aix; *.ape; *.mpc; *.flac;*.wma; *.wv"
                + "|m4a(*.m4a)|*.m4a"
                + "|mp4(*.mp4)|*.mp4"
                + "|tta(*.tta)|*.tta"
                + "|alac(*.alac)|*.alac"
                + "|ogg(*.ogg)|*.ogg"
                + "|opus(*.opus)|*.opus"
                + "|acc(*.acc)|*.acc"
                + "|adx(*.adx)|*.adx"
                + "|aix(*.aix)|*.aix"
                + "|mpc(*.mpc)|*.mpc"
                + "|flac(*.flac)|*.flac"
                + "|wma(*.wma)|*.wma"
                + "|wv(*.wv)|*.wv";
        }

    }
}
