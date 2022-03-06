using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Coby.Forms.CustomControls.CardView.Anim;

internal static class Animator
{
    private static Thread _animatorThread;
    private static readonly double _interval = 3;

    public static List<Animation> AnimationList = new();

    public static int Count() => AnimationList.Count;

    public static void Start()
    {

        _animatorThread = new Thread(AnimationInvoker)
        {
            IsBackground = true,
            Name = "UI Animation"
        };

        _animatorThread.Start();
    }

    public static void Request(Animation Anim, bool ReplaceIfExists)
    {
        Anim.Status = AnimationStatus.Requested;

        Animation dupAnim = GetDuplicate(Anim);

        if (dupAnim is not null)
        {
            if (ReplaceIfExists)
                dupAnim.Status = AnimationStatus.Completed;
            else
                return;
        }

        AnimationList.Add(Anim);

        Animation GetDuplicate(Animation Anim) =>
            AnimationList.FirstOrDefault(x => x.Id.Equals(Anim.Id));
    }

    private static void AnimationInvoker()
    {
        while (true)
        {
            AnimationList.RemoveAll(a => a.Status == AnimationStatus.Completed);

            Parallel.For(0, Count(), index =>
            {
                AnimationList[index].UpdateFrame();
            });

            Thread.Sleep((int)_interval);
        }
    }
}