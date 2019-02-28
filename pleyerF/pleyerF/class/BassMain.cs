using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace pleyerF
{
    public static class BassMain
    {
        public static int HZ = 44100;//переменная частоты дикритизации 

        public static bool initDefaultDevice; //состояние инициализации

        public static int chanal;//канал овечающий за поток в плеере stream 

        public static int voluem=100; //громкость 
        //канал остановленый руками
        public static bool isStoped=true;

        //когда плейлист доиграет полностью
        public static bool endPleyList;

        //добавляем лист который будет хранить наши плагины 
        private static readonly List<int> BassPlaginsHandlesrs = new List<int>();

        //metods иницилизация bass.dll
        
        public static bool InitBass(int hz) {
            if (!initDefaultDevice) {
                initDefaultDevice = Bass.BASS_Init(-1,hz,BASSInit.BASS_DEVICE_DEFAULT,IntPtr.Zero);
                //инициализируем поток первая переменная это звуковая карта поумолчанию 
                //вторая частота дискритизации
                //стандартное устройство 
                //следующий параметр ставим, как указана в мануале 

                //создаём папку plugins там будут плагины для поддержки других форматов 
                if (initDefaultDevice)
                {
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_aac.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_adx.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_aix.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_ape.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_mpc.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_tta.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassenc_flac.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassenc_ogg.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassenc_opus.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassflac.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswma.dll"));
                    BassPlaginsHandlesrs.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswv.dll"));
                }
                //тут поидеи вывод сколько ошибок 
                int ErrorCount = 0;
                for (int i = 0; i < BassPlaginsHandlesrs.Count-1; i++)
                {
                    if (BassPlaginsHandlesrs[i] == 0)
                        ErrorCount++;
                    
                    if (ErrorCount != 0)
                    {
                        //но месадж шоу не показывается 
                        //MessageBox.Show(errorcount+"плагинов не было загруженно", "ошибка",MessageBoxButtons.ok,massegeBoxIcon.Warning); 
                        Console.WriteLine(ErrorCount);
                        
                    }
                    ErrorCount = 0;
                    
                }



            }
            return initDefaultDevice;


        }
        //payse
        public static void Pause() {

            if(Bass.BASS_ChannelIsActive(chanal)==BASSActive.BASS_ACTIVE_PLAYING)
            Bass.BASS_ChannelPause(chanal);



        }

        //metod stop
        public static void Stop() {
            Bass.BASS_ChannelStop(chanal);
            Bass.BASS_StreamFree(chanal);
            isStoped = true; 
        }
        //получаем длительность трека 
        public static int GetTimeOfChanal(int chanal)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(chanal);//получаем длительность в байтах 
            //переводим её в секунды
            double Time = Bass.BASS_ChannelBytes2Seconds(chanal,TimeBytes);
            return (int)Time;
        }

        //получаем длительность трека
        public static int getPosOfChanal(int chanal) {
            long posBytes = Bass.BASS_ChannelGetPosition(chanal);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(chanal, posBytes);

            return posSec;

        }
        //перемотка трека
        public static void setPosOfScrol(int chanal, int pos)
        {
            Bass.BASS_ChannelSetPosition(chanal,(double)pos);
        }



        //воспроизведение
        public static void Play(string fileName, int vol)
        {

            if (Bass.BASS_ChannelIsActive(chanal) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();

                if (InitBass(HZ))
                {
                    chanal = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);

                    //если инициализирована чеастота тогда нашему каналу указываем имя трека с какой  
                    //с какого времени играть и по какое (0 - значит оригинальное т.е. до конца)

                    if (chanal != 0)
                    {
                        voluem = vol;
                        //(канал, атрибут, громкость) дальше воспроизводим 
                        Bass.BASS_ChannelSetAttribute(chanal, BASSAttribute.BASS_ATTRIB_VOL, voluem / 100F);
                        Bass.BASS_ChannelPlay(chanal, false);
                    }

                }
            }
            else
            {
                Bass.BASS_ChannelPlay(chanal, false);
            }
            isStoped = false;//добавили 


        }

        //установака громкости 
        public static void setVoidToChanal(int chanal, int vol) {
            voluem = vol;
            Bass.BASS_ChannelSetAttribute(chanal, BASSAttribute.BASS_ATTRIB_VOL, voluem / 100F);
        }

        //metod perekluchenya pesen
        public static bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(chanal) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
                {
                    Play(Vars.Files[++Vars.CurrentTrackNumber], voluem);
                    endPleyList = false;
                    return true;
                }
                else
                {
                    endPleyList = true;
                }
            }
            return true;


        }

         
    }
}
