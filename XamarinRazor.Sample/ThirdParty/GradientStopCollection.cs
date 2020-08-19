
using Microsoft.AspNetCore.Components;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class GradientStopCollection : ComponentToParameterBridge<Xamarin.Forms.PancakeView.GradientStopCollection, GradientStopCollection>
    {
        public GradientStopCollection()
        {
        }
        public GradientStopCollection(Xamarin.Forms.PancakeView.GradientStopCollection _parameter):base(_parameter)
        {
        }

    }
}
