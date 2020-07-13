using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scheduler
{
    public static class ExtensionMethods
    {
		public static void AlignLabelToScreenHorizontally(this Label lbl, HorizontalAlignment horizontalAlignment)
		{
			Control parent = lbl.Parent;

			int lblLength = lbl.Width;
			int lblHeight = lbl.Height;

			Point point = new Point(0, lbl.Location.Y);

			switch (horizontalAlignment)
			{
				case HorizontalAlignment.Left:
					point.X = 5;
					break;
				case HorizontalAlignment.Right:
					point.X = parent.Width - lblLength - 25;
					break;
				case HorizontalAlignment.Center:
					point.X = (parent.Width / 2) - (lblLength / 2);
					break;
			}

			lbl.Location = point;
		}
	}
}
