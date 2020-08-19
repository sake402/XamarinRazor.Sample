
using Microsoft.AspNetCore.Components;
using LivingThing.Core.Frameworks.XamarinRazor.Forms;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class Circle : ComponentToXamarinBridge<Xamarin.Forms.Maps.Circle, Circle>
    {
        public Circle()
        {
        }
        public Circle(Xamarin.Forms.Maps.Circle _element):base(_element)
        {
        }

		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildAdded { set => P.ChildAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildRemoved { set => P.ChildRemoved += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantAdded { set => P.DescendantAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantRemoved { set => P.DescendantRemoved += value; }
		[Parameter] public Xamarin.Forms.Maps.Position Center { set => P.Center = value; get => P.Center; }
		[Parameter] public Xamarin.Forms.Binding BindCenter { set { P.SetBinding(Xamarin.Forms.Maps.Circle.CenterProperty, value); } }
		[Parameter] public Xamarin.Forms.Maps.Distance Radius { set => P.Radius = value; get => P.Radius; }
		[Parameter] public Xamarin.Forms.Binding BindRadius { set { P.SetBinding(Xamarin.Forms.Maps.Circle.RadiusProperty, value); } }
		[Parameter] public Xamarin.Forms.Color FillColor { set => P.FillColor = value; get => P.FillColor; }
		[Parameter] public Xamarin.Forms.Binding BindFillColor { set { P.SetBinding(Xamarin.Forms.Maps.Circle.FillColorProperty, value); } }
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
