namespace Sample
{
	using System;
	using MonoTouch.Dialog;
    using MonoTouch.UIKit;
	
	public class HomeController : DialogViewController
	{
		public HomeController() : base(new RootElement("Home"))	
		{
//			this.Root.Add
//			(
//				new Section("View Deck") 
//				{
//					new StringElement("Simple", this.ViewDeckSimpleSample),
//                    new StringElement("Navigation (Contained)", this.ViewDeckContainedSample),
//                    new StringElement("Navigation (Integrated)", this.ViewDeckIntegratedSample),
//                    new StringElement("Multi-Deck", this.ViewDeckMultiDeckSample),	
//				});
			
			this.Root.Add
			(
				new Section("AwesomeMenu") 
				{
					new StringElement("Simple", this.AwesomeMenuSample),
				}
			);
            
//            this.Root.Add
//                (
//                    new Section("Panorama") 
//                    {
//                    new StringElement("Simple", this.PanoramaSample),
//                }
//                );
        }
		
//		public void ViewDeckSimpleSample()
//		{
//			var leftController = new ViewDeckSamples.LeftController();
//			var rightController = new ViewDeckSamples.RightController();
//			
//			var centerController = new ViewDeckSamples.CenterController(true);
//			
//			var deckController = new ViewDeckController(centerController, leftController, rightController);
//			deckController.RightLedge = 40;
//			deckController.LeftLedge = 100;
//            // use this to control if panning is enabled
//            // deckController.Enabled = false;
//			
//			this.PresentViewController(deckController, true, null);
//			
//		}
//        
//        public void ViewDeckContainedSample()
//        {
//            var nav = new UINavigationController(new ViewDeckSamples.NavigationStartController(true));
//            
//            this.PresentViewController(nav, true, null);
//        }
//        
//        public void ViewDeckIntegratedSample()
//        {
//            var nav = new UINavigationController(new ViewDeckSamples.NavigationStartController(false));
//            
//            this.PresentViewController(nav, true, null);
//        }
//        
//        public void ViewDeckMultiDeckSample()
//        {
//            var leftController = new ViewDeckSamples.MultiMiddleController(); 
//            var bottomController = new ViewDeckSamples.MultiBottomController();
//
//            var centerController = new ViewDeckSamples.MultiTopController();
//
//            var secondDeckController = new ViewDeckController(leftController, bottomController);
//            secondDeckController.LeftLedge = 100;
//            
//            var deckController = new ViewDeckController(centerController, secondDeckController);
//            deckController.LeftLedge = 30;
//            
//            this.PresentViewController(deckController, true, null);
//        }

        public void AwesomeMenuSample()
        {
            this.PresentViewController(new Sample.Samples.AwesomeMenu.MenuController(), true, null);
        }

//        public void PanoramaSample()
//        {
//            this.PresentViewController(new PanoramaSamples.TestPanorama(), true, null);
//        }
//
//		public void Test()
//		{
//		}
	}
}