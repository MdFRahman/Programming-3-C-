using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateDemo
{
    public class ContactList : INotifyPropertyChanged
    {
        ContactDetails _editableContact;

        public ContactList()
        {
            Contacts = new ObservableCollection<ContactDetails>();
            EditableContact = new ContactDetails();
        }

        public ObservableCollection<ContactDetails> Contacts { get; set; }

        public ContactDetails EditableContact
        {
            get { return _editableContact; }
            set
            {
                _editableContact = value;
                OnNotifyPropertyChanged("EditableContact");
            }
        }

        private void OnNotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddEditableContact()
        {
            Contacts.Add(EditableContact);
            EditableContact = new ContactDetails();
        }
    }
}
