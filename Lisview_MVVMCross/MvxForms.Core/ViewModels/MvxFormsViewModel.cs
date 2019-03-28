using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Core.ViewModels
{
    public class MvxFormsViewModel : MvxViewModel
    {
        public MvxFormsViewModel()
        {
            
            //TODO: Add starting logic here
            GenerateObservableCollection();
        }
        
        public override Task Initialize()
        {
            return base.Initialize();
        }

        //public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private ObservableCollection<GroupContacts> contactsInfo;
        private Random random = new Random(0123456789);
        public ObservableCollection<GroupContacts> ContactsInfo
        {
            get { return contactsInfo; }
            set
            {
                contactsInfo = value;
            }
        }

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private void GenerateObservableCollection()
        {
            contactsInfo = new ObservableCollection<GroupContacts>();
            for (int i = 0; i < CustomerNames.Count(); i++)
            {
                var contact = new GroupContacts(CustomerNames[i], CustomerNumbers[i]);
                contactsInfo.Add(contact);
            }
        }

        #region ItemsSource

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson"    ,
            "Mason  "    ,
            "Liam   "    ,
            "Jacob  "    ,
            "Jayden "    ,
            "Ethan  "    ,
            "Noah   "    ,
            "Lucas  "    ,
            "Logan  "    ,
            "Caleb  "    ,
            "Caden  "    ,
            "Jack   "    ,
            "Ryan   "    ,
            "Connor "    ,
            "Michael"    ,
            "Elijah "    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James  "    ,
            "Landon "    ,
            "Nathan "    ,
            "Dylan  "    ,
            "Evan   "    ,
            "Luke   "    ,
            "Andrew "    ,
            "Gabriel"    ,
            "Gavin  "    ,
            "Joshua "    ,
            "Owen   "    ,
            "Daniel "    ,
            "Carter "    ,
            "Tyler  "    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt  "    ,
            "Henry  "    ,
            "Eli    "    ,
            "Joseph "    ,
            "Max    "    ,
            "Isaac  "    ,
            "Samuel "    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David  "    ,
            "Christopher",
            "John   "    ,
            "Isaiah "    ,
            "Levi   "    ,
            "Jonathan"   ,
            "Oliver "    ,
            "Chase  "    ,
            "Cooper "    ,
            "Tristan"    ,
            "Colton "    ,
            "Austin "    ,
            "Colin  "    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker "    ,
            "Hunter "    ,
            "Thomas "    ,
            "Alex   "    ,
            "Ian    "    ,
            "Jordan "    ,
            "Cole   "    ,
            "Julian "    ,
            "Aaron  "    ,
            "Carson "    ,
            "Miles  "    ,
            "Blake  "    ,
            "Brody  "    ,
            "Adam   "    ,
            "Sebastian"  ,
            "Adrian "    ,
            "Nolan  "    ,
            "Sean   "    ,
            "Riley  "    ,
            "Bentley"    ,
            "Xavier "    ,
            "Hayden "    ,
            "Jeremiah"   ,
            "Jason  "    ,
            "Jake   "    ,
            "Asher  "    ,
            "Micah  "    ,
            "Jace   "    ,
            "Brandon"    ,
            "Josiah "    ,
            "Hudson "    ,
            "Nathaniel"  ,
            "Bryson "    ,
            "Ryder  "    ,
            "Justin "    ,
            "Bryce  "    ,
        };

        string[] CustomerNumbers = new string[]
        {
            "783 - 3617",
            "763 - 3879",
            "754 - 3627",
            "760 - 3893",
            "781 - 3813",
            "720 - 3146",
            "745 - 3151",
            "787 - 3143",
            "789 - 3275",
            "746 - 3950",
            "784 - 3904",
            "738 - 3827",
            "747 - 3550",
            "737 - 3792",
            "772 - 3868",
            "768 - 3312",
            "791 - 3920",
            "723 - 3498",
            "758 - 3115",
            "731 - 3051",
            "753 - 3364",
            "734 - 3443",
            "759 - 3089",
            "769 - 3639",
            "789 - 3289",
            "735 - 3200",
            "761 - 3636",
            "748 - 3905",
            "749 - 3728",
            "762 - 3883",
            "751 - 3723",
            "737 - 3911",
            "735 - 3702",
            "738 - 3402",
            "727 - 3365",
            "771 - 3771",
            "729 - 3298",
            "761 - 3467",
            "776 - 3798",
            "745 - 3273",
            "793 - 3594",
            "792 - 3388",
            "772 - 3429",
            "781 - 3280",
            "764 - 3148",
            "729 - 3760",
            "765 - 3269",
            "770 - 3700",
            "730 - 3281",
            "739 - 3800",
            "787 - 3232",
            "762 - 3521",
            "770 - 3434",
            "725 - 3244",
            "728 - 3894",
            "734 - 3584",
            "751 - 3272",
            "795 - 3807",
            "783 - 3844",
            "739 - 3772",
            "792 - 3956",
            "785 - 3957",
            "739 - 3891",
            "735 - 3860",
            "771 - 3834",
            "746 - 3449",
            "763 - 3530",
            "752 - 3702",
            "724 - 3402",
            "779 - 3246",
            "748 - 3544",
            "733 - 3672",
            "795 - 3538",
            "748 - 3315",
            "744 - 3839",
            "790 - 3294",
            "722 - 3478",
            "789 - 3893",
            "751 - 3583",
            "741 - 3744",
            "738 - 3217",
            "766 - 3275",
            "764 - 3744",
            "722 - 3874",
            "787 - 3264",
            "779 - 3415",
            "727 - 3014",
            "752 - 3388",
            "782 - 3170",
            "720 - 3711",
            "762 - 3887",
            "763 - 3809",
            "794 - 3053",
            "752 - 3089",
            "771 - 3527",
            "744 - 3477",
            "729 - 3017",
            "720 - 3153",
            "795 - 3903",
            "728 - 3218",
            "760 - 3488",
            "756 - 3055",
            "726 - 3485",
            "735 - 3036",
            "724 - 3498",
            "728 - 3237",
            "765 - 3568",
            "736 - 3351",
            "771 - 3782",
            "745 - 3522",
            "746 - 3947",
            "737 - 3332",
            "795 - 3288",
            "742 - 3096",
            "798 - 3278",
            "754 - 3881",
            "724 - 3795",
            "736 - 3058",
            "753 - 3514",
            "777 - 3465",
            "787 - 3391",
            "721 - 3164",
            "752 - 3086",
            "790 - 3562",
            "783 - 3662",
        };

        #endregion
    }
}