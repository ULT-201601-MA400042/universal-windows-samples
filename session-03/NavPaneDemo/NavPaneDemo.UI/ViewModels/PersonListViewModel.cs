using NavPaneDemo.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavPaneDemo.UI.ViewModels
{
    public class PersonListViewModel
    {
        public ObservableCollection<Person> People { get; private set; }

        public PersonListViewModel()
        {
            using (var db = new ContactDbContext())
            {
                People = new ObservableCollection<Person>(db.People.ToList());
                //var people = db.People.ToList();
                //foreach (var person in people)
                //{
                //    People.Add(person);
                //};
            };
        }
    }
}
