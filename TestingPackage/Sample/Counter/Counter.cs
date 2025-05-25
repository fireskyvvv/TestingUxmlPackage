using Moon.Runtime.Core;
using UnityEngine.UIElements;
//using ViewInstaller = Moon.Sample.Generated.ViewInstaller;

namespace Testing.Sample.Counter
{
    /*[MoonView(ViewKey = nameof(CounterView))]*/
    [MoonView(ReferenceMode = MoonViewAttribute.ViewReferenceMode.AssetBundle)]
    public partial class Counter : ViewBase
    {
        public Counter()
        {
           //var installer = new ViewInstaller();
        }
    }
}