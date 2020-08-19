
using Microsoft.AspNetCore.Components;
using LivingThing.Core.Frameworks.XamarinRazor.Forms;

namespace LivingThing.Core.Frameworks.XamarinRazor.Forms
{
    public partial class Map : ComponentToXamarinBridge<Xamarin.Forms.Maps.Map, Map>
    {
        public Map()
        {
        }
        public Map(Xamarin.Forms.Maps.Map _element):base(_element)
        {
        }

		[Parameter] public System.EventHandler<Xamarin.Forms.Maps.MapClickedEventArgs> OnMapClicked { set => P.MapClicked += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.FocusEventArgs> OnFocused { set => P.Focused += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.FocusEventArgs> OnUnfocused { set => P.Unfocused += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.Internals.EventArg<Xamarin.Forms.VisualElement>> OnBatchCommitted { set => P.BatchCommitted += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.VisualElement.FocusRequestArgs> OnFocusChangeRequested { set => P.FocusChangeRequested += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildAdded { set => P.ChildAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnChildRemoved { set => P.ChildRemoved += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantAdded { set => P.DescendantAdded += value; }
		[Parameter] public System.EventHandler<Xamarin.Forms.ElementEventArgs> OnDescendantRemoved { set => P.DescendantRemoved += value; }
		[Parameter] public System.Boolean HasScrollEnabled { set => P.HasScrollEnabled = value; get => P.HasScrollEnabled; }
		[Parameter] public Xamarin.Forms.Binding BindHasScrollEnabled { set { P.SetBinding(Xamarin.Forms.Maps.Map.HasScrollEnabledProperty, value); } }
		[Parameter] public System.Boolean HasZoomEnabled { set => P.HasZoomEnabled = value; get => P.HasZoomEnabled; }
		[Parameter] public Xamarin.Forms.Binding BindHasZoomEnabled { set { P.SetBinding(Xamarin.Forms.Maps.Map.HasZoomEnabledProperty, value); } }
		[Parameter] public System.Boolean IsShowingUser { set => P.IsShowingUser = value; get => P.IsShowingUser; }
		[Parameter] public Xamarin.Forms.Binding BindIsShowingUser { set { P.SetBinding(Xamarin.Forms.Maps.Map.IsShowingUserProperty, value); } }
		[Parameter] public Xamarin.Forms.Maps.MapType MapType { set => P.MapType = value; get => P.MapType; }
		[Parameter] public Xamarin.Forms.Binding BindMapType { set { P.SetBinding(Xamarin.Forms.Maps.Map.MapTypeProperty, value); } }
		[Parameter] public System.Collections.IEnumerable ItemsSource { set => P.ItemsSource = value; get => P.ItemsSource; }
		[Parameter] public Xamarin.Forms.Binding BindItemsSource { set { P.SetBinding(Xamarin.Forms.Maps.Map.ItemsSourceProperty, value); } }
		[Parameter] public Xamarin.Forms.DataTemplate ItemTemplate { set => P.ItemTemplate = value; get => P.ItemTemplate; }
		[Parameter] public Xamarin.Forms.Binding BindItemTemplate { set { P.SetBinding(Xamarin.Forms.Maps.Map.ItemTemplateProperty, value); } }
		[Parameter] public Xamarin.Forms.DataTemplateSelector ItemTemplateSelector { set => P.ItemTemplateSelector = value; get => P.ItemTemplateSelector; }
		[Parameter] public Xamarin.Forms.Binding BindItemTemplateSelector { set { P.SetBinding(Xamarin.Forms.Maps.Map.ItemTemplateSelectorProperty, value); } }
		[Parameter] public System.Boolean MoveToLastRegionOnLayoutChange { set => P.MoveToLastRegionOnLayoutChange = value; get => P.MoveToLastRegionOnLayoutChange; }
		[Parameter] public Xamarin.Forms.Binding BindMoveToLastRegionOnLayoutChange { set { P.SetBinding(Xamarin.Forms.Maps.Map.MoveToLastRegionOnLayoutChangeProperty, value); } }
		[Parameter] public Xamarin.Forms.LayoutOptions HorizontalOptions { set => P.HorizontalOptions = value; get => P.HorizontalOptions; }
		[Parameter] public Xamarin.Forms.Thickness Margin { set => P.Margin = value; get => P.Margin; }
		[Parameter] public Xamarin.Forms.LayoutOptions VerticalOptions { set => P.VerticalOptions = value; get => P.VerticalOptions; }
		[Parameter] public Xamarin.Forms.IVisual Visual { set => P.Visual = value; get => P.Visual; }
		[Parameter] public Xamarin.Forms.FlowDirection FlowDirection { set => P.FlowDirection = value; get => P.FlowDirection; }
		[Parameter] public System.Double AnchorX { set => P.AnchorX = value; get => P.AnchorX; }
		[Parameter] public System.Double AnchorY { set => P.AnchorY = value; get => P.AnchorY; }
		[Parameter] public Xamarin.Forms.Color BackgroundColor { set => P.BackgroundColor = value; get => P.BackgroundColor; }
		[Parameter] public System.Double HeightRequest { set => P.HeightRequest = value; get => P.HeightRequest; }
		[Parameter] public System.Boolean InputTransparent { set => P.InputTransparent = value; get => P.InputTransparent; }
		[Parameter] public System.Boolean IsEnabled { set => P.IsEnabled = value; get => P.IsEnabled; }
		[Parameter] public System.Boolean IsVisible { set => P.IsVisible = value; get => P.IsVisible; }
		[Parameter] public System.Double MinimumHeightRequest { set => P.MinimumHeightRequest = value; get => P.MinimumHeightRequest; }
		[Parameter] public System.Double MinimumWidthRequest { set => P.MinimumWidthRequest = value; get => P.MinimumWidthRequest; }
		[Parameter] public System.Double Opacity { set => P.Opacity = value; get => P.Opacity; }
		[Parameter] public System.Double Rotation { set => P.Rotation = value; get => P.Rotation; }
		[Parameter] public System.Double RotationX { set => P.RotationX = value; get => P.RotationX; }
		[Parameter] public System.Double RotationY { set => P.RotationY = value; get => P.RotationY; }
		[Parameter] public System.Double Scale { set => P.Scale = value; get => P.Scale; }
		[Parameter] public System.Double ScaleX { set => P.ScaleX = value; get => P.ScaleX; }
		[Parameter] public System.Double ScaleY { set => P.ScaleY = value; get => P.ScaleY; }
		[Parameter] public System.Int32 TabIndex { set => P.TabIndex = value; get => P.TabIndex; }
		[Parameter] public System.Boolean IsTabStop { set => P.IsTabStop = value; get => P.IsTabStop; }
		[Parameter] public System.Double TranslationX { set => P.TranslationX = value; get => P.TranslationX; }
		[Parameter] public System.Double TranslationY { set => P.TranslationY = value; get => P.TranslationY; }
		[Parameter] public System.Double WidthRequest { set => P.WidthRequest = value; get => P.WidthRequest; }
		[Parameter] public System.Boolean DisableLayout { set => P.DisableLayout = value; get => P.DisableLayout; }
		[Parameter] public System.Boolean IsInNativeLayout { set => P.IsInNativeLayout = value; get => P.IsInNativeLayout; }
		[Parameter] public System.Boolean IsNativeStateConsistent { set => P.IsNativeStateConsistent = value; get => P.IsNativeStateConsistent; }
		[Parameter] public System.Boolean IsPlatformEnabled { set => P.IsPlatformEnabled = value; get => P.IsPlatformEnabled; }
		[Parameter] public Xamarin.Forms.ResourceDictionary Resources { set => P.Resources = value; get => P.Resources; }
		[Parameter] public Xamarin.Forms.Style Style { set => P.Style = value; get => P.Style; }
		[Parameter] public System.Collections.Generic.IList<System.String> StyleClass { set => P.StyleClass = value; get => P.StyleClass; }
		[Parameter] public System.Collections.Generic.IList<System.String> @class { set => P.@class = value; get => P.@class; }
		[Parameter] public System.String AutomationId { set => P.AutomationId = value; get => P.AutomationId; }
		[Parameter] public System.String ClassId { set => P.ClassId = value; get => P.ClassId; }
		[Parameter] public System.String StyleId { set => P.StyleId = value; get => P.StyleId; }
		[Parameter] public Xamarin.Forms.Element Parent { set => P.Parent = value; get => P.Parent; }
		[Parameter] public Xamarin.Forms.IEffectControlProvider EffectControlProvider { set => P.EffectControlProvider = value; get => P.EffectControlProvider; }
		[Parameter] public System.Object BindingContext { set => P.BindingContext = value; get => P.BindingContext; }
    }
}
