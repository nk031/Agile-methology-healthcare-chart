using Xamarin.Forms.Internals;

namespace FinalProject.Models
{
    //created class for add region 
    [Preserve(AllMembers = true)]
    public class CountryModel //primary key
    {
        #region Properties

        public string Country { get; set; }

        public string[] States { get; set; }
        public string[] ZipCode { get; set; }



    }

        #endregion
}