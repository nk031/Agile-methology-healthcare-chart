using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FinalProject.Controls
{
    // Calendar for application
    [Preserve(AllMembers = true)]
    // will pick appointment date and show it in calendar
    public class CalenderDatePicker : DatePicker
    {
        public string PlaceHolderText { get; set; }
    }
}
