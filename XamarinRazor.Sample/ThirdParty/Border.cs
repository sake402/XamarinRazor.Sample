
using Microsoft.AspNetCore.Components;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class Border : ComponentToParameterBridge<Xamarin.Forms.PancakeView.Border, Border>
    {
        public Border()
        {
        }
        public Border(Xamarin.Forms.PancakeView.Border _parameter):base(_parameter)
        {
        }
		[Parameter] public System.Int32 Thickness { set => P.Thickness = value; get => P.Thickness; }
		[Parameter] public Xamarin.Forms.Binding BindThickness { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.ThicknessProperty, value); } }
		[Parameter] public Xamarin.Forms.Color Color { set => P.Color = value; get => P.Color; }
		[Parameter] public Xamarin.Forms.Binding BindColor { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.ColorProperty, value); } }
		[Parameter] public Xamarin.Forms.PancakeView.DashPattern DashPattern { set => P.DashPattern = value; get => P.DashPattern; }
		[Parameter] public Xamarin.Forms.Binding BindDashPattern { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.DashPatternProperty, value); } }
		[Parameter] public Xamarin.Forms.Point GradientStartPoint { set => P.GradientStartPoint = value; get => P.GradientStartPoint; }
		[Parameter] public Xamarin.Forms.Binding BindGradientStartPoint { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.GradientStartPointProperty, value); } }
		[Parameter] public Xamarin.Forms.Point GradientEndPoint { set => P.GradientEndPoint = value; get => P.GradientEndPoint; }
		[Parameter] public Xamarin.Forms.Binding BindGradientEndPoint { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.GradientEndPointProperty, value); } }
		[Parameter] public Xamarin.Forms.PancakeView.BorderDrawingStyle DrawingStyle { set => P.DrawingStyle = value; get => P.DrawingStyle; }
		[Parameter] public Xamarin.Forms.Binding BindDrawingStyle { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.DrawingStyleProperty, value); } }
		[Parameter] public Xamarin.Forms.PancakeView.GradientStopCollection GradientStops { set => P.GradientStops = value; get => P.GradientStops; }
		[Parameter] public Xamarin.Forms.Binding BindGradientStops { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.GradientStopsProperty, value); } }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
		[Parameter] public Xamarin.Forms.Binding BindBindingContext { set { P.SetBinding(Xamarin.Forms.PancakeView.Border.BindingContextProperty, value); } }
    }
}
