
using Microsoft.AspNetCore.Components;
using LivingThing.Core.Frameworks.XamarinRazor.Forms;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class Pin : ComponentToXamarinBridge<Xamarin.Forms.Maps.Pin, Pin>
    {
        public Pin()
        {
        }
        public Pin(Xamarin.Forms.Maps.Pin _element):base(_element)
        {
        }

		[Parameter] public System.EventHandler<Xamarin.Forms.Maps.PinClickedEventArgs> OnMarkerClicked { set => P.MarkerClicked += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.Maps.PinClickedEventArgs> OnInfoWindowClicked { set => P.InfoWindowClicked += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildAdded { set => P.ChildAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildRemoved { set => P.ChildRemoved += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantAdded { set => P.DescendantAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantRemoved { set => P.DescendantRemoved += value; }
		[Parameter] public System.String Address { set => P.Address = value; get => P.Address; }
		[Parameter] public Xamarin.Forms.Binding BindAddress { set { P.SetBinding(Xamarin.Forms.Maps.Pin.AddressProperty, value); } }
		[Parameter] public System.String Label { set => P.Label = value; get => P.Label; }
		[Parameter] public Xamarin.Forms.Binding BindLabel { set { P.SetBinding(Xamarin.Forms.Maps.Pin.LabelProperty, value); } }
		[Parameter] public Xamarin.Forms.Maps.Position Position { set => P.Position = value; get => P.Position; }
		[Parameter] public Xamarin.Forms.Binding BindPosition { set { P.SetBinding(Xamarin.Forms.Maps.Pin.PositionProperty, value); } }
		[Parameter] public Xamarin.Forms.Maps.PinType Type { set => P.Type = value; get => P.Type; }
		[Parameter] public Xamarin.Forms.Binding BindType { set { P.SetBinding(Xamarin.Forms.Maps.Pin.TypeProperty, value); } }
		[Parameter] public System.Object MarkerId { set => P.MarkerId = value; get => P.MarkerId; }
		[Parameter] public System.String AutomationId { set => P.AutomationId = value; get => P.AutomationId; }
		[Parameter] public System.String ClassId { set => P.ClassId = value; get => P.ClassId; }
		[Parameter] public System.String StyleId { set => P.StyleId = value; get => P.StyleId; }
		[Parameter] public Xamarin.Forms.Element Parent { set => P.Parent = value; get => P.Parent; }
		[Parameter] public Xamarin.Forms.IEffectControlProvider EffectControlProvider { set => P.EffectControlProvider = value; get => P.EffectControlProvider; }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
    }
}
