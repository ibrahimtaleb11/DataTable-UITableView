using System;
using UIKit;

namespace ibrahimapp
{
	public class TableSource:UITableViewSource
	{
		string[]tableitems;
		string cellidentifier="TableCell";

		public TableSource (string[] items)
		{
			tableitems = items;

		}

		//retuen length table
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableitems.Length;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			new UIAlertView ("Alert", "You Click On" + tableitems [indexPath.Row], null, "ok", null).Show ();
			tableView.DeselectRow (indexPath, true);
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellidentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellidentifier);
			cell.TextLabel.Text = tableitems [indexPath.Row];
			return cell;
		}
	}
}

