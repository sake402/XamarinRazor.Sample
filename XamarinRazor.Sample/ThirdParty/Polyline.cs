
using Microsoft.AspNetCore.Components;
using LivingThing.Core.Frameworks.XamarinRazor.Forms;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class Polyline : ComponentToXamarinBridge<Xamarin.Forms.Maps.Polyline, Polyline>
    {
        public Polyline()
        {
        }
        public Polyline(Xamarin.Forms.Maps.Polyline _element):base(_element)
        {
        }

		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildAdded { set => P.ChildAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildRemoved { set => P.ChildRemoved += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantAdded { set => P.DescendantAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantRemoved { set => P.DescendantRemoved += value; }
		[Parameter] public Xamarin.Forms.Color StrokeColor { set => P.StrokeColor = value; get => P.StrokeColor; }
		[Parameter] public System.Single StrokeWidth { set => P.StrokeWidth = value; get => P.StrokeWidth; }
		[Parameter] public System.Object MapElementId { set => P.MapElementId = value; get => P.MapElementId; }
		[Parameter] public System.String AutomationId { set => P.AutomationId = value; get => P.AutomationId; }
		[Parameter] public System.String ClassId { set => P.ClassId = value; get => P.ClassId; }
		[Parameter] public System.String StyleId { set => P.StyleId = value; get => P.StyleId; }
		[Parameter] public Xamarin.Forms.Element Parent { set => P.Parent = value; get => P.Parent; }
		[Parameter] public Xamarin.Forms.IEffectControlProvider EffectControlProvider { set => P.EffectControlProvider = value; get => P.EffectControlProvider; }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
    }
}
