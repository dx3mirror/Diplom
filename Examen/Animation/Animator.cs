using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Animation
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;

        private static double Interval;

        public static bool IsWork = false;

        public static void Start()
        {
            if (IsWork) return;

            IsWork = true;
            Interval = 14; // FPS ~66

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            AnimatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            try {
                while (IsWork)
                {
                    AnimationList.RemoveAll(a => a == null || a.Status == Animation.AnimationStatus.Completed);

                    Parallel.For(0, Count(), index =>
                    {
                        AnimationList[index].UpdateFrame();
                    });

                    Thread.Sleep((int)Interval);
                }
                
            }
            catch
            {
                MessageBox.Show("Техническая ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Request(Animation Anim, bool ReplaceIfExists = true)
        {
            if (AnimatorThread == null || IsWork == false)
            {
                Start();
            }

            Debug.WriteLine("Запуск анимации: " + Anim.ID + "| TargetValue: " + Anim.TargetValue);
            Anim.Status = Animation.AnimationStatus.Requested;


            AnimationList.Add(Anim);
        }

        private static Animation GetDuplicate(Animation Anim)
        {
            return AnimationList.Find(a => a.ID == Anim.ID);
        }
    }
}
