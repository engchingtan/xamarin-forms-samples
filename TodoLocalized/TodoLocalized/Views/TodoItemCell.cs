﻿using System;
using Xamarin.Forms;

namespace TodoLocalized
{
	public class TodoItemCell : ViewCell
	{
		public TodoItemCell ()
		{
			var label = new Label {
				VerticalTextAlignment = TextAlignment.Center
			};
			label.SetBinding (Label.TextProperty, "Name");

			var tick = new Image {
				Source = ImageSource.FromFile ("check.png"),
			};
			tick.SetBinding (Image.IsVisibleProperty, "Done");

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 0, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = { label, tick }
			};

			// HACK: Enable RIGHT-TO-LEFT
			RtlEffect.SetShouldObeyRtl(layout, true);
			View = layout;
		}
	}
}

