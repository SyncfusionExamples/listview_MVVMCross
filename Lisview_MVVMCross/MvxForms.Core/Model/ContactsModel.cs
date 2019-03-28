using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxForms.Core
{
    public class GroupContacts : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private string displayString;

        public GroupContacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
            displayString = name[0].ToString();
        }

        public GroupContacts()
        {

        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public string DisplayString
        {
            get { return displayString; }
            set
            {
                if (displayString != value)
                {
                    displayString = value;
                    this.RaisedOnPropertyChanged("DisplayString");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
