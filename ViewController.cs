using System;

using UIKit;
using System.Data;


namespace ibrahimapp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			//string []data=new string[]{"ibrahim","taleb","mohammed","dahan"};

			locatservice.WebServicetesting ws = new locatservice.WebServicetesting ();
			ws.allusersAsync ();
			ws.allusersCompleted += Handle_ServicegetDrugsCompleted;

		
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}





		        private void Handle_ServicegetDrugsCompleted(object sender,locatservice.allusersCompletedEventArgs args)
				{
					if(args.Result == null)
						return;
			        DataTable dt = new DataTable ();
			        dt = args.Result;

			       string[] data = new string[dt.Rows.Count];

			for (int i = 0; i < dt.Rows.Count; i++) 
			
			{
				data [i] = dt.Rows [i] [1].ToString ();


			}
			//show data in Table by Call TableSource.cs Class.
			UITableView _table1;
			_table1 = new UITableView {

				Frame =new CoreGraphics.CGRect(0,20,View.Bounds.Width,View.Bounds.Height),
				Source=new TableSource(data)
			};
			View.AddSubview(_table1);




				}
	}
}

