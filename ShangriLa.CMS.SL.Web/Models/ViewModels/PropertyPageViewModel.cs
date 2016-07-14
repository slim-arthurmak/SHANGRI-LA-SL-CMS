using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Business;



namespace ShangriLa.CMS.SL.Web.Models.ViewModels
{
    public class PropertyPageViewModel : PageViewModel<HotelPage>
    {
        public PropertyPageViewModel() : base()
        {
            BookingPanel = new BookingPanelModel();
        }

        public PropertyPageViewModel(HotelPage currentPage) : base(currentPage)
        {
            BookingPanel = new BookingPanelModel();
        }


        public BookingPanelModel BookingPanel { get; set; }
    }
}