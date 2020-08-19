
using Microsoft.AspNetCore.Components;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class DropShadow : ComponentToParameterBridge<Xamarin.Forms.PancakeView.DropShadow, DropShadow>
    {
        public DropShadow()
        {
        }
        public DropShadow(Xamarin.Forms.PancakeView.DropShadow _parameter):base(_parameter)
        {
        }
		[Parameter] public System.Single BlurRadius { set => P.BlurRadius = value; get => P.BlurRadius; }
		[Parameter] public Xamarin.Forms.Binding BindBlurRadius { set { P.SetBinding(Xamarin.Forms.PancakeView.DropShadow.BlurRadiusProperty, value); } }
		[Parameter] public System.Single Opacity { set => P.Opacity = value; get => P.Opacity; }
		[Parameter] public Xamarin.Forms.Binding BindOpacity { set { P.SetBinding(Xamarin.Forms.PancakeView.DropShadow.OpacityProperty, value); } }
		[Parameter] public Xamarin.Forms.Color Color { set => P.Color = value; get => P.Color; }
		[Parameter] public Xamarin.Forms.Binding BindColor { set { P.SetBinding(Xamarin.Forms.PancakeView.DropShadow.ColorProperty, value); } }
		[Parameter] public Xamarin.Forms.Point Offset { set => P.Offset = value; get => P.Offset; }
		[Parameter] public Xamarin.Forms.Binding BindOffset { set { P.SetBinding(Xamarin.Forms.PancakeView.DropShadow.OffsetProperty, value); } }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
		[Parameter] public Xamarin.Forms.Binding BindBindingContext { set { P.SetBinding(Xamarin.Forms.PancakeView.DropShadow.BindingContextProperty, value); } }
    }
}
