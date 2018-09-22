using System.Windows.Forms;

namespace UPnP
{
	[System.ComponentModel.DesignerCategory(@"Code")]
	public class DoubleBufferListView : ListView
	{
		public DoubleBufferListView()
		{
			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
			UpdateStyles();
		}
	}
}
