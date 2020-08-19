
using Microsoft.AspNetCore.Components;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class GradientStop : ComponentToParameterBridge<Xamarin.Forms.PancakeView.GradientStop, GradientStop>
    {
        public GradientStop()
        {
        }
        public GradientStop(Xamarin.Forms.PancakeView.GradientStop _parameter):base(_parameter)
        {
        }
		[Parameter] public System.Single Offset { set => P.Offset = value; get => P.Offset; }
		[Parameter] public Xamarin.Forms.Binding BindOffset { set { P.SetBinding(Xamarin.Forms.PancakeView.GradientStop.OffsetProperty, value); } }
		[Parameter] public Xamarin.Forms.Color Color { set => P.Color = value; get => P.Color; }
		[Parameter] public Xamarin.Forms.Binding BindColor { set { P.SetBinding(Xamarin.Forms.PancakeView.GradientStop.ColorProperty, value); } }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
		[Parameter] public Xamarin.Forms.Binding BindBindingContext { set { P.SetBinding(Xamarin.Forms.PancakeView.GradientStop.BindingContextProperty, value); } }
    }
}
